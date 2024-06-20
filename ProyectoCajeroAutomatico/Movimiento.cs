using System;
namespace ProyectoCajeroAutomatico
{
    public class Movimiento
    {

        public decimal MovDebito { get; set; }
        public decimal MovCredito { get; set; }
        public decimal MovSaldo { get; set; }
        public int CuentaNumero { get; set; }

        public void Retiro(int numeroCuenta, decimal monto)
        {
            Cuenta cuenta = new Cuenta();
            decimal cuentaSaldo = cuenta.Saldo();

            if (cuentaSaldo >= monto) {
                decimal nuevoSaldo = cuentaSaldo - monto;
                MovDebito = monto;
                MovSaldo = nuevoSaldo;
            } else {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void Deposito(int numeroCuenta, decimal monto)
        {
            Cuenta cuenta = new Cuenta();
            decimal cuentaSaldo = cuenta.Saldo();

            if (monto > 0)
            {
                decimal nuevoSaldo = cuentaSaldo + monto;
                MovDebito = monto;
                MovSaldo = nuevoSaldo;
            }
            else
            {
                Console.WriteLine("Debe especificar un monto mayo a cero (0)");
            }

        }
           

    }
   
}

