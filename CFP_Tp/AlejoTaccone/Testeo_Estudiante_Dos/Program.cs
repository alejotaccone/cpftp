using Biblioteca_de_Clases;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Xml.Serialization;

namespace Testeo_Estudiante_Dos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante(2018, "Lorenzo", "Perez", new List<string>() { "Programacion", "Matematicas", "Ingles" });
            Estudiante e2;

            Auto v1 = new Auto(3500,"Blanco","Ford");
            Auto v2;
            //Environment detecta el sistema operativo del usuario
            //GetFolderPath 
           
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Direccion del escritorio
            
            string nombreFileTxt = "estudiante.txt";
            string nombreFileJson = "estudiante.json";
            string nombreFileXml = "estudiante.xml";


            string fileAutoJson = "autos.json";
            string fileAutoXml = "autos.xml";
            string fileAutoTxt = "autos.txt";

            string pathCompletoTxt = $@"{path}\{nombreFileTxt}";
            string pathCompletoJson = $@"{path}\{nombreFileJson}";
            string pathCompletoXml = $@"{path}\{nombreFileXml}";

            string lectura;
            string lecturaAuto;


            //Console.WriteLine(path +"\\"+ nombreFileTxt); Doble barra para que interprete una direccion de archivo
            //Console.WriteLine($@"{path}\{nombreFileTxt}"); //El @ interpreta que todos son caracteres


            //ARCHIVO XML

            // Estudiante Xml    

            if (MiClaseSerealizadoraGenerica<Estudiante>.EscribirXmlOJson(path,nombreFileXml,e1))
            {
                Console.WriteLine("Estudiante escrito con extio(Xml)");
            }

            e2 = MiClaseSerealizadoraGenerica<Estudiante>.LeerArchivoXmlOJson(path, nombreFileXml);
            Console.WriteLine(e2);

                // Auto Xml

            MiClaseSerealizadoraGenerica<Auto>.EscribirXmlOJson(path, fileAutoXml, v1);

            v2= MiClaseSerealizadoraGenerica<Auto>.LeerArchivoXmlOJson(path, fileAutoXml);

            Console.WriteLine(v2);




            //ARCHIVO JSON

                // Estudiante Json

            if (MiClaseSerealizadoraGenerica<Estudiante>.EscribirXmlOJson(path,nombreFileJson,e1))
            {
                Console.WriteLine("Estudiante escrito con extio (Json)");
            }

            e2 = MiClaseSerealizadoraGenerica<Estudiante>.LeerArchivoXmlOJson(path, nombreFileJson);

            Console.WriteLine(e2);

                // Auto Json
            MiClaseSerealizadoraGenerica<Auto>.EscribirXmlOJson(path, fileAutoJson, v1);

            v2 = MiClaseSerealizadoraGenerica<Auto>.LeerArchivoXmlOJson(path, fileAutoJson);

            Console.WriteLine(v2);

            //ARCHIVO TXT

                // Estudiante Txt

            if (MiClaseSerealizadoraGenerica<Estudiante>.EscribirTxt(path,nombreFileTxt,e1.ToString()))
            {
                Console.WriteLine("Estudiante escrito con extio (Txt)");
            }

            lectura = MiClaseSerealizadoraGenerica<Estudiante>.LeerTxt(path,nombreFileTxt);

            Console.WriteLine(lectura);

                // Auto Txt

            MiClaseSerealizadoraGenerica<Auto>.EscribirTxt(path,fileAutoTxt,v1.ToString());

            lecturaAuto = MiClaseSerealizadoraGenerica<Auto>.LeerTxt(path,fileAutoTxt);

            Console.WriteLine(lecturaAuto);




        }
    }
}
