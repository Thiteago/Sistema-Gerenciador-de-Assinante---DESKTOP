namespace project_ling.View
{
    partial class Form_RelatorioPeriodo
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
            this.listViewRelatorio = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumOS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Servico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataAbertura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataExecucao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btGerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSituacao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dpDe = new System.Windows.Forms.DateTimePicker();
            this.dpAte = new System.Windows.Forms.DateTimePicker();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewRelatorio
            // 
            this.listViewRelatorio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NumOS,
            this.Servico,
            this.Nome,
            this.Status,
            this.DataAbertura,
            this.DataExecucao});
            this.listViewRelatorio.GridLines = true;
            this.listViewRelatorio.HideSelection = false;
            this.listViewRelatorio.Location = new System.Drawing.Point(12, 12);
            this.listViewRelatorio.Name = "listViewRelatorio";
            this.listViewRelatorio.Size = new System.Drawing.Size(632, 473);
            this.listViewRelatorio.TabIndex = 0;
            this.listViewRelatorio.UseCompatibleStateImageBehavior = false;
            this.listViewRelatorio.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID Cliente";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 125;
            // 
            // NumOS
            // 
            this.NumOS.Text = "Numero O.S";
            this.NumOS.Width = 70;
            // 
            // Servico
            // 
            this.Servico.Text = "Servico";
            this.Servico.Width = 100;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // DataAbertura
            // 
            this.DataAbertura.Text = "Data de Abertura";
            this.DataAbertura.Width = 100;
            // 
            // DataExecucao
            // 
            this.DataExecucao.Text = "Data de Execucao";
            this.DataExecucao.Width = 110;
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(666, 377);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(243, 23);
            this.btGerar.TabIndex = 1;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(663, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Situacao";
            // 
            // comboSituacao
            // 
            this.comboSituacao.FormattingEnabled = true;
            this.comboSituacao.Items.AddRange(new object[] {
            "Pendente",
            "Executado"});
            this.comboSituacao.Location = new System.Drawing.Point(718, 85);
            this.comboSituacao.Name = "comboSituacao";
            this.comboSituacao.Size = new System.Drawing.Size(193, 21);
            this.comboSituacao.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(663, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "De";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(663, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ate";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "ADEQUACAO DE FIBRA",
            "INSPEÇÃO E VISTORIA",
            "INSTALACAO DE ROTEADOR",
            "IP FIXO",
            "MANUTENCAO DE FIBRA",
            "MANUTENCAO DE WIRELESS",
            "MIGRACAO WIRELESS P/ FIBRA",
            "MIGRACAO FIBRA P/ WIRELESS",
            "PRIMEIRA CONEXAO",
            "RECONEXAO DE CONTRATO CANCELADO",
            "TRANSFERENCIA DE ENDERECO",
            "TRANSFERENCIA DE PONTO INTERNO",
            "RECOLHIMENTO"});
            this.checkedListBox1.Location = new System.Drawing.Point(666, 172);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(245, 199);
            this.checkedListBox1.TabIndex = 8;
            // 
            // dpDe
            // 
            this.dpDe.Location = new System.Drawing.Point(690, 112);
            this.dpDe.MaxDate = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            this.dpDe.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dpDe.Name = "dpDe";
            this.dpDe.Size = new System.Drawing.Size(219, 20);
            this.dpDe.TabIndex = 9;
            this.dpDe.ValueChanged += new System.EventHandler(this.dpDe_ValueChanged);
            // 
            // dpAte
            // 
            this.dpAte.Location = new System.Drawing.Point(692, 142);
            this.dpAte.MaxDate = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            this.dpAte.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dpAte.Name = "dpAte";
            this.dpAte.Size = new System.Drawing.Size(219, 20);
            this.dpAte.TabIndex = 10;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(834, 12);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 11;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // Form_RelatorioPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(921, 497);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.dpAte);
            this.Controls.Add(this.dpDe);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboSituacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.listViewRelatorio);
            this.Name = "Form_RelatorioPeriodo";
            this.Text = "Form_RelatorioPeriodo";
            this.Load += new System.EventHandler(this.Form_RelatorioPeriodo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewRelatorio;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSituacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DateTimePicker dpDe;
        private System.Windows.Forms.DateTimePicker dpAte;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader NumOS;
        private System.Windows.Forms.ColumnHeader Servico;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader DataAbertura;
        private System.Windows.Forms.ColumnHeader DataExecucao;
        private System.Windows.Forms.Button btSair;
    }
}