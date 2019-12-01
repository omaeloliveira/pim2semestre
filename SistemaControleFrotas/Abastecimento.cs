using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaControleFrotas
{
    public partial class Abastecimento : MetroFramework.Forms.MetroForm 
    {
        public Abastecimento()
        {
            InitializeComponent();
        }

        private void txtAbastecimentoLitros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsDigit(e.KeyChar)) || Char.IsWhiteSpace(e.KeyChar)) && e.KeyChar != 08)
                e.Handled = true;
        }

        private void txtAbastecimentoKmAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsDigit(e.KeyChar)) || Char.IsWhiteSpace(e.KeyChar)) && e.KeyChar != 08)
                e.Handled = true;
        }

        private void Abastecimento_Load(object sender, EventArgs e)
        {
            if(this.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                modoEscuro(this.Controls);
            }
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

        private void BtnAbastecimentoLimpar_Click(object sender, EventArgs e)
        {
            limparTextBox(this.Controls);
        }

        private void limparTextBox(Control.ControlCollection controles)
        {
            //Faz um laço para cada controle passado no parâmetro ctrl
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedItem = -1;
                if (ctrl is DateTimePicker)
                    ((DateTimePicker)ctrl).Value = DateTime.Today;
            }
        }
    }
}
