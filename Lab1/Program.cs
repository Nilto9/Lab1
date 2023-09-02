using Lab1;
using System;
using System.Collections.Generic;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Grifo grifo = new Grifo();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1) Mostrar información de usuarios");
                Console.WriteLine("2) Agregar cliente");
                Console.WriteLine("3) Agregar empleado");
                Console.WriteLine("4) Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\nInformación de Usuarios:");
                        grifo.MostrarUsuarios();
                        break;

                    case "2":
                        Console.Write("Ingrese el nombre del cliente: ");
                        string nombreCliente = Console.ReadLine();
                        Console.Write("Ingrese el saldo del cliente: ");
                        double saldoCliente = Convert.ToDouble(Console.ReadLine());

                        Cliente nuevoCliente = new Cliente(nombreCliente, saldoCliente);
                        grifo.AgregarUsuario(nuevoCliente);
                        Console.WriteLine("Cliente agregado con éxito.\n");
                        break;

                    case "3":
                        Console.Write("Ingrese el nombre del empleado: ");
                        string nombreEmpleado = Console.ReadLine();
                        Console.Write("Ingrese el saldo del empleado: ");
                        double saldoEmpleado = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el sueldo del empleado: ");
                        double sueldoEmpleado = Convert.ToDouble(Console.ReadLine());

                        Empleado nuevoEmpleado = new Empleado(nombreEmpleado, saldoEmpleado, sueldoEmpleado);
                        grifo.AgregarUsuario(nuevoEmpleado);
                        Console.WriteLine("Empleado agregado con éxito.\n");
                        break;

                    case "4":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.\n");
                        break;
                }
            }
        }
    }
}

