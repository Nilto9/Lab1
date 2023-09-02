using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public double Saldo { get; set; }

        // Constructor que acepta el nombre y el saldo como parámetros
        public Usuario(string nombre, double saldo)
        {
            Nombre = nombre;
            Saldo = saldo;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Saldo: ${Saldo}");
        }

    }
}
