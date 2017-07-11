namespace GeradorInsertSQL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnImportarPlanilha = new System.Windows.Forms.Button();
            this.btnAbrirPlanilha = new System.Windows.Forms.Button();
            this.cbxTipoDeExcel = new System.Windows.Forms.ComboBox();
            this.txtNomeAquivo = new System.Windows.Forms.TextBox();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNomeColunas = new System.Windows.Forms.TextBox();
            this.lblNomeColunas = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.txtNomeTabela = new System.Windows.Forms.TextBox();
            this.lblNomeTabela = new System.Windows.Forms.Label();
            this.btnAbrirDiretorio = new System.Windows.Forms.Button();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImportarPlanilha
            // 
            this.btnImportarPlanilha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImportarPlanilha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarPlanilha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImportarPlanilha.Location = new System.Drawing.Point(174, 138);
            this.btnImportarPlanilha.Name = "btnImportarPlanilha";
            this.btnImportarPlanilha.Size = new System.Drawing.Size(166, 23);
            this.btnImportarPlanilha.TabIndex = 6;
            this.btnImportarPlanilha.Text = "Importar Planilha";
            this.btnImportarPlanilha.UseVisualStyleBackColor = false;
            this.btnImportarPlanilha.Click += new System.EventHandler(this.btnImportarPlanilha_Click);
            // 
            // btnAbrirPlanilha
            // 
            this.btnAbrirPlanilha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAbrirPlanilha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPlanilha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbrirPlanilha.Location = new System.Drawing.Point(174, 166);
            this.btnAbrirPlanilha.Name = "btnAbrirPlanilha";
            this.btnAbrirPlanilha.Size = new System.Drawing.Size(166, 23);
            this.btnAbrirPlanilha.TabIndex = 7;
            this.btnAbrirPlanilha.Text = "Abrir Planilha";
            this.btnAbrirPlanilha.UseVisualStyleBackColor = false;
            this.btnAbrirPlanilha.Click += new System.EventHandler(this.btnAbrirPlanilha_Click);
            // 
            // cbxTipoDeExcel
            // 
            this.cbxTipoDeExcel.FormattingEnabled = true;
            this.cbxTipoDeExcel.Items.AddRange(new object[] {
            ".xlsx",
            ".xls"});
            this.cbxTipoDeExcel.Location = new System.Drawing.Point(276, 48);
            this.cbxTipoDeExcel.Name = "cbxTipoDeExcel";
            this.cbxTipoDeExcel.Size = new System.Drawing.Size(64, 21);
            this.cbxTipoDeExcel.TabIndex = 5;
            // 
            // txtNomeAquivo
            // 
            this.txtNomeAquivo.Location = new System.Drawing.Point(47, 48);
            this.txtNomeAquivo.Name = "txtNomeAquivo";
            this.txtNomeAquivo.Size = new System.Drawing.Size(223, 20);
            this.txtNomeAquivo.TabIndex = 1;
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNomeArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeArquivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomeArquivo.Location = new System.Drawing.Point(12, 9);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(0, 13);
            this.lblNomeArquivo.TabIndex = 5;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescricao.Location = new System.Drawing.Point(48, 29);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(104, 13);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Nome do Arquivo";
            // 
            // txtNomeColunas
            // 
            this.txtNomeColunas.Location = new System.Drawing.Point(47, 94);
            this.txtNomeColunas.Name = "txtNomeColunas";
            this.txtNomeColunas.Size = new System.Drawing.Size(293, 20);
            this.txtNomeColunas.TabIndex = 2;
            // 
            // lblNomeColunas
            // 
            this.lblNomeColunas.AutoSize = true;
            this.lblNomeColunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeColunas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomeColunas.Location = new System.Drawing.Point(50, 75);
            this.lblNomeColunas.Name = "lblNomeColunas";
            this.lblNomeColunas.Size = new System.Drawing.Size(113, 13);
            this.lblNomeColunas.TabIndex = 8;
            this.lblNomeColunas.Text = "Colunas da Tabela";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiltro.Location = new System.Drawing.Point(44, 171);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(84, 13);
            this.lblFiltro.TabIndex = 9;
            this.lblFiltro.Text = "Filtro INT BIT";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "@",
            "#"});
            this.cbxFiltro.Location = new System.Drawing.Point(47, 188);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(81, 21);
            this.cbxFiltro.TabIndex = 4;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHelp.Location = new System.Drawing.Point(134, 188);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(29, 23);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // txtNomeTabela
            // 
            this.txtNomeTabela.Location = new System.Drawing.Point(47, 138);
            this.txtNomeTabela.Name = "txtNomeTabela";
            this.txtNomeTabela.Size = new System.Drawing.Size(105, 20);
            this.txtNomeTabela.TabIndex = 3;
            // 
            // lblNomeTabela
            // 
            this.lblNomeTabela.AutoSize = true;
            this.lblNomeTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTabela.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomeTabela.Location = new System.Drawing.Point(44, 122);
            this.lblNomeTabela.Name = "lblNomeTabela";
            this.lblNomeTabela.Size = new System.Drawing.Size(100, 13);
            this.lblNomeTabela.TabIndex = 11;
            this.lblNomeTabela.Text = "Nome da Tabela";
            // 
            // btnAbrirDiretorio
            // 
            this.btnAbrirDiretorio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAbrirDiretorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirDiretorio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbrirDiretorio.Location = new System.Drawing.Point(174, 195);
            this.btnAbrirDiretorio.Name = "btnAbrirDiretorio";
            this.btnAbrirDiretorio.Size = new System.Drawing.Size(166, 23);
            this.btnAbrirDiretorio.TabIndex = 8;
            this.btnAbrirDiretorio.Text = "Diretório Padrão";
            this.btnAbrirDiretorio.UseVisualStyleBackColor = false;
            this.btnAbrirDiretorio.Click += new System.EventHandler(this.btnAbrirDiretorio_Click);
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCopyRight.Location = new System.Drawing.Point(105, 227);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(235, 13);
            this.lblCopyRight.TabIndex = 15;
            this.lblCopyRight.Text = "Copyright © YYYY Vasconcellos IT Solutions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(389, 248);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.btnAbrirDiretorio);
            this.Controls.Add(this.lblNomeTabela);
            this.Controls.Add(this.txtNomeTabela);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblNomeColunas);
            this.Controls.Add(this.txtNomeColunas);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNomeArquivo);
            this.Controls.Add(this.txtNomeAquivo);
            this.Controls.Add(this.cbxTipoDeExcel);
            this.Controls.Add(this.btnAbrirPlanilha);
            this.Controls.Add(this.btnImportarPlanilha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gerador de Script SQL INSERT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportarPlanilha;
        private System.Windows.Forms.Button btnAbrirPlanilha;
        private System.Windows.Forms.ComboBox cbxTipoDeExcel;
        private System.Windows.Forms.TextBox txtNomeAquivo;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNomeColunas;
        private System.Windows.Forms.Label lblNomeColunas;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox txtNomeTabela;
        private System.Windows.Forms.Label lblNomeTabela;
        private System.Windows.Forms.Button btnAbrirDiretorio;
        private System.Windows.Forms.Label lblCopyRight;
    }
}

