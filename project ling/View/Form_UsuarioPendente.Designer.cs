
namespace project_ling.View
{
    partial class Form_UsuarioPendente
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
            this.DGVUsuarios = new System.Windows.Forms.DataGridView();
            this.btAprovar = new System.Windows.Forms.Button();
            this.btRecusar = new System.Windows.Forms.Button();
            this.comboNivel = new System.Windows.Forms.ComboBox();
            this.lbNivel = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVUsuarios
            // 
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarios.Location = new System.Drawing.Point(12, 12);
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.Size = new System.Drawing.Size(728, 513);
            this.DGVUsuarios.TabIndex = 0;
            this.DGVUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsuarios_CellClick);
            // 
            // btAprovar
            // 
            this.btAprovar.Location = new System.Drawing.Point(757, 262);
            this.btAprovar.Name = "btAprovar";
            this.btAprovar.Size = new System.Drawing.Size(256, 23);
            this.btAprovar.TabIndex = 1;
            this.btAprovar.Text = "Aceitar";
            this.btAprovar.UseVisualStyleBackColor = true;
            this.btAprovar.Click += new System.EventHandler(this.btAprovar_Click);
            // 
            // btRecusar
            // 
            this.btRecusar.Location = new System.Drawing.Point(757, 291);
            this.btRecusar.Name = "btRecusar";
            this.btRecusar.Size = new System.Drawing.Size(256, 23);
            this.btRecusar.TabIndex = 2;
            this.btRecusar.Text = "Recusar";
            this.btRecusar.UseVisualStyleBackColor = true;
            this.btRecusar.Click += new System.EventHandler(this.btRecusar_Click);
            // 
            // comboNivel
            // 
            this.comboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNivel.FormattingEnabled = true;
            this.comboNivel.Items.AddRange(new object[] {
            "Administrador",
            "Suporte",
            "Atendimento"});
            this.comboNivel.Location = new System.Drawing.Point(757, 213);
            this.comboNivel.Name = "comboNivel";
            this.comboNivel.Size = new System.Drawing.Size(256, 21);
            this.comboNivel.TabIndex = 3;
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.ForeColor = System.Drawing.Color.White;
            this.lbNivel.Location = new System.Drawing.Point(757, 197);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(84, 13);
            this.lbNivel.TabIndex = 4;
            this.lbNivel.Text = "Nivel de Acesso";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(938, 12);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(760, 125);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(35, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(801, 125);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 20);
            this.txtNome.TabIndex = 7;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(757, 109);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 8;
            this.lbID.Text = "ID";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(798, 109);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome";
            // 
            // Form_UsuarioPendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1025, 537);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.lbNivel);
            this.Controls.Add(this.comboNivel);
            this.Controls.Add(this.btRecusar);
            this.Controls.Add(this.btAprovar);
            this.Controls.Add(this.DGVUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_UsuarioPendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_UsuarioPendente";
            this.Load += new System.EventHandler(this.Form_UsuarioPendente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVUsuarios;
        private System.Windows.Forms.Button btAprovar;
        private System.Windows.Forms.Button btRecusar;
        private System.Windows.Forms.ComboBox comboNivel;
        private System.Windows.Forms.Label lbNivel;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lblNome;
    }
}