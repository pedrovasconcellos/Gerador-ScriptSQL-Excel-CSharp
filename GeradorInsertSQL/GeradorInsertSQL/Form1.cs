using System;
using System.Windows.Forms;

using System.Runtime.InteropServices; // ativamento da leitura do excell MARSHAL
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Text;

namespace GeradorInsertSQL
{
    public partial class Form1 : Form
    {
        string folder = @"C:\www.vasconcellos.site\ScriptSQL\";
        public Form1()
        {
            InitializeComponent();
            cbxTipoDeExcel.SelectedIndex = 0;
            cbxFiltro.SelectedIndex = 0;
     
            if (!Directory.Exists(folder))
            {

                Directory.CreateDirectory(folder);
                MessageBox.Show(String.Concat("O Diretório ", folder,
                    " foi criado com sucesso! Por favor utilize este diretório para armazenar a planilha que será importada."));
            }

            DateTime thisDay = DateTime.Today;
            lblCopyRight.Text = "Copyright © " + thisDay.Year + " Vasconcellos IT Solutions";
        }

        private void btnImportarPlanilha_Click(object sender, EventArgs e)
        {
            //TESTE ------ SE OS CAMPOS ESTIVEREM VAZIOS O SISTEMA REALIZA O TESTE ATRAVÉS DA PLANILHA DE TESTE
            if ((txtNomeAquivo.Text == "") && (txtNomeTabela.Text == "" && txtNomeColunas.Text == ""))
            {
                //HttpContext.Current.Server.MapPath(@"~\Excel\")
                txtNomeAquivo.Text = "InsertSQLTeste";
                txtNomeColunas.Text = "NOME,@RA,@MEDIA,@ATIVO,SALA";
                txtNomeTabela.Text = "ALUNOS";
                cbxFiltro.Text = "@";
                cbxTipoDeExcel.Text = ".xlsx";

                //OBTÉM O DIRETÓRIO DO .exe DA APLICAÇÃO
                //string caminhox = System.Reflection.Assembly.GetExecutingAssembly().Location;

                //OBTÉM O DIRETÓRIO DO FOLDER \Excel DA APLICAÇÃO
                Environment.CurrentDirectory = @"..\..\Excel";
                string fullPath = Directory.GetCurrentDirectory();

                string excelTeste = 
                    Path.Combine(fullPath,String.Concat(txtNomeAquivo.Text , cbxTipoDeExcel.Text));

                if(!File.Exists(String.Concat(folder, txtNomeAquivo.Text, cbxTipoDeExcel.Text)))
                { 
                    File.Copy(excelTeste, String.Concat(folder, txtNomeAquivo.Text, cbxTipoDeExcel.Text));
                }

            }
            //TESTE

            string caminhoimportacao = String.Concat(folder, txtNomeAquivo.Text, cbxTipoDeExcel.Text);
            lblNomeArquivo.Text = caminhoimportacao;
            
            if ((txtNomeAquivo.Text != "" && File.Exists(caminhoimportacao)) && txtNomeTabela.Text != "")
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(String.Concat(folder, txtNomeAquivo.Text, cbxTipoDeExcel.Text));
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;

                ///string ValorDaCelula = xlWorksheet.Cells[1, 1].Value.ToString(); Obtendo Valor da [Coluna,Linha]
                StringBuilder texto  = new StringBuilder();
                string espaco = " ";

                string filtrostr = cbxFiltro.Text;
                string i_colunasfixo = "";
                string i_colunasmeio = (txtNomeColunas.Text == "")? i_colunasfixo : txtNomeColunas.Text;

                string i_inicio = String.Concat("INSERT INTO", espaco);
                string i_tabela = String.Concat(txtNomeTabela.Text, espaco);
                string i_colunas = String.Concat("(", i_colunasmeio, ")", espaco);
                string i_value = "VALUES (";
                string i_final = String.Concat("); ", Environment.NewLine, Environment.NewLine);
                int qtdcharcol = i_colunas.Length;

                int countvirgula = 0;
                for (int i = 0; i < qtdcharcol; i++)
                {
                    if (i_colunas[i] == ',')
                    {
                        countvirgula++;
                    };
                }

                if (colCount != (countvirgula + 1))
                {
                    MessageBox.Show("O número de colunas digitadas no campo do sistema, difere do número de colunas do Excel importado.");
                }
                else
                {
                    //Definindo INT BIT para não colocar aspas simples no ScriptSQL
                    int[] positionsvirgula = new int[countvirgula];
                    countvirgula = 0;
                    int count = 0;
                    int countpv = 0;
                    for (int i = 0; i < qtdcharcol; i++)
                    {
                        if (i_colunas[i] == ',')
                        {
                            countvirgula++;
                            if (Convert.ToInt32(i_colunas[i + 1]) == Convert.ToInt32(filtrostr[0]))
                            {
                                positionsvirgula[count++] = countvirgula + 1;//{}
                                countpv++;//qtd
                            }
                        };

                    }

                    string i_colunasfiltro = i_colunas.Replace(filtrostr, "");
                    int countpv2 = 0;
                    string i_dados = "";

                    try
                    {
                        for (int i = 1; i <= rowCount; i++)
                        {
                            i_dados = "";
                            countpv2 = 0;
                            for (int j = 1; j <= colCount; j++)
                            {
                                if (String.Equals(xlWorksheet.Cells[i, j].Value, "NULL"))
                                {
                                    i_dados += xlWorksheet.Cells[i, j].Value;
                                }
                                else
                                {
                                    if (j == positionsvirgula[countpv2] && countpv2 <= countpv)
                                    {
                                        i_dados += (xlWorksheet.Cells[i, j].Value != null) ? xlWorksheet.Cells[i, j].Value : "''";
                                        countpv2++;
                                    }
                                    else
                                    {
                                        i_dados += (xlWorksheet.Cells[i, j].Value != null) ?
                                            String.Concat("'", xlWorksheet.Cells[i, j].Value, "'") : "''";
                                    }
                                }

                                if (j != colCount)
                                {
                                    i_dados += ",";
                                }
                            }

                            texto.
                                Append(i_inicio).
                                Append(i_tabela).
                                Append(i_colunasfiltro).
                                Append(i_value).
                                Append(i_dados).
                                Append(i_final);

                        }
                        GerarArquivo(texto.ToString(), folder, i_tabela);
                    }
                    catch
                    {
                        MessageBox.Show("Erro, por favor verifique se as informações fornecidas ao sistema, estão corretas");
                    }
                }

                //FECHANDO OS PROCESSOS
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //OBS:nunca use dois pontos, todos os objetos COM devem ser referenciados e liberados individualmente
                //Liberar objetos COM para matar completamente processo de execução do excel em segundo plano
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
                //FECHANDO OS PROCESSOS
            }
            else 
            {
                MessageBox.Show(String.Concat("1 - Verifique se o arquivo que você deseja, existe dentro do diretório ",
                    folder, Environment.NewLine, Environment.NewLine,
                "2 - Escreva o nome da Tabela que você deseja criar o Insert no campo Nome da Tabela"));
            }

        }

        public void GerarArquivo(string texto, string folder, string i_tabela)
        {
            //---Gerando INSERT-SQL.TXT
            string tipoarquivo = ".txt";
            string nomedoarquivo = String.Concat("INSERT-SQL - TABELA ", i_tabela);
            string caminhodoarquivo = String.Concat(folder, nomedoarquivo, tipoarquivo);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(caminhodoarquivo))
            {
                file.Write(texto);
                MessageBox.Show(String.Concat(" O ", tipoarquivo, 
                    " do INSERT-SQL foi gerado com sucesso! O seu arquivo foi salvo no diretório ", folder));
                System.Diagnostics.Process.Start(caminhodoarquivo);
            }
            //---Gerando INSERT-SQL.TXT
        }

        private void btnAbrirPlanilha_Click(object sender, EventArgs e)
        {
            if (txtNomeAquivo.Text != "")
            {
                try
                {
                    System.Diagnostics.Process.Start(String.Concat(folder, txtNomeAquivo.Text, cbxTipoDeExcel.Text));
                }
                catch
                {
                    MessageBox.Show("Planilha não encontrada");
                }
            }
            else
            {
                MessageBox.Show("Escreva o nome da planilha que você deseja abrir");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                String.Concat("Help ?", Environment.NewLine, Environment.NewLine, Environment.NewLine,
                "0 - Clique em Importar Planilha sem preencher os dados para realizar um TESTE ;", Environment.NewLine, Environment.NewLine,
                "1 - Escreva o nome da planilha no campo Nome do Arquivo ;", Environment.NewLine, Environment.NewLine,
                "2 - Selecione o tipo de arquivo na caixa de seleção ;", Environment.NewLine, Environment.NewLine,
                "3 - Escreva os nomes das colunas no campo Colunas da Tabela ;", Environment.NewLine, Environment.NewLine,
                "4 - Escreva o nome da Tabela que você deseja criar o INSERT no campo Nome da Tabela ;", Environment.NewLine, Environment.NewLine,
                "5 - Selecione o tipo de filtro usado para Colunas do type INT,BIT,DECIMAL... ;", Environment.NewLine, Environment.NewLine,
                "6 - Após selecionar o filtro, escreva o mesmo caractere contido no campo de seleção,",
                    " no campo Coluna da Tabela para cada coluna dos tipos acima ;", Environment.NewLine, Environment.NewLine,
                "7 - Clique no botão Importar Planilha.", Environment.NewLine, Environment.NewLine,
                "8 - Todos os arquivos de importação e geração do sistema, deverão ser armazenados no diretório ", folder));
        }

        private void btnAbrirDiretorio_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(folder);
            }
            catch
            {
                MessageBox.Show("Diretório não encontrador");
            }

        }

    }
}
