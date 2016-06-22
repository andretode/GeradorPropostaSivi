namespace GeradorPropostaSivi
{
    partial class FormPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialogModelo = new System.Windows.Forms.OpenFileDialog();
            this.buttonAplicar = new System.Windows.Forms.Button();
            this.tabControlValores = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCarregarParametros = new System.Windows.Forms.Button();
            this.buttonSalvarParametros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPorcetagemDescontoImplantacao = new System.Windows.Forms.TextBox();
            this.labelValorBasedoModulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPesoQuantEmpreendimento = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxValorBasedoModuloImplantacao = new System.Windows.Forms.TextBox();
            this.dataGridViewPesoPlano = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPesoModulo = new System.Windows.Forms.Label();
            this.textBoxValorBasedoModuloPlano = new System.Windows.Forms.TextBox();
            this.labelPesoPlano = new System.Windows.Forms.Label();
            this.dataGridViewPesoModulo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelPesoQuantEmpreendimento = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxImplantacao = new System.Windows.Forms.GroupBox();
            this.dataGridViewResultadoImplantacao = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPlano = new System.Windows.Forms.GroupBox();
            this.dataGridViewResultadoPlano = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.saveFileDialogProposta = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogParametros = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogParametros = new System.Windows.Forms.SaveFileDialog();
            this.tabControlValores.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesoQuantEmpreendimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesoPlano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesoModulo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBoxImplantacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoImplantacao)).BeginInit();
            this.groupBoxPlano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoPlano)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogModelo
            // 
            this.openFileDialogModelo.FileName = "openFileDialog1";
            this.openFileDialogModelo.Filter = "Word |*.doc|Word |*.docx";
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(201, 649);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(183, 23);
            this.buttonAplicar.TabIndex = 2;
            this.buttonAplicar.Text = "Aplicar Valores na Proposta";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            this.buttonAplicar.Click += new System.EventHandler(this.buttonAplicar_Click);
            // 
            // tabControlValores
            // 
            this.tabControlValores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlValores.Controls.Add(this.tabPage1);
            this.tabControlValores.Controls.Add(this.tabPage2);
            this.tabControlValores.Location = new System.Drawing.Point(12, 12);
            this.tabControlValores.Name = "tabControlValores";
            this.tabControlValores.SelectedIndex = 0;
            this.tabControlValores.Size = new System.Drawing.Size(897, 635);
            this.tabControlValores.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCarregarParametros);
            this.tabPage1.Controls.Add(this.buttonSalvarParametros);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxPorcetagemDescontoImplantacao);
            this.tabPage1.Controls.Add(this.labelValorBasedoModulo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewPesoQuantEmpreendimento);
            this.tabPage1.Controls.Add(this.textBoxValorBasedoModuloImplantacao);
            this.tabPage1.Controls.Add(this.dataGridViewPesoPlano);
            this.tabPage1.Controls.Add(this.labelPesoModulo);
            this.tabPage1.Controls.Add(this.textBoxValorBasedoModuloPlano);
            this.tabPage1.Controls.Add(this.labelPesoPlano);
            this.tabPage1.Controls.Add(this.dataGridViewPesoModulo);
            this.tabPage1.Controls.Add(this.labelPesoQuantEmpreendimento);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(889, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuração de Parâmetros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCarregarParametros
            // 
            this.buttonCarregarParametros.Location = new System.Drawing.Point(18, 23);
            this.buttonCarregarParametros.Name = "buttonCarregarParametros";
            this.buttonCarregarParametros.Size = new System.Drawing.Size(119, 23);
            this.buttonCarregarParametros.TabIndex = 0;
            this.buttonCarregarParametros.Text = "Carregar Parametros";
            this.buttonCarregarParametros.UseVisualStyleBackColor = true;
            this.buttonCarregarParametros.Click += new System.EventHandler(this.buttonCarregarParametros_Click);
            // 
            // buttonSalvarParametros
            // 
            this.buttonSalvarParametros.Location = new System.Drawing.Point(142, 23);
            this.buttonSalvarParametros.Name = "buttonSalvarParametros";
            this.buttonSalvarParametros.Size = new System.Drawing.Size(119, 23);
            this.buttonSalvarParametros.TabIndex = 1;
            this.buttonSalvarParametros.Text = "Salvar Parametros";
            this.buttonSalvarParametros.UseVisualStyleBackColor = true;
            this.buttonSalvarParametros.Click += new System.EventHandler(this.buttonSalvarParametros_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Porcentagem de desconto na implantação e treinamento       (%):";
            // 
            // textBoxPorcetagemDescontoImplantacao
            // 
            this.textBoxPorcetagemDescontoImplantacao.Location = new System.Drawing.Point(332, 116);
            this.textBoxPorcetagemDescontoImplantacao.Name = "textBoxPorcetagemDescontoImplantacao";
            this.textBoxPorcetagemDescontoImplantacao.Size = new System.Drawing.Size(82, 20);
            this.textBoxPorcetagemDescontoImplantacao.TabIndex = 7;
            // 
            // labelValorBasedoModulo
            // 
            this.labelValorBasedoModulo.AutoSize = true;
            this.labelValorBasedoModulo.Location = new System.Drawing.Point(15, 76);
            this.labelValorBasedoModulo.Name = "labelValorBasedoModulo";
            this.labelValorBasedoModulo.Size = new System.Drawing.Size(312, 13);
            this.labelValorBasedoModulo.TabIndex = 2;
            this.labelValorBasedoModulo.Text = "Valor base do módulo - plano VIP e até 2 empreendimentos (R$):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor base do módulo - implantação e treinamento                (R$):";
            // 
            // dataGridViewPesoQuantEmpreendimento
            // 
            this.dataGridViewPesoQuantEmpreendimento.AllowUserToAddRows = false;
            this.dataGridViewPesoQuantEmpreendimento.AllowUserToDeleteRows = false;
            this.dataGridViewPesoQuantEmpreendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesoQuantEmpreendimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewPesoQuantEmpreendimento.Location = new System.Drawing.Point(15, 164);
            this.dataGridViewPesoQuantEmpreendimento.Name = "dataGridViewPesoQuantEmpreendimento";
            this.dataGridViewPesoQuantEmpreendimento.Size = new System.Drawing.Size(441, 117);
            this.dataGridViewPesoQuantEmpreendimento.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° de Empreendimentos (Até)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column2.HeaderText = "Peso";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // textBoxValorBasedoModuloImplantacao
            // 
            this.textBoxValorBasedoModuloImplantacao.Location = new System.Drawing.Point(332, 96);
            this.textBoxValorBasedoModuloImplantacao.Name = "textBoxValorBasedoModuloImplantacao";
            this.textBoxValorBasedoModuloImplantacao.Size = new System.Drawing.Size(82, 20);
            this.textBoxValorBasedoModuloImplantacao.TabIndex = 5;
            // 
            // dataGridViewPesoPlano
            // 
            this.dataGridViewPesoPlano.AllowUserToAddRows = false;
            this.dataGridViewPesoPlano.AllowUserToDeleteRows = false;
            this.dataGridViewPesoPlano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesoPlano.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewPesoPlano.Location = new System.Drawing.Point(15, 311);
            this.dataGridViewPesoPlano.Name = "dataGridViewPesoPlano";
            this.dataGridViewPesoPlano.Size = new System.Drawing.Size(441, 98);
            this.dataGridViewPesoPlano.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Plano de Atendimento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn2.HeaderText = "Peso";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // labelPesoModulo
            // 
            this.labelPesoModulo.AutoSize = true;
            this.labelPesoModulo.Location = new System.Drawing.Point(15, 422);
            this.labelPesoModulo.Name = "labelPesoModulo";
            this.labelPesoModulo.Size = new System.Drawing.Size(84, 13);
            this.labelPesoModulo.TabIndex = 12;
            this.labelPesoModulo.Text = "Peso do Módulo";
            // 
            // textBoxValorBasedoModuloPlano
            // 
            this.textBoxValorBasedoModuloPlano.Location = new System.Drawing.Point(332, 73);
            this.textBoxValorBasedoModuloPlano.Name = "textBoxValorBasedoModuloPlano";
            this.textBoxValorBasedoModuloPlano.Size = new System.Drawing.Size(82, 20);
            this.textBoxValorBasedoModuloPlano.TabIndex = 3;
            // 
            // labelPesoPlano
            // 
            this.labelPesoPlano.AutoSize = true;
            this.labelPesoPlano.Location = new System.Drawing.Point(15, 295);
            this.labelPesoPlano.Name = "labelPesoPlano";
            this.labelPesoPlano.Size = new System.Drawing.Size(76, 13);
            this.labelPesoPlano.TabIndex = 10;
            this.labelPesoPlano.Text = "Peso do Plano";
            // 
            // dataGridViewPesoModulo
            // 
            this.dataGridViewPesoModulo.AllowUserToAddRows = false;
            this.dataGridViewPesoModulo.AllowUserToDeleteRows = false;
            this.dataGridViewPesoModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesoModulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Column6,
            this.Column7,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewPesoModulo.Location = new System.Drawing.Point(15, 438);
            this.dataGridViewPesoModulo.Name = "dataGridViewPesoModulo";
            this.dataGridViewPesoModulo.Size = new System.Drawing.Size(441, 158);
            this.dataGridViewPesoModulo.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Módulo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Column6
            // 
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column6.HeaderText = "Peso Plano";
            this.Column6.Name = "Column6";
            this.Column6.Width = 90;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Peso Impl.";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Incluir?";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // labelPesoQuantEmpreendimento
            // 
            this.labelPesoQuantEmpreendimento.AutoSize = true;
            this.labelPesoQuantEmpreendimento.Location = new System.Drawing.Point(15, 148);
            this.labelPesoQuantEmpreendimento.Name = "labelPesoQuantEmpreendimento";
            this.labelPesoQuantEmpreendimento.Size = new System.Drawing.Size(168, 13);
            this.labelPesoQuantEmpreendimento.TabIndex = 8;
            this.labelPesoQuantEmpreendimento.Text = "Peso da Quant. Empreendimentos";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxImplantacao);
            this.tabPage2.Controls.Add(this.groupBoxPlano);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(889, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resultado dos Cálculos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxImplantacao
            // 
            this.groupBoxImplantacao.Controls.Add(this.dataGridViewResultadoImplantacao);
            this.groupBoxImplantacao.Location = new System.Drawing.Point(543, 6);
            this.groupBoxImplantacao.Name = "groupBoxImplantacao";
            this.groupBoxImplantacao.Size = new System.Drawing.Size(340, 597);
            this.groupBoxImplantacao.TabIndex = 1;
            this.groupBoxImplantacao.TabStop = false;
            this.groupBoxImplantacao.Text = "Implantação e Treinamento";
            // 
            // dataGridViewResultadoImplantacao
            // 
            this.dataGridViewResultadoImplantacao.AllowUserToAddRows = false;
            this.dataGridViewResultadoImplantacao.AllowUserToDeleteRows = false;
            this.dataGridViewResultadoImplantacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoImplantacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.Column8});
            this.dataGridViewResultadoImplantacao.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewResultadoImplantacao.Name = "dataGridViewResultadoImplantacao";
            this.dataGridViewResultadoImplantacao.ReadOnly = true;
            this.dataGridViewResultadoImplantacao.Size = new System.Drawing.Size(329, 266);
            this.dataGridViewResultadoImplantacao.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Módulo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewCellStyle20.NullValue = null;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn11.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Incluir?";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 50;
            // 
            // groupBoxPlano
            // 
            this.groupBoxPlano.Controls.Add(this.dataGridViewResultadoPlano);
            this.groupBoxPlano.Location = new System.Drawing.Point(6, 6);
            this.groupBoxPlano.Name = "groupBoxPlano";
            this.groupBoxPlano.Size = new System.Drawing.Size(531, 597);
            this.groupBoxPlano.TabIndex = 0;
            this.groupBoxPlano.TabStop = false;
            this.groupBoxPlano.Text = "Plano de Atendimento (Mensalidade)";
            // 
            // dataGridViewResultadoPlano
            // 
            this.dataGridViewResultadoPlano.AllowUserToAddRows = false;
            this.dataGridViewResultadoPlano.AllowUserToDeleteRows = false;
            this.dataGridViewResultadoPlano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoPlano.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridViewResultadoPlano.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewResultadoPlano.Name = "dataGridViewResultadoPlano";
            this.dataGridViewResultadoPlano.ReadOnly = true;
            this.dataGridViewResultadoPlano.Size = new System.Drawing.Size(517, 572);
            this.dataGridViewResultadoPlano.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Módulo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewCellStyle21.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn6.HeaderText = "2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewCellStyle22.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn7.HeaderText = "5";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewCellStyle23.Format = "N2";
            dataGridViewCellStyle23.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn8.HeaderText = "10";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewCellStyle24.Format = "N2";
            dataGridViewCellStyle24.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn9.HeaderText = "15";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(12, 649);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(183, 23);
            this.buttonCalcular.TabIndex = 1;
            this.buttonCalcular.Text = "Calcular Valores";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // openFileDialogParametros
            // 
            this.openFileDialogParametros.FileName = "openFileDialog1";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 688);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.buttonAplicar);
            this.Controls.Add(this.tabControlValores);
            this.Name = "FormPrincipal";
            this.Text = "Gerador de Proposta SIVI";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tabControlValores.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesoQuantEmpreendimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesoPlano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesoModulo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxImplantacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoImplantacao)).EndInit();
            this.groupBoxPlano.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoPlano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogModelo;
        private System.Windows.Forms.Button buttonAplicar;
        private System.Windows.Forms.TabControl tabControlValores;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxValorBasedoModuloPlano;
        private System.Windows.Forms.Label labelValorBasedoModulo;
        private System.Windows.Forms.DataGridView dataGridViewPesoQuantEmpreendimento;
        private System.Windows.Forms.DataGridView dataGridViewPesoPlano;
        private System.Windows.Forms.DataGridView dataGridViewPesoModulo;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelPesoPlano;
        private System.Windows.Forms.Label labelPesoQuantEmpreendimento;
        private System.Windows.Forms.Label labelPesoModulo;
        private System.Windows.Forms.SaveFileDialog saveFileDialogProposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxValorBasedoModuloImplantacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPorcetagemDescontoImplantacao;
        private System.Windows.Forms.GroupBox groupBoxPlano;
        private System.Windows.Forms.DataGridView dataGridViewResultadoPlano;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.GroupBox groupBoxImplantacao;
        private System.Windows.Forms.DataGridView dataGridViewResultadoImplantacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonSalvarParametros;
        private System.Windows.Forms.Button buttonCarregarParametros;
        private System.Windows.Forms.OpenFileDialog openFileDialogParametros;
        private System.Windows.Forms.SaveFileDialog saveFileDialogParametros;
    }
}