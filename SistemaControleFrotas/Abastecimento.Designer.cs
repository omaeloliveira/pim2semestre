namespace SistemaControleFrotas
{
    partial class Abastecimento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abastecimento));
            this.datePickerAbastecimentoData = new System.Windows.Forms.DateTimePicker();
            this.txtAbastecimentoLitros = new System.Windows.Forms.TextBox();
            this.txtAbastecimentoCombustivel = new System.Windows.Forms.TextBox();
            this.txtAbastecimentoKmAtual = new System.Windows.Forms.TextBox();
            this.dataGridViewAbastecimento = new System.Windows.Forms.DataGridView();
            this.PlacaVeiculoAbastecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAbastecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LitrosAbastecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KmInicialAbastecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KmFinalAbastecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KmPercorridosAbastecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msmTheme = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblAbastecimentoCombustivel = new System.Windows.Forms.Label();
            this.lblAbastecimentoData = new System.Windows.Forms.Label();
            this.lblAbastecimentoLitros = new System.Windows.Forms.Label();
            this.lblAbastecimentoKmAtual = new System.Windows.Forms.Label();
            this.lblAbastecimentoPlaca = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.btnPesquisarPlaca = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbastecimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmTheme)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePickerAbastecimentoData
            // 
            this.datePickerAbastecimentoData.Checked = false;
            this.datePickerAbastecimentoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerAbastecimentoData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerAbastecimentoData.Location = new System.Drawing.Point(114, 197);
            this.datePickerAbastecimentoData.Name = "datePickerAbastecimentoData";
            this.datePickerAbastecimentoData.Size = new System.Drawing.Size(104, 22);
            this.datePickerAbastecimentoData.TabIndex = 2;
            // 
            // txtAbastecimentoLitros
            // 
            this.txtAbastecimentoLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbastecimentoLitros.Location = new System.Drawing.Point(114, 225);
            this.txtAbastecimentoLitros.MaxLength = 4;
            this.txtAbastecimentoLitros.Name = "txtAbastecimentoLitros";
            this.txtAbastecimentoLitros.Size = new System.Drawing.Size(65, 22);
            this.txtAbastecimentoLitros.TabIndex = 3;
            this.txtAbastecimentoLitros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbastecimentoLitros_KeyPress);
            // 
            // txtAbastecimentoCombustivel
            // 
            this.txtAbastecimentoCombustivel.Cursor = System.Windows.Forms.Cursors.No;
            this.txtAbastecimentoCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbastecimentoCombustivel.Location = new System.Drawing.Point(114, 168);
            this.txtAbastecimentoCombustivel.Name = "txtAbastecimentoCombustivel";
            this.txtAbastecimentoCombustivel.ReadOnly = true;
            this.txtAbastecimentoCombustivel.Size = new System.Drawing.Size(138, 22);
            this.txtAbastecimentoCombustivel.TabIndex = 5;
            this.txtAbastecimentoCombustivel.TabStop = false;
            // 
            // txtAbastecimentoKmAtual
            // 
            this.txtAbastecimentoKmAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbastecimentoKmAtual.Location = new System.Drawing.Point(307, 225);
            this.txtAbastecimentoKmAtual.MaxLength = 6;
            this.txtAbastecimentoKmAtual.Name = "txtAbastecimentoKmAtual";
            this.txtAbastecimentoKmAtual.Size = new System.Drawing.Size(78, 22);
            this.txtAbastecimentoKmAtual.TabIndex = 4;
            this.txtAbastecimentoKmAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbastecimentoKmAtual_KeyPress);
            // 
            // dataGridViewAbastecimento
            // 
            this.dataGridViewAbastecimento.AllowUserToOrderColumns = true;
            this.dataGridViewAbastecimento.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAbastecimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAbastecimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbastecimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlacaVeiculoAbastecimento,
            this.DataAbastecimento,
            this.LitrosAbastecimento,
            this.KmInicialAbastecimento,
            this.KmFinalAbastecimento,
            this.KmPercorridosAbastecimento});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAbastecimento.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewAbastecimento.Location = new System.Drawing.Point(5, 33);
            this.dataGridViewAbastecimento.Name = "dataGridViewAbastecimento";
            this.dataGridViewAbastecimento.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAbastecimento.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewAbastecimento.RowHeadersVisible = false;
            this.dataGridViewAbastecimento.Size = new System.Drawing.Size(650, 163);
            this.dataGridViewAbastecimento.TabIndex = 6;
            this.dataGridViewAbastecimento.TabStop = false;
            // 
            // PlacaVeiculoAbastecimento
            // 
            this.PlacaVeiculoAbastecimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacaVeiculoAbastecimento.DefaultCellStyle = dataGridViewCellStyle6;
            this.PlacaVeiculoAbastecimento.Frozen = true;
            this.PlacaVeiculoAbastecimento.HeaderText = "Placa";
            this.PlacaVeiculoAbastecimento.MaxInputLength = 8;
            this.PlacaVeiculoAbastecimento.MinimumWidth = 105;
            this.PlacaVeiculoAbastecimento.Name = "PlacaVeiculoAbastecimento";
            this.PlacaVeiculoAbastecimento.ReadOnly = true;
            this.PlacaVeiculoAbastecimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PlacaVeiculoAbastecimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.PlacaVeiculoAbastecimento.Width = 105;
            // 
            // DataAbastecimento
            // 
            this.DataAbastecimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataAbastecimento.HeaderText = "Data";
            this.DataAbastecimento.MaxInputLength = 10;
            this.DataAbastecimento.MinimumWidth = 102;
            this.DataAbastecimento.Name = "DataAbastecimento";
            this.DataAbastecimento.ReadOnly = true;
            this.DataAbastecimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataAbastecimento.Width = 102;
            // 
            // LitrosAbastecimento
            // 
            this.LitrosAbastecimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LitrosAbastecimento.HeaderText = "Litros";
            this.LitrosAbastecimento.MaxInputLength = 4;
            this.LitrosAbastecimento.MinimumWidth = 100;
            this.LitrosAbastecimento.Name = "LitrosAbastecimento";
            this.LitrosAbastecimento.ReadOnly = true;
            this.LitrosAbastecimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // KmInicialAbastecimento
            // 
            this.KmInicialAbastecimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KmInicialAbastecimento.HeaderText = "Km Atual";
            this.KmInicialAbastecimento.MaxInputLength = 6;
            this.KmInicialAbastecimento.MinimumWidth = 100;
            this.KmInicialAbastecimento.Name = "KmInicialAbastecimento";
            this.KmInicialAbastecimento.ReadOnly = true;
            this.KmInicialAbastecimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KmInicialAbastecimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // KmFinalAbastecimento
            // 
            this.KmFinalAbastecimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KmFinalAbastecimento.HeaderText = "Km Final";
            this.KmFinalAbastecimento.MaxInputLength = 6;
            this.KmFinalAbastecimento.MinimumWidth = 100;
            this.KmFinalAbastecimento.Name = "KmFinalAbastecimento";
            this.KmFinalAbastecimento.ReadOnly = true;
            this.KmFinalAbastecimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KmFinalAbastecimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // KmPercorridosAbastecimento
            // 
            this.KmPercorridosAbastecimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KmPercorridosAbastecimento.HeaderText = "Km Percorridos";
            this.KmPercorridosAbastecimento.MaxInputLength = 4;
            this.KmPercorridosAbastecimento.MinimumWidth = 120;
            this.KmPercorridosAbastecimento.Name = "KmPercorridosAbastecimento";
            this.KmPercorridosAbastecimento.ReadOnly = true;
            this.KmPercorridosAbastecimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KmPercorridosAbastecimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.KmPercorridosAbastecimento.Width = 140;
            // 
            // msmTheme
            // 
            this.msmTheme.Owner = this;
            this.msmTheme.Style = MetroFramework.MetroColorStyle.Blue;
            this.msmTheme.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblAbastecimentoCombustivel
            // 
            this.lblAbastecimentoCombustivel.AutoSize = true;
            this.lblAbastecimentoCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.lblAbastecimentoCombustivel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbastecimentoCombustivel.Location = new System.Drawing.Point(21, 170);
            this.lblAbastecimentoCombustivel.Name = "lblAbastecimentoCombustivel";
            this.lblAbastecimentoCombustivel.Size = new System.Drawing.Size(88, 18);
            this.lblAbastecimentoCombustivel.TabIndex = 7;
            this.lblAbastecimentoCombustivel.Text = "Combustível:";
            // 
            // lblAbastecimentoData
            // 
            this.lblAbastecimentoData.AutoSize = true;
            this.lblAbastecimentoData.BackColor = System.Drawing.Color.Transparent;
            this.lblAbastecimentoData.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbastecimentoData.Location = new System.Drawing.Point(21, 201);
            this.lblAbastecimentoData.Name = "lblAbastecimentoData";
            this.lblAbastecimentoData.Size = new System.Drawing.Size(41, 18);
            this.lblAbastecimentoData.TabIndex = 7;
            this.lblAbastecimentoData.Text = "Data:";
            // 
            // lblAbastecimentoLitros
            // 
            this.lblAbastecimentoLitros.AutoSize = true;
            this.lblAbastecimentoLitros.BackColor = System.Drawing.Color.Transparent;
            this.lblAbastecimentoLitros.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbastecimentoLitros.Location = new System.Drawing.Point(21, 227);
            this.lblAbastecimentoLitros.Name = "lblAbastecimentoLitros";
            this.lblAbastecimentoLitros.Size = new System.Drawing.Size(46, 18);
            this.lblAbastecimentoLitros.TabIndex = 7;
            this.lblAbastecimentoLitros.Text = "Litros:";
            // 
            // lblAbastecimentoKmAtual
            // 
            this.lblAbastecimentoKmAtual.AutoSize = true;
            this.lblAbastecimentoKmAtual.BackColor = System.Drawing.Color.Transparent;
            this.lblAbastecimentoKmAtual.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbastecimentoKmAtual.Location = new System.Drawing.Point(233, 227);
            this.lblAbastecimentoKmAtual.Name = "lblAbastecimentoKmAtual";
            this.lblAbastecimentoKmAtual.Size = new System.Drawing.Size(68, 18);
            this.lblAbastecimentoKmAtual.TabIndex = 7;
            this.lblAbastecimentoKmAtual.Text = "Km Atual:";
            // 
            // lblAbastecimentoPlaca
            // 
            this.lblAbastecimentoPlaca.AutoSize = true;
            this.lblAbastecimentoPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblAbastecimentoPlaca.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbastecimentoPlaca.Location = new System.Drawing.Point(21, 84);
            this.lblAbastecimentoPlaca.Name = "lblAbastecimentoPlaca";
            this.lblAbastecimentoPlaca.Size = new System.Drawing.Size(44, 18);
            this.lblAbastecimentoPlaca.TabIndex = 7;
            this.lblAbastecimentoPlaca.Text = "Placa:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(5, 8);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(25, 22);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnAbastecimentoLimpar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(34, 8);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(25, 22);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(114, 82);
            this.txtPlaca.MaxLength = 8;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(88, 22);
            this.txtPlaca.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(114, 111);
            this.txtMarca.MaxLength = 8;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(109, 22);
            this.txtMarca.TabIndex = 11;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(21, 113);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 18);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca:";
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(114, 139);
            this.txtCor.MaxLength = 8;
            this.txtCor.Name = "txtCor";
            this.txtCor.ReadOnly = true;
            this.txtCor.Size = new System.Drawing.Size(88, 22);
            this.txtCor.TabIndex = 13;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.BackColor = System.Drawing.Color.Transparent;
            this.lblCor.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(21, 140);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(33, 18);
            this.lblCor.TabIndex = 14;
            this.lblCor.Text = "Cor:";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(307, 110);
            this.txtModelo.MaxLength = 8;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(115, 22);
            this.txtModelo.TabIndex = 15;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(241, 112);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(60, 18);
            this.lblModelo.TabIndex = 16;
            this.lblModelo.Text = "Modelo:";
            // 
            // btnPesquisarPlaca
            // 
            this.btnPesquisarPlaca.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarPlaca.Image")));
            this.btnPesquisarPlaca.Location = new System.Drawing.Point(208, 82);
            this.btnPesquisarPlaca.Name = "btnPesquisarPlaca";
            this.btnPesquisarPlaca.Size = new System.Drawing.Size(25, 22);
            this.btnPesquisarPlaca.TabIndex = 17;
            this.btnPesquisarPlaca.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(63, 8);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(25, 22);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.dataGridViewAbastecimento);
            this.groupBox1.Location = new System.Drawing.Point(11, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 202);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // Abastecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(683, 465);
            this.Controls.Add(this.btnPesquisarPlaca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblAbastecimentoPlaca);
            this.Controls.Add(this.lblAbastecimentoKmAtual);
            this.Controls.Add(this.lblAbastecimentoLitros);
            this.Controls.Add(this.lblAbastecimentoData);
            this.Controls.Add(this.lblAbastecimentoCombustivel);
            this.Controls.Add(this.txtAbastecimentoCombustivel);
            this.Controls.Add(this.txtAbastecimentoKmAtual);
            this.Controls.Add(this.txtAbastecimentoLitros);
            this.Controls.Add(this.datePickerAbastecimentoData);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Abastecimento";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Abastecimento";
            this.Load += new System.EventHandler(this.Abastecimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbastecimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmTheme)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datePickerAbastecimentoData;
        private System.Windows.Forms.TextBox txtAbastecimentoLitros;
        private System.Windows.Forms.TextBox txtAbastecimentoCombustivel;
        private System.Windows.Forms.TextBox txtAbastecimentoKmAtual;
        private System.Windows.Forms.DataGridView dataGridViewAbastecimento;
        private MetroFramework.Components.MetroStyleManager msmTheme;
        private System.Windows.Forms.Label lblAbastecimentoPlaca;
        private System.Windows.Forms.Label lblAbastecimentoKmAtual;
        private System.Windows.Forms.Label lblAbastecimentoLitros;
        private System.Windows.Forms.Label lblAbastecimentoData;
        private System.Windows.Forms.Label lblAbastecimentoCombustivel;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaVeiculoAbastecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAbastecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn LitrosAbastecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn KmInicialAbastecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn KmFinalAbastecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn KmPercorridosAbastecimento;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnPesquisarPlaca;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}