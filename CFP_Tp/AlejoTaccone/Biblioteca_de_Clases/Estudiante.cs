using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Biblioteca_de_Clases
{
    public class Estudiante
    {
        int legajo;
        string nombre;
        string apellido;
        List<string> materias;


        public Estudiante()
        {

        }

        public Estudiante(int legajo, string nombre, string apellido, List<string> materias)
        {
            this.legajo = legajo;
            //ValidarNombre(nombre); EXCEPTION
            this.nombre = nombre;
            this.apellido = apellido;
            this.materias = materias;
        }

        public int Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
      
        
        public List<string> Materias { get => materias; set => materias = value; }


        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nombre: {nombre} Apellido: {apellido}");
            sb.AppendLine($"Materias: ");
            foreach (string materia in materias)
            {
                sb.AppendLine($" *{materia} ");
            }
            return sb.ToString();
        }

        //private void ValidarNombre(string nombre)
        //{

        //    if (!string.IsNullOrEmpty(nombre))
        //    {
        //        if (nombre.Length>=3)
        //        {
        //            this.nombre = nombre;
                    
        //        }
        //        else
        //        {
        //            throw new FormatoNombreException("El nombre no puede tener menos de 3 chars");
        //        }
        //    }
        //    else
        //    {
        //        throw new NullReferenceException("El nombre no puede ser NULO o VACIO");
        //    }

                
        //}


       



    }


}
