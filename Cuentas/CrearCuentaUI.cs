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
    public partial class CrearCuentaUI : Form
    {
        private Cuenta cuenta;

        public Cuenta NuevaCuenta { get => cuenta; }

        public CrearCuentaUI()
        {
            InitializeComponent();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CrearCuentaUI_Load(object sender, EventArgs e)
        {
            cbTipo.Items.Add("Ahorros");
            cbTipo.Items.Add("Corriente");
            cbTipo.Items.Add("Empresarial");
            cbTipo.Items.Add("Premium");
            cbTipo.SelectedIndex = 0;
        }

        private void butCrear_Click(object sender, EventArgs e)
        {
            ulong cedula;
            TipoCuenta tipo;
            decimal saldoInicial;
            if (ulong.TryParse(txCedula.Text.Trim(), out cedula))
            {
                switch((string)cbTipo.SelectedItem)
                {
                    case "Ahorros":
                        tipo = TipoCuenta.Ahorros;
                        break;
                    case "Corriente":
                        tipo = TipoCuenta.Corriente;
                        break;
                    case "Empresarial":
                        tipo = TipoCuenta.Empresarial;
                        break;
                    case "Premium":
                        tipo = TipoCuenta.Premium;
                        break;
                    default:
                        throw new Exception("Tipo de cuenta invalido. Este mensaje no deberia ser visto");
                }
                if (decimal.TryParse(txSaldo.Text.Trim(), out saldoInicial) && saldoInicial >= 0)
                {
                    cuenta = new Cuenta(cedula, tipo);
                    cuenta.depositar(saldoInicial);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(this, "Saldo inicial invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Cedula invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
