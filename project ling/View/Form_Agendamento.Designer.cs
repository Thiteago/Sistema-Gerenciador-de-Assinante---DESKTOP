
namespace project_ling.View
{
    partial class Form_Agendamento
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btReagendar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btExecutado = new System.Windows.Forms.Button();
            this.btAtendimento = new System.Windows.Forms.Button();
            this.calend = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 122);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(1003, 533);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellValueChanged);
            this.dgv1.SelectionChanged += new System.EventHandler(this.dgv1_SelectionChanged);
            this.dgv1.Click += new System.EventHandler(this.dgv1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agendamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1057, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione uma Data";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(1222, 9);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 4;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // txtOS
            // 
            this.txtOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOS.Location = new System.Drawing.Point(1021, 342);
            this.txtOS.Name = "txtOS";
            this.txtOS.ReadOnly = true;
            this.txtOS.Size = new System.Drawing.Size(276, 20);
            this.txtOS.TabIndex = 5;
            this.txtOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1136, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "O.S";
            // 
            // btReagendar
            // 
            this.btReagendar.Location = new System.Drawing.Point(1122, 433);
            this.btReagendar.Name = "btReagendar";
            this.btReagendar.Size = new System.Drawing.Size(79, 23);
            this.btReagendar.TabIndex = 7;
            this.btReagendar.Text = "Reagendar";
            this.btReagendar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1021, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Marcar Ausencia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExecutado
            // 
            this.btExecutado.Location = new System.Drawing.Point(1116, 389);
            this.btExecutado.Name = "btExecutado";
            this.btExecutado.Size = new System.Drawing.Size(90, 38);
            this.btExecutado.TabIndex = 9;
            this.btExecutado.Text = "Marcar Executado";
            this.btExecutado.UseVisualStyleBackColor = true;
            this.btExecutado.Click += new System.EventHandler(this.btExecutado_Click);
            // 
            // btAtendimento
            // 
            this.btAtendimento.Location = new System.Drawing.Point(1212, 389);
            this.btAtendimento.Name = "btAtendimento";
            this.btAtendimento.Size = new System.Drawing.Size(85, 38);
            this.btAtendimento.TabIndex = 10;
            this.btAtendimento.Text = "Marcar Atendimento";
            this.btAtendimento.UseVisualStyleBackColor = true;
            this.btAtendimento.Click += new System.EventHandler(this.btAtendimento_Click);
            // 
            // calend
            // 
            this.calend.Location = new System.Drawing.Point(1054, 275);
            this.calend.Name = "calend";
            this.calend.Size = new System.Drawing.Size(200, 20);
            this.calend.TabIndex = 11;
            this.calend.ValueChanged += new System.EventHandler(this.calend_ValueChanged);
            // 
            // Form_Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1309, 667);
            this.Controls.Add(this.calend);
            this.Controls.Add(this.btAtendimento);
            this.Controls.Add(this.btExecutado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btReagendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Agendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Agendamento";
            this.Load += new System.EventHandler(this.Form_Agendamento_Load);
            this.Enter += new System.EventHandler(this.Form_Agendamento_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btReagendar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btExecutado;
        private System.Windows.Forms.Button btAtendimento;
        private System.Windows.Forms.DateTimePicker calend;
    }
}