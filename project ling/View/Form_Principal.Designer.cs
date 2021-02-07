namespace project_ling.View
{
    partial class Form_Principal
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.assinantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarNovoAssinanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarAssinantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordensEmPendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordensPorPeríodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosOsUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCalendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordensSemAgendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1189, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assinantesToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.administrativoToolStripMenuItem,
            this.agendamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // assinantesToolStripMenuItem
            // 
            this.assinantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarNovoAssinanteToolStripMenuItem,
            this.gerenciarAssinantesToolStripMenuItem});
            this.assinantesToolStripMenuItem.Name = "assinantesToolStripMenuItem";
            this.assinantesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.assinantesToolStripMenuItem.Text = "Assinantes";
            // 
            // adicionarNovoAssinanteToolStripMenuItem
            // 
            this.adicionarNovoAssinanteToolStripMenuItem.Name = "adicionarNovoAssinanteToolStripMenuItem";
            this.adicionarNovoAssinanteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.adicionarNovoAssinanteToolStripMenuItem.Text = "Adicionar Novo Assinante";
            this.adicionarNovoAssinanteToolStripMenuItem.Click += new System.EventHandler(this.adicionarNovoAssinanteToolStripMenuItem_Click);
            // 
            // gerenciarAssinantesToolStripMenuItem
            // 
            this.gerenciarAssinantesToolStripMenuItem.Name = "gerenciarAssinantesToolStripMenuItem";
            this.gerenciarAssinantesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.gerenciarAssinantesToolStripMenuItem.Text = "Gerenciar Assinantes";
            this.gerenciarAssinantesToolStripMenuItem.Click += new System.EventHandler(this.gerenciarAssinantesToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordensEmPendenteToolStripMenuItem,
            this.ordensPorPeríodoToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            this.relatoriosToolStripMenuItem.Click += new System.EventHandler(this.relatoriosToolStripMenuItem_Click);
            // 
            // ordensEmPendenteToolStripMenuItem
            // 
            this.ordensEmPendenteToolStripMenuItem.Name = "ordensEmPendenteToolStripMenuItem";
            this.ordensEmPendenteToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ordensEmPendenteToolStripMenuItem.Text = "Ordens em pendente";
            this.ordensEmPendenteToolStripMenuItem.Click += new System.EventHandler(this.ordensEmPendenteToolStripMenuItem_Click);
            // 
            // ordensPorPeríodoToolStripMenuItem
            // 
            this.ordensPorPeríodoToolStripMenuItem.Name = "ordensPorPeríodoToolStripMenuItem";
            this.ordensPorPeríodoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ordensPorPeríodoToolStripMenuItem.Text = "Ordens por período";
            this.ordensPorPeríodoToolStripMenuItem.Click += new System.EventHandler(this.ordensPorPeríodoToolStripMenuItem_Click);
            // 
            // administrativoToolStripMenuItem
            // 
            this.administrativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem});
            this.administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            this.administrativoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.administrativoToolStripMenuItem.Text = "Administrativo";
            this.administrativoToolStripMenuItem.Click += new System.EventHandler(this.administrativoToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendentesToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.todosOsUsuáriosToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // pendentesToolStripMenuItem
            // 
            this.pendentesToolStripMenuItem.Name = "pendentesToolStripMenuItem";
            this.pendentesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.pendentesToolStripMenuItem.Text = "Pendentes";
            this.pendentesToolStripMenuItem.Click += new System.EventHandler(this.pendentesToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // todosOsUsuáriosToolStripMenuItem
            // 
            this.todosOsUsuáriosToolStripMenuItem.Name = "todosOsUsuáriosToolStripMenuItem";
            this.todosOsUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.todosOsUsuáriosToolStripMenuItem.Text = "Todos os Usuários";
            this.todosOsUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.todosOsUsuáriosToolStripMenuItem_Click);
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCalendarioToolStripMenuItem,
            this.ordensSemAgendamentoToolStripMenuItem});
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.agendamentoToolStripMenuItem.Text = "Agendamento";
            // 
            // consultarCalendarioToolStripMenuItem
            // 
            this.consultarCalendarioToolStripMenuItem.Name = "consultarCalendarioToolStripMenuItem";
            this.consultarCalendarioToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.consultarCalendarioToolStripMenuItem.Text = "Consultar Calendario";
            this.consultarCalendarioToolStripMenuItem.Click += new System.EventHandler(this.consultarCalendarioToolStripMenuItem_Click);
            // 
            // ordensSemAgendamentoToolStripMenuItem
            // 
            this.ordensSemAgendamentoToolStripMenuItem.Name = "ordensSemAgendamentoToolStripMenuItem";
            this.ordensSemAgendamentoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.ordensSemAgendamentoToolStripMenuItem.Text = "Ordens sem Agendamento";
            this.ordensSemAgendamentoToolStripMenuItem.Click += new System.EventHandler(this.ordensSemAgendamentoToolStripMenuItem_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Principal";
            this.Load += new System.EventHandler(this.Form_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem assinantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarNovoAssinanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarAssinantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordensEmPendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordensPorPeríodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosOsUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCalendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordensSemAgendamentoToolStripMenuItem;
    }
}