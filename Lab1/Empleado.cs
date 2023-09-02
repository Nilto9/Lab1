using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Empleado : Usuario
    {
        public double Sueldo { get; set; }

        public Empleado(string nombre, double saldo, double sueldo) : base(nombre, saldo)
        {
            Sueldo = sueldo;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Información del Empleado:");
            Console.WriteLine($"Nombre del Empleado: {Nombre}");
            Console.WriteLine($"Saldo del Empleado: ${Saldo}");
            Console.WriteLine($"Sueldo del Empleado: ${Sueldo}");
            // Agrega más detalles específicos del empleado aquí si es necesario
        }
    }
}
