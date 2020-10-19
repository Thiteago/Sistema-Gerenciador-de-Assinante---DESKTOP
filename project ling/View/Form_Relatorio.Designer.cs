namespace project_ling.View
{
    partial class Form_Relatorio
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
            this.btSair = new System.Windows.Forms.Button();
            this.listViewPendentes = new System.Windows.Forms.ListView();
            this.IDCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumeroOS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(773, 12);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 0;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // listViewPendentes
            // 
            this.listViewPendentes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDCliente,
            this.Nome,
            this.NumeroOS,
            this.Status});
            this.listViewPendentes.GridLines = true;
            this.listViewPendentes.HideSelection = false;
            this.listViewPendentes.Location = new System.Drawing.Point(12, 12);
            this.listViewPendentes.MultiSelect = false;
            this.listViewPendentes.Name = "listViewPendentes";
            this.listViewPendentes.Size = new System.Drawing.Size(755, 514);
            this.listViewPendentes.TabIndex = 1;
            this.listViewPendentes.UseCompatibleStateImageBehavior = false;
            this.listViewPendentes.View = System.Windows.Forms.View.Details;
            // 
            // IDCliente
            // 
            this.IDCliente.Text = "IDCliente";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 450;
            // 
            // NumeroOS
            // 
            this.NumeroOS.Text = "NúmeroOS";
            this.NumeroOS.Width = 150;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 100;
            // 
            // Form_Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(860, 538);
            this.Controls.Add(this.listViewPendentes);
            this.Controls.Add(this.btSair);
            this.Name = "Form_Relatorio";
            this.Text = "Form_Relatorio";
            this.Load += new System.EventHandler(this.Form_Relatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ListView listViewPendentes;
        private System.Windows.Forms.ColumnHeader IDCliente;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader NumeroOS;
        private System.Windows.Forms.ColumnHeader Status;
    }
}