using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaControleFrotas
{
    public partial class CadastroMotorista : MetroFramework.Forms.MetroForm
    {
        public CadastroMotorista()
        {
            InitializeComponent();
        }

        private void CadastroMotorista_Load(object sender, EventArgs e)
        {
            if (this.Theme == MetroFramework.MetroThemeStyle.Dark)
                modoEscuro(this.Controls);
        }

        private void modoEscuro(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Label)
                    ((Label)ctrl).ForeColor = Color.White;
                if (ctrl is Button)
                    ((Button)ctrl).ForeColor = Color.White;
            }
        }

        private void btnCadastroMotoristaLimpar_Click(object sender, EventArgs e)
        {
            LimparTextBox(this.Controls);
        }

        private void LimparTextBox(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                if (ctrl is MaskedTextBox)
                    ((MaskedTextBox)ctrl).Text = string.Empty;
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedItem = -1;
            }
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsDigit(e.KeyChar)) || Char.IsWhiteSpace(e.KeyChar)) && e.KeyChar != 08)
                e.Handled = true;
        }

        private void mskCep_Leave(object sender, EventArgs e)
        {
            if (!mskCep.MaskCompleted)
                mskCep.Text = string.Empty;
        }

        private void MskCpfMotorista_Leave(object sender, EventArgs e)
        {
            if (!mskCpfMotorista.MaskCompleted)
                mskCpfMotorista.Text = string.Empty;
        }

        private void MskTelefoneMotorista_Leave(object sender, EventArgs e)
        {
            if (!mskTelefoneMotorista.MaskCompleted)
                mskTelefoneMotorista.Text = string.Empty;
        }

        private void MskCelularMotorista_Leave(object sender, EventArgs e)
        {
            if (!mskCelularMotorista.MaskCompleted)
                mskCelularMotorista.Text = string.Empty;
        }
    }
}
