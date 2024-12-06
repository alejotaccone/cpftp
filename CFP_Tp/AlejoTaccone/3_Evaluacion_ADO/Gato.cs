using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Evaluacion_ADO
{
    public class Gato : Animal
    {
        public string Raza { get; set; }
        public string ColorDePelo { get; set; }

        public Gato() { }
        public Gato(string nombre, int edad, string raza, string colorDePelo)
            : base(nombre, edad)
        {
            Raza = raza;
            ColorDePelo = colorDePelo;
        }

        protected override string HacerSonido()
        {
           return "Miau";
        }
        
        protected override string DatosPropios()
        {
            return $"Nombre: {Nombre} Raza: {Raza}\nColor de Pelo: {ColorDePelo}";
        }

        protected override bool Soniguales(object? obj)
        {
            Gato? a= obj as Gato;
            return base.Soniguales(obj) && a is not null && this.Raza.ToLower() == a.Raza.ToLower() && this.ColorDePelo.ToLower() == a.ColorDePelo.ToLower();
        }
    }
}
