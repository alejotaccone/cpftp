using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Evaluacion_ADO
{
    public class Perro : Animal
    {
        public string Rol { get; set; }
        public string Tamanio { get; set; }

        public Perro() { }
        public Perro(string nombre, int edad, string rol, string tamanio)
           : base(nombre, edad)
        {
            Rol = rol;
            Tamanio = tamanio;
        }

        protected override string HacerSonido()
        {
            return "Guau";
        }

        protected override string DatosPropios()
        {
            return $"Nombre: {Nombre} Rol: {Rol}\nTamaño: {Tamanio}";
        }

        protected override bool Soniguales(object? obj)
        {
            Perro? a = obj as Perro;
            return base.Soniguales(obj) && a is not null && this.Rol.ToLower() == a.Rol.ToLower() && this.Tamanio.ToLower() == a.Tamanio.ToLower();
        }
    }
}
