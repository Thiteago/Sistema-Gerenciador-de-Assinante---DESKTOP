namespace project_ling.View
{
    partial class Form_OS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OS));
            this.btSair = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.boxCod_Cliente = new System.Windows.Forms.TextBox();
            this.lbCodCliente = new System.Windows.Forms.Label();
            this.lbCod_Contrato = new System.Windows.Forms.Label();
            this.boxCod_Contrato = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.boxNome = new System.Windows.Forms.TextBox();
            this.boxTipoRua = new System.Windows.Forms.TextBox();
            this.boxRua = new System.Windows.Forms.TextBox();
            this.boxNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.boxComplemento = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbServiço = new System.Windows.Forms.Label();
            this.boxServico = new System.Windows.Forms.TextBox();
            this.lbEquipe = new System.Windows.Forms.Label();
            this.boxEquipe = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.boxValor = new System.Windows.Forms.TextBox();
            this.lbRecorrencia = new System.Windows.Forms.Label();
            this.boxRecorrencia = new System.Windows.Forms.TextBox();
            this.lbObservacao = new System.Windows.Forms.Label();
            this.boxObservacoes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxUsuario = new System.Windows.Forms.TextBox();
            this.btAdicionarOS = new System.Windows.Forms.PictureBox();
            this.btAlterarOS = new System.Windows.Forms.PictureBox();
            this.btDeletarOS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAdicionarOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAlterarOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDeletarOS)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(879, 12);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 0;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(162, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(660, 259);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // boxCod_Cliente
            // 
            this.boxCod_Cliente.Location = new System.Drawing.Point(162, 277);
            this.boxCod_Cliente.Name = "boxCod_Cliente";
            this.boxCod_Cliente.Size = new System.Drawing.Size(100, 20);
            this.boxCod_Cliente.TabIndex = 2;
            // 
            // lbCodCliente
            // 
            this.lbCodCliente.AutoSize = true;
            this.lbCodCliente.ForeColor = System.Drawing.Color.White;
            this.lbCodCliente.Location = new System.Drawing.Point(95, 280);
            this.lbCodCliente.Name = "lbCodCliente";
            this.lbCodCliente.Size = new System.Drawing.Size(61, 13);
            this.lbCodCliente.TabIndex = 3;
            this.lbCodCliente.Text = "Cod.Cliente";
            // 
            // lbCod_Contrato
            // 
            this.lbCod_Contrato.AutoSize = true;
            this.lbCod_Contrato.ForeColor = System.Drawing.Color.White;
            this.lbCod_Contrato.Location = new System.Drawing.Point(87, 305);
            this.lbCod_Contrato.Name = "lbCod_Contrato";
            this.lbCod_Contrato.Size = new System.Drawing.Size(69, 13);
            this.lbCod_Contrato.TabIndex = 4;
            this.lbCod_Contrato.Text = "Cod.Contrato";
            // 
            // boxCod_Contrato
            // 
            this.boxCod_Contrato.Location = new System.Drawing.Point(162, 303);
            this.boxCod_Contrato.Name = "boxCod_Contrato";
            this.boxCod_Contrato.Size = new System.Drawing.Size(100, 20);
            this.boxCod_Contrato.TabIndex = 5;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(268, 280);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome";
            // 
            // boxNome
            // 
            this.boxNome.Location = new System.Drawing.Point(309, 277);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(513, 20);
            this.boxNome.TabIndex = 7;
            // 
            // boxTipoRua
            // 
            this.boxTipoRua.Location = new System.Drawing.Point(268, 303);
            this.boxTipoRua.Name = "boxTipoRua";
            this.boxTipoRua.Size = new System.Drawing.Size(63, 20);
            this.boxTipoRua.TabIndex = 8;
            // 
            // boxRua
            // 
            this.boxRua.Location = new System.Drawing.Point(337, 303);
            this.boxRua.Name = "boxRua";
            this.boxRua.Size = new System.Drawing.Size(485, 20);
            this.boxRua.TabIndex = 9;
            // 
            // boxNumero
            // 
            this.boxNumero.Location = new System.Drawing.Point(162, 329);
            this.boxNumero.Name = "boxNumero";
            this.boxNumero.Size = new System.Drawing.Size(100, 20);
            this.boxNumero.TabIndex = 10;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.ForeColor = System.Drawing.Color.White;
            this.lbNumero.Location = new System.Drawing.Point(112, 329);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(44, 13);
            this.lbNumero.TabIndex = 11;
            this.lbNumero.Text = "Número";
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.ForeColor = System.Drawing.Color.White;
            this.lbComplemento.Location = new System.Drawing.Point(268, 332);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(71, 13);
            this.lbComplemento.TabIndex = 12;
            this.lbComplemento.Text = "Complemento";
            // 
            // boxComplemento
            // 
            this.boxComplemento.Location = new System.Drawing.Point(345, 329);
            this.boxComplemento.Name = "boxComplemento";
            this.boxComplemento.Size = new System.Drawing.Size(477, 20);
            this.boxComplemento.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(162, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 10);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lbServiço
            // 
            this.lbServiço.AutoSize = true;
            this.lbServiço.ForeColor = System.Drawing.Color.White;
            this.lbServiço.Location = new System.Drawing.Point(112, 372);
            this.lbServiço.Name = "lbServiço";
            this.lbServiço.Size = new System.Drawing.Size(43, 13);
            this.lbServiço.TabIndex = 15;
            this.lbServiço.Text = "Serviço";
            // 
            // boxServico
            // 
            this.boxServico.Location = new System.Drawing.Point(162, 369);
            this.boxServico.Name = "boxServico";
            this.boxServico.Size = new System.Drawing.Size(660, 20);
            this.boxServico.TabIndex = 16;
            // 
            // lbEquipe
            // 
            this.lbEquipe.AutoSize = true;
            this.lbEquipe.ForeColor = System.Drawing.Color.White;
            this.lbEquipe.Location = new System.Drawing.Point(112, 398);
            this.lbEquipe.Name = "lbEquipe";
            this.lbEquipe.Size = new System.Drawing.Size(40, 13);
            this.lbEquipe.TabIndex = 17;
            this.lbEquipe.Text = "Equipe";
            // 
            // boxEquipe
            // 
            this.boxEquipe.Location = new System.Drawing.Point(162, 395);
            this.boxEquipe.Name = "boxEquipe";
            this.boxEquipe.Size = new System.Drawing.Size(328, 20);
            this.boxEquipe.TabIndex = 18;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.ForeColor = System.Drawing.Color.White;
            this.lbValor.Location = new System.Drawing.Point(496, 398);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(31, 13);
            this.lbValor.TabIndex = 19;
            this.lbValor.Text = "Valor";
            // 
            // boxValor
            // 
            this.boxValor.Location = new System.Drawing.Point(533, 395);
            this.boxValor.Name = "boxValor";
            this.boxValor.Size = new System.Drawing.Size(100, 20);
            this.boxValor.TabIndex = 20;
            // 
            // lbRecorrencia
            // 
            this.lbRecorrencia.AutoSize = true;
            this.lbRecorrencia.ForeColor = System.Drawing.Color.White;
            this.lbRecorrencia.Location = new System.Drawing.Point(639, 398);
            this.lbRecorrencia.Name = "lbRecorrencia";
            this.lbRecorrencia.Size = new System.Drawing.Size(65, 13);
            this.lbRecorrencia.TabIndex = 21;
            this.lbRecorrencia.Text = "Recorrencia";
            // 
            // boxRecorrencia
            // 
            this.boxRecorrencia.Location = new System.Drawing.Point(710, 395);
            this.boxRecorrencia.Name = "boxRecorrencia";
            this.boxRecorrencia.Size = new System.Drawing.Size(112, 20);
            this.boxRecorrencia.TabIndex = 22;
            // 
            // lbObservacao
            // 
            this.lbObservacao.AutoSize = true;
            this.lbObservacao.ForeColor = System.Drawing.Color.White;
            this.lbObservacao.Location = new System.Drawing.Point(85, 429);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(70, 13);
            this.lbObservacao.TabIndex = 23;
            this.lbObservacao.Text = "Observações";
            // 
            // boxObservacoes
            // 
            this.boxObservacoes.Location = new System.Drawing.Point(162, 426);
            this.boxObservacoes.Multiline = true;
            this.boxObservacoes.Name = "boxObservacoes";
            this.boxObservacoes.Size = new System.Drawing.Size(660, 105);
            this.boxObservacoes.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(334, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Usuario";
            // 
            // boxUsuario
            // 
            this.boxUsuario.Location = new System.Drawing.Point(383, 537);
            this.boxUsuario.Name = "boxUsuario";
            this.boxUsuario.Size = new System.Drawing.Size(144, 20);
            this.boxUsuario.TabIndex = 26;
            // 
            // btAdicionarOS
            // 
            this.btAdicionarOS.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionarOS.Image")));
            this.btAdicionarOS.Location = new System.Drawing.Point(124, 30);
            this.btAdicionarOS.Name = "btAdicionarOS";
            this.btAdicionarOS.Size = new System.Drawing.Size(28, 26);
            this.btAdicionarOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btAdicionarOS.TabIndex = 27;
            this.btAdicionarOS.TabStop = false;
            this.btAdicionarOS.Click += new System.EventHandler(this.btAdicionarOS_Click);
            // 
            // btAlterarOS
            // 
            this.btAlterarOS.Image = ((System.Drawing.Image)(resources.GetObject("btAlterarOS.Image")));
            this.btAlterarOS.Location = new System.Drawing.Point(124, 62);
            this.btAlterarOS.Name = "btAlterarOS";
            this.btAlterarOS.Size = new System.Drawing.Size(28, 26);
            this.btAlterarOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btAlterarOS.TabIndex = 28;
            this.btAlterarOS.TabStop = false;
            this.btAlterarOS.Click += new System.EventHandler(this.btAlterarOS_Click);
            // 
            // btDeletarOS
            // 
            this.btDeletarOS.Image = ((System.Drawing.Image)(resources.GetObject("btDeletarOS.Image")));
            this.btDeletarOS.Location = new System.Drawing.Point(124, 94);
            this.btDeletarOS.Name = "btDeletarOS";
            this.btDeletarOS.Size = new System.Drawing.Size(28, 26);
            this.btDeletarOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btDeletarOS.TabIndex = 29;
            this.btDeletarOS.TabStop = false;
            this.btDeletarOS.Click += new System.EventHandler(this.btDeletarOS_Click);
            // 
            // Form_OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(966, 561);
            this.Controls.Add(this.btDeletarOS);
            this.Controls.Add(this.btAlterarOS);
            this.Controls.Add(this.btAdicionarOS);
            this.Controls.Add(this.boxUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxObservacoes);
            this.Controls.Add(this.lbObservacao);
            this.Controls.Add(this.boxRecorrencia);
            this.Controls.Add(this.lbRecorrencia);
            this.Controls.Add(this.boxValor);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.boxEquipe);
            this.Controls.Add(this.lbEquipe);
            this.Controls.Add(this.boxServico);
            this.Controls.Add(this.lbServiço);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boxComplemento);
            this.Controls.Add(this.lbComplemento);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.boxNumero);
            this.Controls.Add(this.boxRua);
            this.Controls.Add(this.boxTipoRua);
            this.Controls.Add(this.boxNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.boxCod_Contrato);
            this.Controls.Add(this.lbCod_Contrato);
            this.Controls.Add(this.lbCodCliente);
            this.Controls.Add(this.boxCod_Cliente);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btSair);
            this.Name = "Form_OS";
            this.Text = "Form_OS";
            this.Load += new System.EventHandler(this.Form_OS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAdicionarOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAlterarOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDeletarOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox boxCod_Cliente;
        private System.Windows.Forms.Label lbCodCliente;
        private System.Windows.Forms.Label lbCod_Contrato;
        private System.Windows.Forms.TextBox boxCod_Contrato;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox boxNome;
        private System.Windows.Forms.TextBox boxTipoRua;
        private System.Windows.Forms.TextBox boxRua;
        private System.Windows.Forms.TextBox boxNumero;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.TextBox boxComplemento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbServiço;
        private System.Windows.Forms.TextBox boxServico;
        private System.Windows.Forms.Label lbEquipe;
        private System.Windows.Forms.TextBox boxEquipe;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox boxValor;
        private System.Windows.Forms.Label lbRecorrencia;
        private System.Windows.Forms.TextBox boxRecorrencia;
        private System.Windows.Forms.Label lbObservacao;
        private System.Windows.Forms.TextBox boxObservacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxUsuario;
        private System.Windows.Forms.PictureBox btAdicionarOS;
        private System.Windows.Forms.PictureBox btAlterarOS;
        private System.Windows.Forms.PictureBox btDeletarOS;
    }
}