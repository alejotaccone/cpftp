using Biblioteca_de_Clases;

namespace Testeo_Estudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try {
                Estudiante e1 = new Estudiante(2018, "pi", "Perez", new List<string>() { "Programacion", "Matematicas", "Ingles" });    

                Console.WriteLine(e1);
            }
            catch (FormatoNombreException ex) {
                Console.WriteLine("Es el catch de FormatoNombreException");
                Console.WriteLine($" Tipo: {ex.GetType().Name} Mensaje: {ex.Message}");
            }
            catch (NullReferenceException ex) { //LO MISMO QUE EL DE ARRIBA
                Console.WriteLine("Es el catch de FormatoNombreException");
                Console.WriteLine($" Tipo: {ex.GetType().Name} Mensaje: {ex.Message}");

            }
            catch (Exception ex) {
                Console.WriteLine("Es el catch de Exception");
                Console.WriteLine($"Tipo: {ex.GetType().Name} Mensaje: {ex.Message}");
            }




            

        }
    }
}
