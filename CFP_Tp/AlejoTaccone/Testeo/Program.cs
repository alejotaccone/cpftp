using _3_Evaluacion_ADO;

namespace Testeo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal animalPrueba=new Perro("Perro de Prueba", 10,"rol","tamanio");

            ///*   Probar el metodo leerTodos  LISTO */
            //List<Animal> animales = Clase_ADO.LeerTodos();

            //if (animales is not null)
            //{

            //    foreach (Animal animal in animales)
            //    {
            //        Console.WriteLine(animal);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error al intetar leer de la DB");
            //}



            /*   Probar el metodo GuardarUno  LISTO  */
            //if (Clase_ADO.GuardarUno(animalPrueba))
            //{
            //    Console.WriteLine("Guardado con éxito");
            //}
            //else
            //{
            //    Console.WriteLine("Error al intentar guardar");
            //}



            /*   Probar el metodo leerUno  Listo  */
            //LEER EL ID 15
            //Animal a = Clase_ADO.LeerUno(57);

            //if (a is not null)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine("Animal no encontrado");
            //}



            ///*   Probar el metodo eliminarPorId  LISTO  */
            // ELIMNAR EL ID 15
            //if (Clase_ADO.EliminarPorId(56))
            //{
            //    Console.WriteLine("Eliminado con exito");
            //}
            //else
            //{
            //    Console.WriteLine("Error al intentar conectarse a la base de datos");
            //}


            /*   Probar el metodo leerUno  Listo  */
            //LEER EL ID 15
            //Animal a = Clase_ADO.LeerUno(57);

            //if (a is not null)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine("Animal no encontrado");
            //}



            /*   Probar el metodo actualizar    */
            Perro p = new Perro("mia", 4, "perro de rescate", "pequeño");
            p.Vacunas = "rabia";


            int id = -1; /*recorrer la lista y obtener el id del animal que coincida con el perro p */

            List<Animal> animales2 = Clase_ADO.LeerTodos();

            foreach (Animal item in animales2)
            {
                if (p.Equals(item))
                {
                    id = item.Id;
                    break;
                }
            }

            p.Id = id;

            if (Clase_ADO.Actualizar(p))
            {
                Console.WriteLine("Actualizado con exito");
            }
            else
            {
                Console.WriteLine("Error al intentar conectarse a la base de datos");
            }



            /*   Probar el metodo leerUno  Listo  */
            //LEER EL ID 15     
            //Animal a = Clase_ADO.LeerUno(57);

            //if (a is not null)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine("Animal no encontrado");
            //}



            /*   Probar el metodo eliminarPorRol LISTO   */
            //ROL Perro de Rescate
            //if (Clase_ADO.EliminarPorRol("Perro de Rescate"))
            //{
            //    Console.WriteLine("Eliminado con exito");
            //}
            //else  
            //{
            //    Console.WriteLine("Error");
            //}



            ///*   Probar el metodo leerPorEdad VER  */
            int edad = 3;
            List<Animal> animales = Clase_ADO.LeerPorEdad(edad);

            if (animales is not null)
            {
                foreach (Animal animal in animales)
                {
                    Console.WriteLine(animal);
                }
            }
            else
            {
                Console.WriteLine("Error al intentar leer por edad");
            }




        }
    }
}
