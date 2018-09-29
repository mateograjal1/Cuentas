using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuentas
{
    public partial class ObtenerNumero : Form
    {
        private decimal dinero;

        public decimal Dinero { get => dinero; }

        public ObtenerNumero(bool deposito)
        {
            InitializeComponent();
            if (deposito)
            {
                lblCantidad.Text = "Dinero a depositar";
            }
            else
            {
                lblCantidad.Text = "Dinero a retirar";
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txDinero.Text.Trim(), out dinero) && dinero > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(this, "Cantidad de dinero invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
