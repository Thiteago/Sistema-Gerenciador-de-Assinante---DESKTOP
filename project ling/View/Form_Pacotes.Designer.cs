namespace project_ling.View
{
    partial class Form_Pacotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pacotes));
            this.lbPacotes = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btSair = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.Pacote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAdicionarPAC = new System.Windows.Forms.PictureBox();
            this.btRemoverPacote = new System.Windows.Forms.PictureBox();
            this.btAlterarPacote = new System.Windows.Forms.PictureBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.boxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btAdicionarPAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btRemoverPacote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAlterarPacote)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPacotes
            // 
            this.lbPacotes.AutoSize = true;
            this.lbPacotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPacotes.ForeColor = System.Drawing.Color.White;
            this.lbPacotes.Location = new System.Drawing.Point(315, 24);
            this.lbPacotes.Name = "lbPacotes";
            this.lbPacotes.Size = new System.Drawing.Size(189, 39);
            this.lbPacotes.TabIndex = 0;
            this.lbPacotes.Text = "PACOTES";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(455, 140);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(325, 94);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.Visible = false;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(713, 12);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Pacote});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(425, 330);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pacotes Ativos";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(455, 326);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(325, 94);
            this.checkedListBox2.TabIndex = 8;
            this.checkedListBox2.Visible = false;
            // 
            // Pacote
            // 
            this.Pacote.Text = "Pacote";
            this.Pacote.Width = 420;
            // 
            // btAdicionarPAC
            // 
            this.btAdicionarPAC.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionarPAC.Image")));
            this.btAdicionarPAC.Location = new System.Drawing.Point(443, 108);
            this.btAdicionarPAC.Name = "btAdicionarPAC";
            this.btAdicionarPAC.Size = new System.Drawing.Size(28, 26);
            this.btAdicionarPAC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btAdicionarPAC.TabIndex = 28;
            this.btAdicionarPAC.TabStop = false;
            this.btAdicionarPAC.Click += new System.EventHandler(this.btAdicionarPAC_Click_1);
            // 
            // btRemoverPacote
            // 
            this.btRemoverPacote.Image = ((System.Drawing.Image)(resources.GetObject("btRemoverPacote.Image")));
            this.btRemoverPacote.Location = new System.Drawing.Point(477, 108);
            this.btRemoverPacote.Name = "btRemoverPacote";
            this.btRemoverPacote.Size = new System.Drawing.Size(28, 26);
            this.btRemoverPacote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btRemoverPacote.TabIndex = 30;
            this.btRemoverPacote.TabStop = false;
            // 
            // btAlterarPacote
            // 
            this.btAlterarPacote.Image = ((System.Drawing.Image)(resources.GetObject("btAlterarPacote.Image")));
            this.btAlterarPacote.Location = new System.Drawing.Point(511, 108);
            this.btAlterarPacote.Name = "btAlterarPacote";
            this.btAlterarPacote.Size = new System.Drawing.Size(28, 26);
            this.btAlterarPacote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btAlterarPacote.TabIndex = 31;
            this.btAlterarPacote.TabStop = false;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(455, 240);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(325, 23);
            this.btAdicionar.TabIndex = 32;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Visible = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // boxID
            // 
            this.boxID.Location = new System.Drawing.Point(12, 12);
            this.boxID.Name = "boxID";
            this.boxID.ReadOnly = true;
            this.boxID.Size = new System.Drawing.Size(100, 20);
            this.boxID.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID";
            // 
            // Form_Pacotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxID);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btAlterarPacote);
            this.Controls.Add(this.btRemoverPacote);
            this.Controls.Add(this.btAdicionarPAC);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbPacotes);
            this.Name = "Form_Pacotes";
            this.Text = "Form_Pacotes";
            this.Load += new System.EventHandler(this.Form_Pacotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btAdicionarPAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btRemoverPacote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAlterarPacote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPacotes;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.ColumnHeader Pacote;
        private System.Windows.Forms.PictureBox btAdicionarPAC;
        private System.Windows.Forms.PictureBox btRemoverPacote;
        private System.Windows.Forms.PictureBox btAlterarPacote;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.Label label2;
    }
}