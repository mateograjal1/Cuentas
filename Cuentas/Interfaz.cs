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
    public partial class Interfaz : Form
    {
        private BindingList<Cuenta> cuentas;
        private Cuenta cuentaSeleccionada = null;

        public Interfaz()
        {
            cuentas = new BindingList<Cuenta>();
            InitializeComponent();
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {
            cbCuentas.DataSource = cuentas;
            butAbrirCuenta.Enabled = false;
            butDepositar.Enabled = false;
            butRetirar.Enabled = false;
        }

        private void butCrearCuenta_Click(object sender, EventArgs e)
        {
            CrearCuentaUI ccu = new CrearCuentaUI();
            ccu.ShowDialog();
            if (ccu.DialogResult == DialogResult.OK)
            {
                cuentas.Add(ccu.NuevaCuenta);
                if (!butAbrirCuenta.Enabled)
                {
                    butAbrirCuenta.Enabled = true;
                    cbCuentas.SelectedIndex = cuentas.Count - 1;
                }
            }
        }

        private void butAbrirCuenta_Click(object sender, EventArgs e)
        {
            cuentaSeleccionada = cuentas[cbCuentas.SelectedIndex];
            if(!butDepositar.Enabled)
            {
                butDepositar.Enabled = true;
                butRetirar.Enabled = true;
            }
            Actualizar();
        }

        private void butDepositar_Click(object sender, EventArgs e)
        {
            if (cuentaSeleccionada != null)
            {
                CambiarDineroCuenta(true);
                Actualizar();
            }
        }

        private void butRetirar_Click(object sender, EventArgs e)
        {
            if (cuentaSeleccionada != null)
            {
                CambiarDineroCuenta(false);
                Actualizar();
            }
        }

        private void Actualizar()
        {
            txCuenta.Text = cuentaSeleccionada.NumCuenta.ToString();
            txTitular.Text = cuentaSeleccionada.Cedula.ToString();
            txSaldo.Text = cuentaSeleccionada.Saldo.ToString();
            switch (cuentaSeleccionada.Tipo)
            {
                case TipoCuenta.Ahorros:
                    txTipo.Text = "Ahorros";
                    break;
                case TipoCuenta.Corriente:
                    txTipo.Text = "Corriente";
                    break;
                case TipoCuenta.Empresarial:
                    txTipo.Text = "Empresarial";
                    break;
                case TipoCuenta.Premium:
                    txTipo.Text = "Premium";
                    break;
            }
        }

        private void CambiarDineroCuenta(bool deposito)
        {
            if (!string.IsNullOrEmpty(txCuenta.Text))
            {
                ObtenerNumero on = new ObtenerNumero(deposito);
                on.ShowDialog();
                if (on.DialogResult == DialogResult.OK)
                {
                    decimal dinero = on.Dinero;
                    if (deposito)
                    {
                        cuentaSeleccionada.depositar(dinero);
                    }
                    else
                    {
                        if (!cuentaSeleccionada.retirar(dinero))
                        {
                            MessageBox.Show(this, "No tiene saldo suficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        
    }
}
