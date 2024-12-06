using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Biblioteca_de_Clases
{
    public static class MiClaseSerealizadoraGenerica <T> where T : class
    {

        public static bool EscribirXmlOJson(string path, string nombre, T obj)
        {


            bool exito = true;

            if (!string.IsNullOrEmpty(nombre))
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter($@"{path}\{nombre}",true))
                    {
                        switch (TipoDeArchivo(nombre))   
                        {
                            case "json":
                                string data = JsonSerializer.Serialize(obj);
                                writer.Write(data);
                                break;
                            case "xml":
                                XmlSerializer serializer = new XmlSerializer(typeof(T));
                                serializer.Serialize(writer, obj);
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {

                    exito = false;
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                exito= false;
            }


            return exito;
        }

        public static T LeerArchivoXmlOJson(string path, string nombre)
        {
            T obj = null;
            using (StreamReader reader = new StreamReader($@"{path}\{nombre}"))
            {
                switch (TipoDeArchivo(nombre))
                {
                    case "json":
                        string data = reader.ReadToEnd();
                        obj = JsonSerializer.Deserialize<T>(data);
                        break;
                    case "xml":
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        obj = (T)serializer.Deserialize(reader);
                        break;
                }

            }
            return obj;
        }


        public static string LeerTxt(string path, string nombre)
        {
            string lectura;
            using (StreamReader reader = new StreamReader($@"{path}\{nombre}"))
            {
                lectura= reader.ReadToEnd();
            }
            return lectura;

        }

        //public static T LeerJson(string path, string nombre)
        //{
        //    T obj;
        //    using (StreamReader reader = new StreamReader($@"{path}\{nombre}"))
        //    {
        //        string data = reader.ReadToEnd();
        //        obj = JsonSerializer.Deserialize<T>(data); //Precisa leer los datos del archivo

        //    }
        //    return obj;
        //}

        //public static T LeerXml(string path, string nombre)
        //{
        //    T obj;
        //    using (StreamReader reader = new StreamReader($@"{path}\{nombre}"))
        //    {
        //       XmlSerializer serializer = new XmlSerializer(typeof(T));

        //        obj = serializer.Deserialize(reader) as T;
        //    }
        //    return obj;
        //}

        //public static bool EscribirXml(string path,string nombre, T obj)
        //{
        //    bool exito = true;

        //    try
        //    {
        //        using (StreamWriter writer = new StreamWriter($@"{path}\{nombre}"))
        //        {

        //            XmlSerializer serializer = new XmlSerializer(typeof(T));
        //            serializer.Serialize(writer, obj);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        exito = false;
        //        Console.WriteLine(ex.Message);
        //    }
        //    return exito;
        //}

        //public static bool EscribirJson(string path,string nombre, T obj)
        //{
        //    bool exito = true;

        //    try
        //    {
        //        using (StreamWriter writer = new StreamWriter($@"{path}\{nombre}"))
        //        {
        //            string data = JsonSerializer.Serialize(obj);

        //            writer.Write(data);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        exito = false;
        //        Console.WriteLine(ex.Message);
        //    }
        //    return exito;
        //}

        public static bool EscribirTxt(string path, string nombre,string data)
        {
            bool exito = true;


            try
            {
                using (StreamWriter writer = new StreamWriter($@"{path}\{nombre}",true))
                {


                    writer.WriteLine(data);
                }
            }
            catch (Exception ex)
            {

                exito = false;
                Console.WriteLine(ex.Message);
            }
            return exito;
        }

        //

        private static string TipoDeArchivo(string nombreArchivo)
        {
            string archivo = string.Empty;

            if (nombreArchivo.Contains("json"))
            {
                archivo = "json";
            }
            else if (nombreArchivo.Contains("xml"))
            {
                archivo = "xml";
            }

            return archivo;
        }




    }
}
