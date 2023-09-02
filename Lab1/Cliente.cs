using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Cliente : Usuario
    {
        public List<double> Cargos { get; set; }

        // Constructor que acepta todas las propiedades y las inicializa
        public Cliente(string nombre, double saldo) : base(nombre, saldo)
        {
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Información del Cliente:");
            Console.WriteLine($"Nombre del Cliente: {Nombre}");
            Console.WriteLine($"Saldo del Cliente: ${Saldo}");
            // Agrega más detalles específicos del cliente aquí si es necesario
        }

    }
}
