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
            this.btContratos = new System.Windows.Forms.Button();
            this.btOrdens = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.deleteBotao = new System.Windows.Forms.PictureBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.boxCidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.boxEstado = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBotao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // categoria
            // 
            this.categoria.FormattingEnabled = true;
            this.categoria.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "Endereço",
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
            this.boxBusca.Size = new System.Drawing.Size(686, 20);
            this.boxBusca.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(1004, 13);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(56, 20);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(174, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 201);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btContratos
            // 
            this.btContratos.Location = new System.Drawing.Point(192, 227);
            this.btContratos.Name = "btContratos";
            this.btContratos.Size = new System.Drawing.Size(64, 26);
            this.btContratos.TabIndex = 6;
            this.btContratos.Text = "Contratos";
            this.btContratos.UseVisualStyleBackColor = true;
            // 
            // btOrdens
            // 
            this.btOrdens.Location = new System.Drawing.Point(262, 227);
            this.btOrdens.Name = "btOrdens";
            this.btOrdens.Size = new System.Drawing.Size(64, 26);
            this.btOrdens.TabIndex = 7;
            this.btOrdens.Text = "O.S";
            this.btOrdens.UseVisualStyleBackColor = true;
            this.btOrdens.Click += new System.EventHandler(this.btOrdens_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(885, 227);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(923, 227);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // deleteBotao
            // 
            this.deleteBotao.Image = ((System.Drawing.Image)(resources.GetObject("deleteBotao.Image")));
            this.deleteBotao.Location = new System.Drawing.Point(960, 227);
            this.deleteBotao.Name = "deleteBotao";
            this.deleteBotao.Size = new System.Drawing.Size(28, 26);
            this.deleteBotao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteBotao.TabIndex = 10;
            this.deleteBotao.TabStop = false;
            this.deleteBotao.Click += new System.EventHandler(this.deleteBotao_Click);
            // 
            // boxNascimento
            // 
            this.boxNascimento.Location = new System.Drawing.Point(268, 319);
            this.boxNascimento.Name = "boxNascimento";
            this.boxNascimento.Size = new System.Drawing.Size(99, 20);
            this.boxNascimento.TabIndex = 11;
            this.boxNascimento.TextChanged += new System.EventHandler(this.boxNascimento_TextChanged);
            // 
            // boxCPF
            // 
            this.boxCPF.Location = new System.Drawing.Point(267, 291);
            this.boxCPF.Name = "boxCPF";
            this.boxCPF.Size = new System.Drawing.Size(124, 20);
            this.boxCPF.TabIndex = 12;
            // 
            // boxProfissao
            // 
            this.boxProfissao.Location = new System.Drawing.Point(458, 291);
            this.boxProfissao.Name = "boxProfissao";
            this.boxProfissao.Size = new System.Drawing.Size(230, 20);
            this.boxProfissao.TabIndex = 13;
            // 
            // boxEstadoCivil
            // 
            this.boxEstadoCivil.Location = new System.Drawing.Point(267, 344);
            this.boxEstadoCivil.Name = "boxEstadoCivil";
            this.boxEstadoCivil.Size = new System.Drawing.Size(100, 20);
            this.boxEstadoCivil.TabIndex = 14;
            // 
            // boxSexo
            // 
            this.boxSexo.Location = new System.Drawing.Point(267, 370);
            this.boxSexo.Name = "boxSexo";
            this.boxSexo.Size = new System.Drawing.Size(100, 20);
            this.boxSexo.TabIndex = 15;
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(440, 319);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(511, 20);
            this.boxEmail.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 319);
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
            this.label2.Location = new System.Drawing.Point(202, 291);
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
            this.label3.Location = new System.Drawing.Point(402, 294);
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
            this.label4.Location = new System.Drawing.Point(194, 347);
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
            this.label5.Location = new System.Drawing.Point(230, 373);
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
            this.label6.Location = new System.Drawing.Point(402, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Email";
            // 
            // tipoRua
            // 
            this.tipoRua.Location = new System.Drawing.Point(440, 344);
            this.tipoRua.Name = "tipoRua";
            this.tipoRua.Size = new System.Drawing.Size(99, 20);
            this.tipoRua.TabIndex = 24;
            // 
            // nomeEndereco
            // 
            this.nomeEndereco.Location = new System.Drawing.Point(545, 344);
            this.nomeEndereco.Name = "nomeEndereco";
            this.nomeEndereco.Size = new System.Drawing.Size(406, 20);
            this.nomeEndereco.TabIndex = 25;
            // 
            // numeroEndereco
            // 
            this.numeroEndereco.Location = new System.Drawing.Point(440, 396);
            this.numeroEndereco.Name = "numeroEndereco";
            this.numeroEndereco.Size = new System.Drawing.Size(76, 20);
            this.numeroEndereco.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(381, 347);
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
            this.label9.Location = new System.Drawing.Point(390, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Número";
            // 
            // bairroEndereco
            // 
            this.bairroEndereco.Location = new System.Drawing.Point(440, 370);
            this.bairroEndereco.Name = "bairroEndereco";
            this.bairroEndereco.Size = new System.Drawing.Size(174, 20);
            this.bairroEndereco.TabIndex = 29;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.BackColor = System.Drawing.Color.DimGray;
            this.labelBairro.ForeColor = System.Drawing.Color.White;
            this.labelBairro.Location = new System.Drawing.Point(400, 373);
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
            this.label10.Location = new System.Drawing.Point(522, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Complemento";
            // 
            // boxComplemento
            // 
            this.boxComplemento.Location = new System.Drawing.Point(599, 396);
            this.boxComplemento.Name = "boxComplemento";
            this.boxComplemento.Size = new System.Drawing.Size(352, 20);
            this.boxComplemento.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1133, 12);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(174, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(813, 183);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(704, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Cidade";
            // 
            // boxCidade
            // 
            this.boxCidade.Location = new System.Drawing.Point(750, 291);
            this.boxCidade.Name = "boxCidade";
            this.boxCidade.Size = new System.Drawing.Size(201, 20);
            this.boxCidade.TabIndex = 36;
            this.boxCidade.TextChanged += new System.EventHandler(this.boxCidade_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(620, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Estado";
            // 
            // boxEstado
            // 
            this.boxEstado.Location = new System.Drawing.Point(666, 370);
            this.boxEstado.Name = "boxEstado";
            this.boxEstado.Size = new System.Drawing.Size(285, 20);
            this.boxEstado.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 26);
            this.button2.TabIndex = 39;
            this.button2.Text = "Pacotes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Assinante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1187, 508);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.boxEstado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.boxCidade);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.deleteBotao);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btOrdens);
            this.Controls.Add(this.btContratos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.boxBusca);
            this.Controls.Add(this.categoria);
            this.Name = "Form_Assinante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Assinante";
            this.Load += new System.EventHandler(this.Form_Assinante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBotao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoria;
        private System.Windows.Forms.TextBox boxBusca;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btContratos;
        private System.Windows.Forms.Button btOrdens;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox deleteBotao;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxCidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox boxEstado;
        private System.Windows.Forms.Button button2;
    }
}