using System.Text;
using System.Xml.Serialization;

namespace _3_Evaluacion_ADO
{
    [XmlInclude(typeof(Perro))]
    [XmlInclude(typeof(Gato))]
    public abstract class Animal
    {
        protected List<string> vacunas;

        public int Id {  get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sonido { get => HacerSonido(); }
        public string Vacunas
        {
            get { return string.Join(", ", vacunas); }
            set { this.vacunas.AddRange(value.Split(", ")); }
        }
        public string Informacion { get => DatosPropios(); }

        public Animal() { }

        public Animal(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
            vacunas = new List<string>();
        }

        protected abstract string HacerSonido();
        protected abstract string DatosPropios();

        
        protected virtual bool Soniguales(object? obj)
        {
            Animal? a = obj as Animal;
            return a is not null && this.Nombre.ToLower() == a.Nombre.ToLower() && this.Edad == a.Edad;
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine($"-----------------  Id: {Id}  ---------------------------------------");
        //    sb.AppendLine($"Nombre: {Nombre} Edad: {Edad}");
        //    sb.AppendLine($"Tipo de Animal: {this.GetType().Name} Sonido: {Sonido}");
        //    sb.AppendLine($"Vacunas: {Vacunas}");
        //    sb.AppendLine(DatosPropios());            

        //    return sb.ToString();
        //}

        public override bool Equals(object? obj)
        {            
            return Soniguales(obj);
        }

    }
}
