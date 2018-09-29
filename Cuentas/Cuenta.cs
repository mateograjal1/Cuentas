using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas
{
    public class Cuenta
    {
        private int numCuenta;
        private ulong cedula;
        private TipoCuenta tipo;
        private decimal saldo;

        private static int NUMEROS_CUENTAS = 1000000000;

        public int NumCuenta { get => numCuenta; }
        public ulong Cedula { get => cedula; }
        public TipoCuenta Tipo { get => tipo; }
        public decimal Saldo { get => saldo; }

        public Cuenta() { } //empty object
        
        public Cuenta(ulong cedula, TipoCuenta tipo)
        {
            this.cedula = cedula;
            this.tipo = tipo;
            this.numCuenta = ++NUMEROS_CUENTAS;
        }

        public void depositar(decimal deposito)
        {
            if (deposito < 0)
            {
                throw new Exception("No se puede hacer depositos negativos");
            }
            else
            {
                switch (Tipo)
                {
                    case TipoCuenta.Ahorros:
                        saldo += deposito * (decimal)0.99;
                        break;
                    case TipoCuenta.Corriente:
                        saldo += deposito * (decimal)0.95;
                        break;
                    case TipoCuenta.Empresarial:
                        saldo += deposito * (decimal)0.93;
                        break;
                    case TipoCuenta.Premium:
                        saldo += deposito * (decimal)0.83;
                        break;
                }
            }
        }

        public bool retirar(decimal retiro)
        {
            if (retiro > saldo)
            {
                return false;
            }
            else
            {
                saldo -= retiro;
                return true;
            }
        }

        public override string ToString()
        {
            return numCuenta.ToString();
        }
    }

    public enum TipoCuenta { Ahorros = 1, Corriente = 5, Empresarial = 7, Premium = 17 }
}
