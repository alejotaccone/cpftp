using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Auto
    {


        public double Peso { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }

        public Auto() { 
        }

        public Auto(double peso, string color, string marca)
        {
            Peso = peso;
            Color = color;
            Marca = marca;
        }

        public override string ToString()
        {
            return $"Vehiculo: {Marca} | Color: {Color} | Peso: {Peso}";
        }
    }
}
