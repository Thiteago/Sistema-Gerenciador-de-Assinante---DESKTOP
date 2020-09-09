namespace project_ling.View
{
    partial class Assinante
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
            this.components = new System.ComponentModel.Container();
            this.btVoltar = new System.Windows.Forms.Button();
            this.bDLP2DataSet = new project_ling.BDLP2DataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new project_ling.BDLP2DataSetTableAdapters.UsuarioTableAdapter();
            this.btAbrirOSs = new System.Windows.Forms.Button();
            this.catPesquisa = new System.Windows.Forms.ComboBox();
            this.pesquisa = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btCadAssinante = new System.Windows.Forms.Button();
            this.btAltAssinante = new System.Windows.Forms.Button();
            this.btDeleteAssinante = new System.Windows.Forms.Button();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bDLP2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDLP2DataSet1 = new project_ling.BDLP2DataSet1();
            this.assinanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assinanteTableAdapter = new project_ling.BDLP2DataSet1TableAdapters.AssinanteTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bDLP2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLP2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLP2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assinanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(713, 12);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 0;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // bDLP2DataSet
            // 
            this.bDLP2DataSet.DataSetName = "BDLP2DataSet";
            this.bDLP2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.bDLP2DataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // btAbrirOSs
            // 
            this.btAbrirOSs.Location = new System.Drawing.Point(12, 402);
            this.btAbrirOSs.Name = "btAbrirOSs";
            this.btAbrirOSs.Size = new System.Drawing.Size(169, 36);
            this.btAbrirOSs.TabIndex = 6;
            this.btAbrirOSs.Text = "Ordens de Serviço";
            this.btAbrirOSs.UseVisualStyleBackColor = true;
            // 
            // catPesquisa
            // 
            this.catPesquisa.FormattingEnabled = true;
            this.catPesquisa.Items.AddRange(new object[] {
            "Nome",
            "Rua",
            "Bairro",
            "Cidade",
            "Estado",
            "Telefone",
            "CPF",
            "Email",
            "Codigo"});
            this.catPesquisa.Location = new System.Drawing.Point(111, 15);
            this.catPesquisa.Name = "catPesquisa";
            this.catPesquisa.Size = new System.Drawing.Size(121, 21);
            this.catPesquisa.TabIndex = 1;
            this.catPesquisa.SelectedIndexChanged += new System.EventHandler(this.catPesquisa_SelectedIndexChanged);
            // 
            // pesquisa
            // 
            this.pesquisa.Location = new System.Drawing.Point(238, 15);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(379, 20);
            this.pesquisa.TabIndex = 2;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(623, 15);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(63, 21);
            this.btBuscar.TabIndex = 7;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCadAssinante
            // 
            this.btCadAssinante.Location = new System.Drawing.Point(692, 415);
            this.btCadAssinante.Name = "btCadAssinante";
            this.btCadAssinante.Size = new System.Drawing.Size(86, 23);
            this.btCadAssinante.TabIndex = 3;
            this.btCadAssinante.Text = "Cad.Assinante";
            this.btCadAssinante.UseVisualStyleBackColor = true;
            this.btCadAssinante.Click += new System.EventHandler(this.btCadAssinante_Click);
            // 
            // btAltAssinante
            // 
            this.btAltAssinante.Location = new System.Drawing.Point(611, 415);
            this.btAltAssinante.Name = "btAltAssinante";
            this.btAltAssinante.Size = new System.Drawing.Size(75, 23);
            this.btAltAssinante.TabIndex = 4;
            this.btAltAssinante.Text = "Alterar";
            this.btAltAssinante.UseVisualStyleBackColor = true;
            // 
            // btDeleteAssinante
            // 
            this.btDeleteAssinante.Location = new System.Drawing.Point(530, 415);
            this.btDeleteAssinante.Name = "btDeleteAssinante";
            this.btDeleteAssinante.Size = new System.Drawing.Size(75, 23);
            this.btDeleteAssinante.TabIndex = 5;
            this.btDeleteAssinante.Text = "Deletar";
            this.btDeleteAssinante.UseVisualStyleBackColor = true;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this.bDLP2DataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.datanascimentoDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assinanteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 354);
            this.dataGridView1.TabIndex = 8;
            // 
            // bDLP2DataSetBindingSource
            // 
            this.bDLP2DataSetBindingSource.DataSource = this.bDLP2DataSet;
            this.bDLP2DataSetBindingSource.Position = 0;
            // 
            // bDLP2DataSet1
            // 
            this.bDLP2DataSet1.DataSetName = "BDLP2DataSet1";
            this.bDLP2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assinanteBindingSource
            // 
            this.assinanteBindingSource.DataMember = "Assinante";
            this.assinanteBindingSource.DataSource = this.bDLP2DataSet1;
            // 
            // assinanteTableAdapter
            // 
            this.assinanteTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            this.ruaDataGridViewTextBoxColumn.DataPropertyName = "Rua";
            this.ruaDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            // 
            // datanascimentoDataGridViewTextBoxColumn
            // 
            this.datanascimentoDataGridViewTextBoxColumn.DataPropertyName = "datanascimento";
            this.datanascimentoDataGridViewTextBoxColumn.HeaderText = "datanascimento";
            this.datanascimentoDataGridViewTextBoxColumn.Name = "datanascimentoDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Assinante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btAbrirOSs);
            this.Controls.Add(this.btDeleteAssinante);
            this.Controls.Add(this.btAltAssinante);
            this.Controls.Add(this.btCadAssinante);
            this.Controls.Add(this.pesquisa);
            this.Controls.Add(this.catPesquisa);
            this.Controls.Add(this.btVoltar);
            this.Name = "Assinante";
            this.Text = "Assinante";
            this.Load += new System.EventHandler(this.Assinante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDLP2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLP2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLP2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assinanteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltar;
        private BDLP2DataSet bDLP2DataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private BDLP2DataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Button btAbrirOSs;
        private System.Windows.Forms.ComboBox catPesquisa;
        private System.Windows.Forms.TextBox pesquisa;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btCadAssinante;
        private System.Windows.Forms.Button btAltAssinante;
        private System.Windows.Forms.Button btDeleteAssinante;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bDLP2DataSetBindingSource;
        private BDLP2DataSet1 bDLP2DataSet1;
        private System.Windows.Forms.BindingSource assinanteBindingSource;
        private BDLP2DataSet1TableAdapters.AssinanteTableAdapter assinanteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}