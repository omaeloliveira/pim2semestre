namespace SistemaControleFrotas
{
    partial class CadastroVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVeiculo));
            this.cmbTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.cmbCombustivelVeiculo = new System.Windows.Forms.ComboBox();
            this.mskPlacaVeiculo = new System.Windows.Forms.MaskedTextBox();
            this.txtMarcaVeiculo = new System.Windows.Forms.TextBox();
            this.txtModeloVeiculo = new System.Windows.Forms.TextBox();
            this.txtAnoVeiculo = new System.Windows.Forms.TextBox();
            this.txtChassiVeiculo = new System.Windows.Forms.TextBox();
            this.lblCadastroVeiculoTipo = new System.Windows.Forms.Label();
            this.lblCadastroVeiculoPlaca = new System.Windows.Forms.Label();
            this.lblCadastroVeiculoMarca = new System.Windows.Forms.Label();
            this.lblCadastroVeiculoModelo = new System.Windows.Forms.Label();
            this.lblCadastroVeiculoAno = new System.Windows.Forms.Label();
            this.lblCadastroVeiculoCombustivel = new System.Windows.Forms.Label();
            this.lblCadastroVeiculoChassi = new System.Windows.Forms.Label();
            this.btnCadastroVeiculoCadastrar = new System.Windows.Forms.Button();
            this.msmCadVeiculos = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnCadastroVeiculoLimpar = new System.Windows.Forms.Button();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.cmbSeguro = new System.Windows.Forms.ComboBox();
            this.lblNumeroApolice = new System.Windows.Forms.Label();
            this.txtNumeroApolice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.msmCadVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoVeiculo
            // 
            this.cmbTipoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVeiculo.FormattingEnabled = true;
            this.cmbTipoVeiculo.Items.AddRange(new object[] {
            "Utilitário",
            "Caminhão",
            "Van",
            "Furgão"});
            this.cmbTipoVeiculo.Location = new System.Drawing.Point(146, 78);
            this.cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            this.cmbTipoVeiculo.Size = new System.Drawing.Size(117, 24);
            this.cmbTipoVeiculo.TabIndex = 1;
            // 
            // cmbCombustivelVeiculo
            // 
            this.cmbCombustivelVeiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCombustivelVeiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCombustivelVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCombustivelVeiculo.FormattingEnabled = true;
            this.cmbCombustivelVeiculo.Items.AddRange(new object[] {
            "Gasolina",
            "Etanol",
            "Diesel",
            "Álcool"});
            this.cmbCombustivelVeiculo.Location = new System.Drawing.Point(146, 200);
            this.cmbCombustivelVeiculo.Name = "cmbCombustivelVeiculo";
            this.cmbCombustivelVeiculo.Size = new System.Drawing.Size(117, 24);
            this.cmbCombustivelVeiculo.TabIndex = 6;
            // 
            // mskPlacaVeiculo
            // 
            this.mskPlacaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPlacaVeiculo.Location = new System.Drawing.Point(146, 110);
            this.mskPlacaVeiculo.Mask = "aaa-0000";
            this.mskPlacaVeiculo.Name = "mskPlacaVeiculo";
            this.mskPlacaVeiculo.Size = new System.Drawing.Size(87, 22);
            this.mskPlacaVeiculo.TabIndex = 2;
            // 
            // txtMarcaVeiculo
            // 
            this.txtMarcaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaVeiculo.Location = new System.Drawing.Point(146, 140);
            this.txtMarcaVeiculo.MaxLength = 20;
            this.txtMarcaVeiculo.Name = "txtMarcaVeiculo";
            this.txtMarcaVeiculo.Size = new System.Drawing.Size(167, 22);
            this.txtMarcaVeiculo.TabIndex = 3;
            // 
            // txtModeloVeiculo
            // 
            this.txtModeloVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloVeiculo.Location = new System.Drawing.Point(146, 170);
            this.txtModeloVeiculo.MaxLength = 20;
            this.txtModeloVeiculo.Name = "txtModeloVeiculo";
            this.txtModeloVeiculo.Size = new System.Drawing.Size(149, 22);
            this.txtModeloVeiculo.TabIndex = 4;
            // 
            // txtAnoVeiculo
            // 
            this.txtAnoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoVeiculo.Location = new System.Drawing.Point(361, 170);
            this.txtAnoVeiculo.MaxLength = 4;
            this.txtAnoVeiculo.Name = "txtAnoVeiculo";
            this.txtAnoVeiculo.Size = new System.Drawing.Size(65, 22);
            this.txtAnoVeiculo.TabIndex = 5;
            this.txtAnoVeiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoVeiculo_KeyPress);
            // 
            // txtChassiVeiculo
            // 
            this.txtChassiVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChassiVeiculo.Location = new System.Drawing.Point(146, 232);
            this.txtChassiVeiculo.MaxLength = 17;
            this.txtChassiVeiculo.Name = "txtChassiVeiculo";
            this.txtChassiVeiculo.Size = new System.Drawing.Size(191, 22);
            this.txtChassiVeiculo.TabIndex = 10;
            this.txtChassiVeiculo.TextChanged += new System.EventHandler(this.TxtChassiVeiculo_TextChanged);
            // 
            // lblCadastroVeiculoTipo
            // 
            this.lblCadastroVeiculoTipo.AutoSize = true;
            this.lblCadastroVeiculoTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroVeiculoTipo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroVeiculoTipo.Location = new System.Drawing.Point(23, 78);
            this.lblCadastroVeiculoTipo.Name = "lblCadastroVeiculoTipo";
            this.lblCadastroVeiculoTipo.Size = new System.Drawing.Size(39, 18);
            this.lblCadastroVeiculoTipo.TabIndex = 11;
            this.lblCadastroVeiculoTipo.Text = "Tipo:";
            // 
            // lblCadastroVeiculoPlaca
            // 
            this.lblCadastroVeiculoPlaca.AutoSize = true;
            this.lblCadastroVeiculoPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroVeiculoPlaca.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroVeiculoPlaca.Location = new System.Drawing.Point(23, 112);
            this.lblCadastroVeiculoPlaca.Name = "lblCadastroVeiculoPlaca";
            this.lblCadastroVeiculoPlaca.Size = new System.Drawing.Size(44, 18);
            this.lblCadastroVeiculoPlaca.TabIndex = 12;
            this.lblCadastroVeiculoPlaca.Text = "Placa:";
            // 
            // lblCadastroVeiculoMarca
            // 
            this.lblCadastroVeiculoMarca.AutoSize = true;
            this.lblCadastroVeiculoMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroVeiculoMarca.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroVeiculoMarca.Location = new System.Drawing.Point(23, 142);
            this.lblCadastroVeiculoMarca.Name = "lblCadastroVeiculoMarca";
            this.lblCadastroVeiculoMarca.Size = new System.Drawing.Size(51, 18);
            this.lblCadastroVeiculoMarca.TabIndex = 13;
            this.lblCadastroVeiculoMarca.Text = "Marca:";
            // 
            // lblCadastroVeiculoModelo
            // 
            this.lblCadastroVeiculoModelo.AutoSize = true;
            this.lblCadastroVeiculoModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroVeiculoModelo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroVeiculoModelo.Location = new System.Drawing.Point(23, 172);
            this.lblCadastroVeiculoModelo.Name = "lblCadastroVeiculoModelo";
            this.lblCadastroVeiculoModelo.Size = new System.Drawing.Size(60, 18);
            this.lblCadastroVeiculoModelo.TabIndex = 14;
            this.lblCadastroVeiculoModelo.Text = "Modelo:";
            // 
            // lblCadastroVeiculoAno
            // 
            this.lblCadastroVeiculoAno.AutoSize = true;
            this.lblCadastroVeiculoAno.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroVeiculoAno.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroVeiculoAno.Location = new System.Drawing.Point(318, 172);
            this.lblCadastroVeiculoAno.Name = "lblCadastroVeiculoAno";
            this.lblCadastroVeiculoAno.Size = new System.Drawing.Size(37, 18);
            this.lblCadastroVeiculoAno.TabIndex = 15;
            this.lblCadastroVeiculoAno.Text = "Ano:";
            // 
            // lblCadastroVeiculoCombustivel
            // 
            this.lblCadastroVeiculoCombustivel.AutoSize = true;
            this.lblCadastroVeiculoCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroVeiculoCombustivel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroVeiculoCombustivel.Location = new System.Drawing.Point(23, 202);
            this.lblCadastroVeiculoCombustivel.Name = "lblCadastroVeiculoCombustivel";
            this.lblCadastroVeiculoCombustivel.Size = new System.Drawing.Size(117, 18);
            this.lblCadastroVeiculoCombustivel.TabIndex = 16;
            this.lblCadastroVeiculoCombustivel.Text = "Tipo combustível:";
            // 
            // lblCadastroVeiculoChassi
            // 
            this.lblCadastroVeiculoChassi.AutoSize = true;
            this.lblCadastroVeiculoChassi.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroVeiculoChassi.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroVeiculoChassi.Location = new System.Drawing.Point(23, 234);
            this.lblCadastroVeiculoChassi.Name = "lblCadastroVeiculoChassi";
            this.lblCadastroVeiculoChassi.Size = new System.Drawing.Size(50, 18);
            this.lblCadastroVeiculoChassi.TabIndex = 19;
            this.lblCadastroVeiculoChassi.Text = "Chassi:";
            this.lblCadastroVeiculoChassi.Click += new System.EventHandler(this.LblCadastroVeiculoChassi_Click);
            // 
            // btnCadastroVeiculoCadastrar
            // 
            this.btnCadastroVeiculoCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroVeiculoCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroVeiculoCadastrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroVeiculoCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroVeiculoCadastrar.Image")));
            this.btnCadastroVeiculoCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroVeiculoCadastrar.Location = new System.Drawing.Point(146, 332);
            this.btnCadastroVeiculoCadastrar.Name = "btnCadastroVeiculoCadastrar";
            this.btnCadastroVeiculoCadastrar.Size = new System.Drawing.Size(115, 39);
            this.btnCadastroVeiculoCadastrar.TabIndex = 21;
            this.btnCadastroVeiculoCadastrar.TabStop = false;
            this.btnCadastroVeiculoCadastrar.Text = "Cadastrar";
            this.btnCadastroVeiculoCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroVeiculoCadastrar.UseVisualStyleBackColor = true;
            // 
            // msmCadVeiculos
            // 
            this.msmCadVeiculos.Owner = this;
            // 
            // btnCadastroVeiculoLimpar
            // 
            this.btnCadastroVeiculoLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroVeiculoLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroVeiculoLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroVeiculoLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroVeiculoLimpar.Image")));
            this.btnCadastroVeiculoLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroVeiculoLimpar.Location = new System.Drawing.Point(24, 332);
            this.btnCadastroVeiculoLimpar.Name = "btnCadastroVeiculoLimpar";
            this.btnCadastroVeiculoLimpar.Size = new System.Drawing.Size(115, 39);
            this.btnCadastroVeiculoLimpar.TabIndex = 22;
            this.btnCadastroVeiculoLimpar.TabStop = false;
            this.btnCadastroVeiculoLimpar.Text = "Limpar";
            this.btnCadastroVeiculoLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroVeiculoLimpar.UseVisualStyleBackColor = true;
            this.btnCadastroVeiculoLimpar.Click += new System.EventHandler(this.btnCadastroVeiculoLimpar_Click);
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.BackColor = System.Drawing.Color.Transparent;
            this.lblSeguro.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.Location = new System.Drawing.Point(23, 263);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(97, 18);
            this.lblSeguro.TabIndex = 24;
            this.lblSeguro.Text = "Possui seguro:";
            // 
            // cmbSeguro
            // 
            this.cmbSeguro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbSeguro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeguro.FormattingEnabled = true;
            this.cmbSeguro.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cmbSeguro.Location = new System.Drawing.Point(146, 261);
            this.cmbSeguro.Name = "cmbSeguro";
            this.cmbSeguro.Size = new System.Drawing.Size(61, 24);
            this.cmbSeguro.TabIndex = 23;
            this.cmbSeguro.SelectedIndexChanged += new System.EventHandler(this.CmbSeguro_SelectedIndexChanged);
            // 
            // lblNumeroApolice
            // 
            this.lblNumeroApolice.AutoSize = true;
            this.lblNumeroApolice.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroApolice.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroApolice.Location = new System.Drawing.Point(227, 263);
            this.lblNumeroApolice.Name = "lblNumeroApolice";
            this.lblNumeroApolice.Size = new System.Drawing.Size(128, 18);
            this.lblNumeroApolice.TabIndex = 26;
            this.lblNumeroApolice.Text = "Número da apólice:";
            // 
            // txtNumeroApolice
            // 
            this.txtNumeroApolice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroApolice.Location = new System.Drawing.Point(361, 261);
            this.txtNumeroApolice.MaxLength = 17;
            this.txtNumeroApolice.Name = "txtNumeroApolice";
            this.txtNumeroApolice.ReadOnly = true;
            this.txtNumeroApolice.Size = new System.Drawing.Size(121, 22);
            this.txtNumeroApolice.TabIndex = 25;
            // 
            // CadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(696, 404);
            this.Controls.Add(this.lblNumeroApolice);
            this.Controls.Add(this.txtNumeroApolice);
            this.Controls.Add(this.lblSeguro);
            this.Controls.Add(this.cmbSeguro);
            this.Controls.Add(this.btnCadastroVeiculoLimpar);
            this.Controls.Add(this.btnCadastroVeiculoCadastrar);
            this.Controls.Add(this.lblCadastroVeiculoChassi);
            this.Controls.Add(this.lblCadastroVeiculoCombustivel);
            this.Controls.Add(this.lblCadastroVeiculoAno);
            this.Controls.Add(this.lblCadastroVeiculoModelo);
            this.Controls.Add(this.lblCadastroVeiculoMarca);
            this.Controls.Add(this.lblCadastroVeiculoPlaca);
            this.Controls.Add(this.lblCadastroVeiculoTipo);
            this.Controls.Add(this.txtAnoVeiculo);
            this.Controls.Add(this.txtChassiVeiculo);
            this.Controls.Add(this.txtModeloVeiculo);
            this.Controls.Add(this.txtMarcaVeiculo);
            this.Controls.Add(this.mskPlacaVeiculo);
            this.Controls.Add(this.cmbCombustivelVeiculo);
            this.Controls.Add(this.cmbTipoVeiculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroVeiculo";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Cadastro de Veículos";
            this.Load += new System.EventHandler(this.CadastroVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmCadVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTipoVeiculo;
        private System.Windows.Forms.ComboBox cmbCombustivelVeiculo;
        private System.Windows.Forms.MaskedTextBox mskPlacaVeiculo;
        private System.Windows.Forms.TextBox txtMarcaVeiculo;
        private System.Windows.Forms.TextBox txtModeloVeiculo;
        private System.Windows.Forms.TextBox txtAnoVeiculo;
        private System.Windows.Forms.TextBox txtChassiVeiculo;
        private System.Windows.Forms.Label lblCadastroVeiculoTipo;
        private System.Windows.Forms.Label lblCadastroVeiculoPlaca;
        private System.Windows.Forms.Label lblCadastroVeiculoMarca;
        private System.Windows.Forms.Label lblCadastroVeiculoModelo;
        private System.Windows.Forms.Label lblCadastroVeiculoAno;
        private System.Windows.Forms.Label lblCadastroVeiculoCombustivel;
        private System.Windows.Forms.Label lblCadastroVeiculoChassi;
        private System.Windows.Forms.Button btnCadastroVeiculoCadastrar;
        private System.Windows.Forms.Button btnCadastroVeiculoLimpar;
        private MetroFramework.Components.MetroStyleManager msmCadVeiculos;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.ComboBox cmbSeguro;
        private System.Windows.Forms.Label lblNumeroApolice;
        private System.Windows.Forms.TextBox txtNumeroApolice;
    }
}