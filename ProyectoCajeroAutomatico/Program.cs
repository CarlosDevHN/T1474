using System;

namespace ProyectoCajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionMenu=0;
            int opcionAdmin = 0;

            Usuario usuario = new Usuario();
            do
            {
                Console.WriteLine("Bienvenido al inicio de sesion" +
                              "\n Elija su opcion de inicio de sesion:" +
                              "\n 1. Administrador" +
                              "\n 2. Cliente" +
                              "\n 3. Salir");
                opcionMenu = Convert.ToInt32(Console.ReadLine());
                if (opcionMenu == 1)
                {
                    Console.WriteLine("Ingrese su nombre de usuario:");
                    string nombreUsuario = Console.ReadLine();
                    Console.WriteLine("Ingrese su contraseña: ");
                    int contraUsuario = Convert.ToInt32(Console.ReadLine());

                    if (nombreUsuario == "admin" && contraUsuario == 1234)
                    {
                        Console.WriteLine("-------Bienvenido Administrador-------");
                        MenuAdmin();
                        opcionAdmin = Convert.ToInt32(Console.ReadLine());

                        int idUsuario;

                        switch (opcionAdmin)
                        {
                            case 1:
                                Console.Write("Ingrese el ID de Usuario: ");
                                idUsuario = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Ingrese el Nombre: ");
                                string nombre = Console.ReadLine();
                                Console.Write("Ingrese el pin de Usuario: ");
                                int pinUsuario = Convert.ToInt32(Console.ReadLine());
                                bool estadoUsuario = true;
                                usuario.RegistrarUsuario(new Usuario(idUsuario, nombre, pinUsuario, estadoUsuario));
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Usuario Invalido");
                    }
                }
                else
                {
                    Cajero cajero = new Cajero();

                    cajero.MenuPrincipal();
                }
            } while (opcionMenu != 3);
            




            
        }
        private static void MenuAdmin()
        {
            Console.WriteLine("1. Crear usuario" +
                "\n2. Dar de baja un usuario" +
                "\n3. Crear cuenta" +
                "\n4. Dar de baja una cuenta" +
                "\n5. salir");
        }

    }
}
