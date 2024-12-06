using _3_Evaluacion_ADO;
using Biblioteca_de_Clases;

namespace Testeto_Animales_Serealizar
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            Perro p1 = new Perro("Anakin", 5, "Caza", "Medio");

            p1.Vacunas = "Vacuna" ; 

            Perro p2;

            //Gato g1 = new Gato("Garfield", 5,"Gato","Marron");
            //Gato g2;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string nombreFileTxt = "animales.txt";
            string nombreFileXml = "animales.xml";
            string nombreFileJson = "animales.json";

            string lecturaPerro;
            string lecturaGato;

            //XML

            MiClaseSerealizadoraGenerica<Perro>.EscribirXmlOJson(path, nombreFileXml, p1);
            p2 = MiClaseSerealizadoraGenerica<Perro>.LeerArchivoXmlOJson(path, nombreFileXml);
            Console.WriteLine("\"" + "------------------Xml------------------");
            Console.WriteLine(p2);


            //Json

            MiClaseSerealizadoraGenerica<Perro>.EscribirXmlOJson(path, nombreFileJson, p1);
            p2 = MiClaseSerealizadoraGenerica<Perro>.LeerArchivoXmlOJson(path, nombreFileJson);
            Console.WriteLine("\""+"------------------Json------------------");
            Console.WriteLine(p2);

            //Txt
            MiClaseSerealizadoraGenerica<Animal>.EscribirTxt(path, nombreFileTxt, p1.ToString());
            lecturaPerro = MiClaseSerealizadoraGenerica<Perro>.LeerTxt(path, nombreFileTxt);
            Console.WriteLine("\"" + "------------------Txt------------------");
            Console.WriteLine(lecturaPerro);
        }
    }
}
