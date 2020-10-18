namespace project_ling.View
{
    partial class Form_AltOS
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
            this.boxValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxData = new System.Windows.Forms.TextBox();
            this.btGravar = new System.Windows.Forms.Button();
            this.boxObservacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboServico = new System.Windows.Forms.ComboBox();
            this.boxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxCod_Cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boxNumOS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSair.Location = new System.Drawing.Point(750, 12);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 0;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // boxValor
            // 
            this.boxValor.Location = new System.Drawing.Point(129, 374);
            this.boxValor.Name = "boxValor";
            this.boxValor.Size = new System.Drawing.Size(100, 20);
            this.boxValor.TabIndex = 24;
            this.boxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Valor";
            // 
            // boxData
            // 
            this.boxData.Location = new System.Drawing.Point(691, 404);
            this.boxData.Name = "boxData";
            this.boxData.Size = new System.Drawing.Size(100, 20);
            this.boxData.TabIndex = 22;
            this.boxData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btGravar
            // 
            this.btGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btGravar.Location = new System.Drawing.Point(385, 402);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 21;
            this.btGravar.Text = "Alterar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // boxObservacao
            // 
            this.boxObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxObservacao.Location = new System.Drawing.Point(66, 179);
            this.boxObservacao.Multiline = true;
            this.boxObservacao.Name = "boxObservacao";
            this.boxObservacao.Size = new System.Drawing.Size(725, 189);
            this.boxObservacao.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Observação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Serviço";
            // 
            // comboServico
            // 
            this.comboServico.FormattingEnabled = true;
            this.comboServico.Items.AddRange(new object[] {
            "ADEQUAÇÃO DE REDE FIBRA",
            "INSPEÇÃO E VISTORIA",
            "INSTALAÇÃO DE ROTEADOR",
            "IP FIXO",
            "MANUTENÇÃO INTERNET WIRELESS",
            "MANUTENÇÃO INTERNET FIBRA",
            "MANUTENÇÃO ROTEADOR",
            "MIGRAÇÃO WIRELESS P/ FIBRA",
            "MIGRAÇÃO FIBRA P/ WIRELESS",
            "REFAZER INSTALAÇÃO",
            "RETIRADA DE EQUIPAMENTO",
            "TRANSFERENCIA DE ENDEREÇO"});
            this.comboServico.Location = new System.Drawing.Point(66, 112);
            this.comboServico.Name = "comboServico";
            this.comboServico.Size = new System.Drawing.Size(725, 21);
            this.comboServico.TabIndex = 17;
            // 
            // boxNome
            // 
            this.boxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxNome.Location = new System.Drawing.Point(223, 50);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(568, 31);
            this.boxNome.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome";
            // 
            // boxCod_Cliente
            // 
            this.boxCod_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCod_Cliente.Location = new System.Drawing.Point(66, 50);
            this.boxCod_Cliente.Name = "boxCod_Cliente";
            this.boxCod_Cliente.Size = new System.Drawing.Size(151, 31);
            this.boxCod_Cliente.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cod Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-6, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Numero O.S";
            // 
            // boxNumOS
            // 
            this.boxNumOS.Location = new System.Drawing.Point(129, 407);
            this.boxNumOS.Name = "boxNumOS";
            this.boxNumOS.Size = new System.Drawing.Size(100, 20);
            this.boxNumOS.TabIndex = 26;
            this.boxNumOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_AltOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(852, 447);
            this.Controls.Add(this.boxNumOS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxData);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.boxObservacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboServico);
            this.Controls.Add(this.boxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxCod_Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSair);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form_AltOS";
            this.Text = "Form_AltOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.TextBox boxValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxData;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.TextBox boxObservacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboServico;
        private System.Windows.Forms.TextBox boxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxCod_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxNumOS;
    }
}