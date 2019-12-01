namespace SistemaControleFrotas
{
    partial class NovoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoUsuario));
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblDefinirSenha = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtDefinirSenha = new System.Windows.Forms.TextBox();
            this.checkBoxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.msmCadNovoUsuario = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblRepetirSenha = new System.Windows.Forms.Label();
            this.txtRepetirSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.msmCadNovoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(24, 89);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(119, 18);
            this.lblNomeUsuario.TabIndex = 0;
            this.lblNomeUsuario.Text = "Nome de Usuário:";
            // 
            // lblDefinirSenha
            // 
            this.lblDefinirSenha.AutoSize = true;
            this.lblDefinirSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblDefinirSenha.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefinirSenha.Location = new System.Drawing.Point(24, 119);
            this.lblDefinirSenha.Name = "lblDefinirSenha";
            this.lblDefinirSenha.Size = new System.Drawing.Size(96, 18);
            this.lblDefinirSenha.TabIndex = 0;
            this.lblDefinirSenha.Text = "Definir Senha:";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(149, 87);
            this.txtNomeUsuario.MaxLength = 20;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(146, 22);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // txtDefinirSenha
            // 
            this.txtDefinirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefinirSenha.Location = new System.Drawing.Point(149, 117);
            this.txtDefinirSenha.MaxLength = 15;
            this.txtDefinirSenha.Name = "txtDefinirSenha";
            this.txtDefinirSenha.Size = new System.Drawing.Size(146, 22);
            this.txtDefinirSenha.TabIndex = 2;
            this.txtDefinirSenha.UseSystemPasswordChar = true;
            // 
            // checkBoxMostrarSenha
            // 
            this.checkBoxMostrarSenha.AutoSize = true;
            this.checkBoxMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMostrarSenha.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMostrarSenha.Location = new System.Drawing.Point(313, 120);
            this.checkBoxMostrarSenha.Name = "checkBoxMostrarSenha";
            this.checkBoxMostrarSenha.Size = new System.Drawing.Size(107, 19);
            this.checkBoxMostrarSenha.TabIndex = 3;
            this.checkBoxMostrarSenha.Text = "Mostrar Senha";
            this.checkBoxMostrarSenha.UseVisualStyleBackColor = false;
            this.checkBoxMostrarSenha.CheckedChanged += new System.EventHandler(this.CheckBoxMostrarSenha_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(140, 229);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 39);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(18, 229);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 39);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // msmCadNovoUsuario
            // 
            this.msmCadNovoUsuario.Owner = this;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMensagem.Location = new System.Drawing.Point(356, 275);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 16);
            this.lblMensagem.TabIndex = 7;
            // 
            // lblRepetirSenha
            // 
            this.lblRepetirSenha.AutoSize = true;
            this.lblRepetirSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblRepetirSenha.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirSenha.Location = new System.Drawing.Point(24, 148);
            this.lblRepetirSenha.Name = "lblRepetirSenha";
            this.lblRepetirSenha.Size = new System.Drawing.Size(100, 18);
            this.lblRepetirSenha.TabIndex = 0;
            this.lblRepetirSenha.Text = "Repetir Senha:";
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepetirSenha.Location = new System.Drawing.Point(149, 146);
            this.txtRepetirSenha.MaxLength = 15;
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.Size = new System.Drawing.Size(146, 22);
            this.txtRepetirSenha.TabIndex = 8;
            this.txtRepetirSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Perfil do Usuário:";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Estoque",
            "Motorista",
            "Supervisor",
            "Usuário"});
            this.cmbPerfil.Location = new System.Drawing.Point(149, 176);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(121, 24);
            this.cmbPerfil.TabIndex = 10;
            // 
            // NovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(587, 294);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRepetirSenha);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.checkBoxMostrarSenha);
            this.Controls.Add(this.txtDefinirSenha);
            this.Controls.Add(this.lblRepetirSenha);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.lblDefinirSenha);
            this.Controls.Add(this.lblNomeUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovoUsuario";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Cadastrar Novo Usuário";
            this.Load += new System.EventHandler(this.NovoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmCadNovoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblDefinirSenha;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtDefinirSenha;
        private System.Windows.Forms.CheckBox checkBoxMostrarSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private MetroFramework.Components.MetroStyleManager msmCadNovoUsuario;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblRepetirSenha;
        private System.Windows.Forms.TextBox txtRepetirSenha;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Label label1;
    }
}