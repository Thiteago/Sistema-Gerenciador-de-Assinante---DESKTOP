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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.assinantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarNovoAssinanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarAssinantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordensEmPendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordensPorPeríodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(769, 1);
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
            this.usuariosToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
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
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // listaDeUsuariosToolStripMenuItem
            // 
            this.listaDeUsuariosToolStripMenuItem.Name = "listaDeUsuariosToolStripMenuItem";
            this.listaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listaDeUsuariosToolStripMenuItem.Text = "Lista de Usuarios";
            this.listaDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listaDeUsuariosToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordensEmPendenteToolStripMenuItem,
            this.ordensPorPeríodoToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
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
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(856, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarAssinantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordensEmPendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordensPorPeríodoToolStripMenuItem;
    }
}