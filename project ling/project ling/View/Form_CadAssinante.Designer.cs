namespace project_ling.View
{
    partial class Form_CadAssinante
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
            this.nomeCompleto = new System.Windows.Forms.TextBox();
            this.rua = new System.Windows.Forms.TextBox();
            this.bairro = new System.Windows.Forms.TextBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtanasc = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // nomeCompleto
            // 
            this.nomeCompleto.Location = new System.Drawing.Point(238, 100);
            this.nomeCompleto.Name = "nomeCompleto";
            this.nomeCompleto.Size = new System.Drawing.Size(248, 20);
            this.nomeCompleto.TabIndex = 0;
            // 
            // rua
            // 
            this.rua.Location = new System.Drawing.Point(238, 126);
            this.rua.Name = "rua";
            this.rua.Size = new System.Drawing.Size(383, 20);
            this.rua.TabIndex = 2;
            // 
            // bairro
            // 
            this.bairro.Location = new System.Drawing.Point(238, 152);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(100, 20);
            this.bairro.TabIndex = 3;
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(410, 151);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(211, 20);
            this.cidade.TabIndex = 4;
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(238, 178);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(223, 20);
            this.estado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(492, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "CPF";
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(539, 100);
            this.cpf.Mask = "###.###.###-##";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(82, 20);
            this.cpf.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(181, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(344, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(195, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(174, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(467, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefone";
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(543, 178);
            this.telefone.Mask = "(##)#########";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(78, 20);
            this.telefone.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(703, 73);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cadastro de Assinante";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(436, 290);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 17;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(262, 290);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 18;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(181, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(238, 204);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(383, 20);
            this.email.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(79, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Data de Nascimento";
            // 
            // dtanasc
            // 
            this.dtanasc.Location = new System.Drawing.Point(238, 230);
            this.dtanasc.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtanasc.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtanasc.Name = "dtanasc";
            this.dtanasc.Size = new System.Drawing.Size(383, 20);
            this.dtanasc.TabIndex = 22;
            // 
            // Form_CadAssinante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(749, 325);
            this.Controls.Add(this.dtanasc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.bairro);
            this.Controls.Add(this.rua);
            this.Controls.Add(this.nomeCompleto);
            this.Name = "Form_CadAssinante";
            this.Text = "Form_CadAssinante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeCompleto;
        private System.Windows.Forms.TextBox rua;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtanasc;
    }
}