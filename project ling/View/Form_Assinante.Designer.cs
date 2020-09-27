namespace project_ling.View
{
    partial class Form_Assinante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Assinante));
            this.categoria = new System.Windows.Forms.ComboBox();
            this.boxBusca = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btContratos = new System.Windows.Forms.Button();
            this.btOrdens = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.boxNascimento = new System.Windows.Forms.TextBox();
            this.boxCPF = new System.Windows.Forms.TextBox();
            this.boxProfissao = new System.Windows.Forms.TextBox();
            this.boxEstadoCivil = new System.Windows.Forms.TextBox();
            this.boxSexo = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tipoRua = new System.Windows.Forms.TextBox();
            this.nomeEndereco = new System.Windows.Forms.TextBox();
            this.numeroEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bairroEndereco = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.boxComplemento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // categoria
            // 
            this.categoria.FormattingEnabled = true;
            this.categoria.Items.AddRange(new object[] {
            "Nome",
            "CPF/CNPJ",
            "Endereço",
            "Fantasia",
            "Telefone"});
            this.categoria.Location = new System.Drawing.Point(174, 12);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(121, 21);
            this.categoria.TabIndex = 0;
            // 
            // boxBusca
            // 
            this.boxBusca.Location = new System.Drawing.Point(301, 13);
            this.boxBusca.Name = "boxBusca";
            this.boxBusca.Size = new System.Drawing.Size(444, 20);
            this.boxBusca.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(752, 13);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(77, 19);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(174, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(711, 208);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox3.Location = new System.Drawing.Point(751, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 161);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btContratos
            // 
            this.btContratos.Location = new System.Drawing.Point(93, 38);
            this.btContratos.Name = "btContratos";
            this.btContratos.Size = new System.Drawing.Size(75, 92);
            this.btContratos.TabIndex = 6;
            this.btContratos.Text = "Contratos";
            this.btContratos.UseVisualStyleBackColor = true;
            // 
            // btOrdens
            // 
            this.btOrdens.Location = new System.Drawing.Point(93, 132);
            this.btOrdens.Name = "btOrdens";
            this.btOrdens.Size = new System.Drawing.Size(75, 92);
            this.btOrdens.TabIndex = 7;
            this.btOrdens.Text = "Ordens de Serviço";
            this.btOrdens.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(758, 206);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(799, 206);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(840, 206);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 18);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // boxNascimento
            // 
            this.boxNascimento.Location = new System.Drawing.Point(279, 241);
            this.boxNascimento.Name = "boxNascimento";
            this.boxNascimento.Size = new System.Drawing.Size(100, 20);
            this.boxNascimento.TabIndex = 11;
            this.boxNascimento.TextChanged += new System.EventHandler(this.boxNascimento_TextChanged);
            // 
            // boxCPF
            // 
            this.boxCPF.Location = new System.Drawing.Point(447, 241);
            this.boxCPF.Name = "boxCPF";
            this.boxCPF.Size = new System.Drawing.Size(124, 20);
            this.boxCPF.TabIndex = 12;
            // 
            // boxProfissao
            // 
            this.boxProfissao.Location = new System.Drawing.Point(645, 241);
            this.boxProfissao.Name = "boxProfissao";
            this.boxProfissao.Size = new System.Drawing.Size(230, 20);
            this.boxProfissao.TabIndex = 13;
            // 
            // boxEstadoCivil
            // 
            this.boxEstadoCivil.Location = new System.Drawing.Point(279, 269);
            this.boxEstadoCivil.Name = "boxEstadoCivil";
            this.boxEstadoCivil.Size = new System.Drawing.Size(100, 20);
            this.boxEstadoCivil.TabIndex = 14;
            // 
            // boxSexo
            // 
            this.boxSexo.Location = new System.Drawing.Point(422, 267);
            this.boxSexo.Name = "boxSexo";
            this.boxSexo.Size = new System.Drawing.Size(100, 20);
            this.boxSexo.TabIndex = 15;
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(580, 269);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(295, 20);
            this.boxEmail.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(210, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(385, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "CPF/CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(589, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Profissao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(211, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Estado Civil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(385, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(539, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(187, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Endereço Residencial";
            // 
            // tipoRua
            // 
            this.tipoRua.Location = new System.Drawing.Point(242, 340);
            this.tipoRua.Name = "tipoRua";
            this.tipoRua.Size = new System.Drawing.Size(91, 20);
            this.tipoRua.TabIndex = 24;
            // 
            // nomeEndereco
            // 
            this.nomeEndereco.Location = new System.Drawing.Point(339, 340);
            this.nomeEndereco.Name = "nomeEndereco";
            this.nomeEndereco.Size = new System.Drawing.Size(406, 20);
            this.nomeEndereco.TabIndex = 25;
            // 
            // numeroEndereco
            // 
            this.numeroEndereco.Location = new System.Drawing.Point(801, 343);
            this.numeroEndereco.Name = "numeroEndereco";
            this.numeroEndereco.Size = new System.Drawing.Size(76, 20);
            this.numeroEndereco.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(188, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Endereço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(751, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Número";
            // 
            // bairroEndereco
            // 
            this.bairroEndereco.Location = new System.Drawing.Point(247, 368);
            this.bairroEndereco.Name = "bairroEndereco";
            this.bairroEndereco.Size = new System.Drawing.Size(174, 20);
            this.bairroEndereco.TabIndex = 29;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.BackColor = System.Drawing.Color.DimGray;
            this.labelBairro.ForeColor = System.Drawing.Color.White;
            this.labelBairro.Location = new System.Drawing.Point(207, 368);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(34, 13);
            this.labelBairro.TabIndex = 30;
            this.labelBairro.Text = "Bairro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(427, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Complemento";
            // 
            // boxComplemento
            // 
            this.boxComplemento.Location = new System.Drawing.Point(499, 371);
            this.boxComplemento.Name = "boxComplemento";
            this.boxComplemento.Size = new System.Drawing.Size(376, 20);
            this.boxComplemento.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 19);
            this.button1.TabIndex = 33;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(174, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(571, 186);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form_Assinante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(939, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxComplemento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.bairroEndereco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numeroEndereco);
            this.Controls.Add(this.nomeEndereco);
            this.Controls.Add(this.tipoRua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.boxSexo);
            this.Controls.Add(this.boxEstadoCivil);
            this.Controls.Add(this.boxProfissao);
            this.Controls.Add(this.boxCPF);
            this.Controls.Add(this.boxNascimento);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btOrdens);
            this.Controls.Add(this.btContratos);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.boxBusca);
            this.Controls.Add(this.categoria);
            this.Name = "Form_Assinante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Assinante";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoria;
        private System.Windows.Forms.TextBox boxBusca;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btContratos;
        private System.Windows.Forms.Button btOrdens;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox boxNascimento;
        private System.Windows.Forms.TextBox boxCPF;
        private System.Windows.Forms.TextBox boxProfissao;
        private System.Windows.Forms.TextBox boxEstadoCivil;
        private System.Windows.Forms.TextBox boxSexo;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tipoRua;
        private System.Windows.Forms.TextBox nomeEndereco;
        private System.Windows.Forms.TextBox numeroEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bairroEndereco;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxComplemento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}