using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SistemaControleFrotas
{
    public partial class CadastroVeiculo : MetroFramework.Forms.MetroForm
    {
        public CadastroVeiculo()
        {
            InitializeComponent();
        }

        private void txtAnoVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtKmVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsDigit(e.KeyChar)) || Char.IsWhiteSpace(e.KeyChar)) && e.KeyChar != 08)
                e.Handled = true;
        }

        private void btnCadastroVeiculoLimpar_Click(object sender, EventArgs e)
        {
            limparTextBox(this.Controls);
        }

        private void limparTextBox(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                if (ctrl is MaskedTextBox)
                    ((MaskedTextBox)ctrl).Text = string.Empty;
                if (ctrl is RadioButton)
                    ((RadioButton)ctrl).Checked = false;
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedItem = -1;
            }
        }

        private void CadastroVeiculo_Load(object sender, EventArgs e)
        {
            if (this.Theme == MetroFramework.MetroThemeStyle.Dark)
                modoEscuro(this.Controls);
        }

        private void modoEscuro(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Label)
                    ((Label)control).ForeColor = Color.White;
                if (control is Button)
                    ((Button)control).ForeColor = Color.White;
            }
        }

        private void LblCadastroVeiculoChassi_Click(object sender, EventArgs e)
        {

        }

        private void TxtChassiVeiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbSeguro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeguro.SelectedIndex == 0)
                txtNumeroApolice.ReadOnly = false;
            else
                txtNumeroApolice.ReadOnly = true;
        }
    }
}
