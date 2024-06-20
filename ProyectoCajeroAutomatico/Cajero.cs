using System;
namespace ProyectoCajeroAutomatico
{
	public class Cajero
	{
        public string Usuario { get; set; }
        public int Opcion { get; set; }

        public int Saldo { get; set; }

        public void MenuPrincipal()
        {
            Console.WriteLine("Bienvenido Usuario");
            Console.WriteLine("Que deseas hacer hoy?");
            Console.WriteLine("1. Retiro");
            Console.WriteLine("2. Depósito");
            Console.WriteLine("3. Consultar Saldo");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            Opcion = Convert.ToInt32(Console.ReadLine());

            switch (Opcion)
            {
                case 1:
                    OpcionRetiro();
                    break;
                case 2:
                    OpcionDeposito();
                    break;
                case 3:
                    VerificaSaldo();
                    break;
                case 4:
                    Console.WriteLine("Gracias, te esperamos pronto.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
                    MenuPrincipal();
                    break;
            }
        }

        public void OpcionRetiro()
        {
           

            Console.WriteLine("Ingrese su usuario: ");
            int usuarioId = Convert.ToInt32(Console.ReadLine());

            Cuenta cuenta = new Cuenta();
            int numeroCuenta = cuenta.ValidaUsuario(usuarioId);

            Console.Write($"Ingrese el monto a retirar la cuenta xxxx{numeroCuenta}: ");
            decimal monto = Convert.ToDecimal(Console.ReadLine());

            Movimiento movimiento = new Movimiento();
            movimiento.Retiro(numeroCuenta, monto);

            Console.WriteLine("Su nuevo saldo es: " + movimiento.MovSaldo.ToString());
        }

        public void OpcionDeposito()
        {
            Console.WriteLine("Ingrese su usuario: ");
            int usuarioId = Convert.ToInt32(Console.ReadLine());

            Cuenta cuenta = new Cuenta();
            int numeroCuenta = cuenta.ValidaUsuario(usuarioId);

            Console.Write("Ingrese el monto a depositar: ");
            decimal monto = Convert.ToDecimal(Console.ReadLine());

            Movimiento movimiento = new Movimiento();
            movimiento.Deposito(numeroCuenta, monto);

            Console.WriteLine("Su nuevo saldo es: " + movimiento.MovSaldo.ToString());
        }

        public void VerificaSaldo()
        {
            Console.WriteLine("Ingrese su usuario: ");
            int usuarioId = Convert.ToInt32(Console.ReadLine());

            Cuenta cuenta = new Cuenta();
            decimal saldoCuenta = cuenta.Saldo();

            Console.WriteLine("Su saldo es: " + saldoCuenta.ToString());
        }

  
    }
}

