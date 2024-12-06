using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace _3_Evaluacion_ADO
{
    public static class Clase_ADO
    {
        private static string connectionsString;
        private static MySqlConnection connection;
        private static MySqlCommand command;

        /// <summary>
        /// Se encarga de dar valores a todos los atributos para lograr la conexion a la DB
        /// </summary>
        static Clase_ADO()
        {
            connectionsString = "Server=localhost;Database=evaluacion_ado;Uid=root;Pwd=;";
            connection = new MySqlConnection(connectionsString);
            command = new MySqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        /// <summary>
        /// Recibe un animal y lo guarda en la DB
        /// </summary>
        /// <param name="animal"></param>
        /// <returns>
        /// Retorna true en caso de exito y false en el caso de error 
        /// </returns>
        public static bool GuardarUno(Animal animal)
        {
            bool exito = true;

            try
            {
                string raza = string.Empty;
                string colorDePelo = string.Empty;
                string rol = string.Empty;
                string tamanio = string.Empty;

                if (animal.GetType().Name == typeof(Perro).Name)
                {
                    rol = ((Perro)animal).Rol;
                    tamanio = ((Perro)animal).Tamanio;

                }
                else
                {
                    raza = ((Gato)animal).Raza;
                    colorDePelo = ((Gato)animal).ColorDePelo;

                }

                OpenConnection("INSERT INTO animales ( nombre, edad, vacunas, rol, tamanio, raza, color_de_pelo) VALUES (@nombre, @edad, @vacunas, @rol, @tamanio, @raza, @color_de_pelo)");

                command.Parameters.AddWithValue("@nombre", animal.Nombre);
                command.Parameters.AddWithValue("@edad", animal.Edad);
                command.Parameters.AddWithValue("@vacunas", animal.Vacunas);
                command.Parameters.AddWithValue("@rol", rol);
                command.Parameters.AddWithValue("@tamanio", tamanio);
                command.Parameters.AddWithValue("@raza", raza);
                command.Parameters.AddWithValue("@color_de_pelo", colorDePelo);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                exito = false;
            }

            finally
            {
                CloseConnection();
            }

            return exito;
        }

        /// <summary>
        /// Lee todos los animales de la DB
        /// </summary>
        /// <returns>
        /// Retorna una lista con todos los animales leidos
        /// </returns>
        public static List<Animal> LeerTodos()
        {
            List<Animal> list = new List<Animal>();
            string query = string.Empty;

            try
            {
                query = "SELECT * FROM animales";
                 
                OpenConnection(query);


                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = -1;
                        string rol = string.Empty;
                        string tamanio = string.Empty;  
                        string colorDePelo = string.Empty;
                        string raza = string.Empty;

                        id = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        int edad = reader.GetInt32(2);
                        string vacunas = reader.GetString(3);

                        Animal a = null;


                        if (!reader.IsDBNull(reader.GetOrdinal("rol")))
                        {
                            rol = reader.GetString(4);
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("tamanio")))
                        {
                            tamanio = reader.GetString(5);
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("raza")))
                        {
                            raza = reader.GetString(6);
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("color_de_pelo")))
                        {
                            colorDePelo = reader.GetString(7);
                        }


                        if (string.IsNullOrEmpty(rol) && string.IsNullOrEmpty(tamanio))
                        {
                            a = new Gato(nombre, edad, raza, colorDePelo);                          
                        }
                        else
                        {
                            a = new Perro(nombre, edad, rol, tamanio);
                        }

                        a.Vacunas = vacunas;
                        a.Id = id;
                        list.Add(a);
                    }

                }

            }
            catch (Exception)
            {
                list = null;
            }
            finally
            {
                CloseConnection();
            }
            return list;

        }

        /// <summary>
        /// Recibe un entero que representa el ID y realiza la busqueda en la DB de ese ID
        /// </summary>
        /// <param name="idBuscar">ID a buscar dentro de la DB</param>
        /// <returns>
        /// Retorna el animal encontrado o null en caso de encontrarlo o error
        /// </returns>
        public static Animal LeerUno(int idBuscar)
        {
            Animal a = null;
            string query = string.Empty;

            query = "SELECT * FROM animales WHERE id = @AnimalBuscado";

            


            try
            {

                OpenConnection(query);
                command.Parameters.AddWithValue("@AnimalBuscado", idBuscar);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();

                    string rol = string.Empty;
                    int id = -1;
                    string tamanio = string.Empty;
                    string colorDePelo = string.Empty;
                    string raza = string.Empty;

                    id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    int edad = reader.GetInt32(2);
                    string vacunas = reader.GetString(3);

                    

                    if (!reader.IsDBNull(reader.GetOrdinal("rol")))
                    {
                        rol = reader.GetString(4);
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("tamanio")))
                    {
                        tamanio = reader.GetString(5);
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("raza")))
                    {
                        raza = reader.GetString(6);
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("color_de_pelo")))
                    {
                        colorDePelo = reader.GetString(7);
                    }


                    if (string.IsNullOrEmpty(rol) && string.IsNullOrEmpty(tamanio))
                    {
                        a = new Gato(nombre, edad, raza, colorDePelo);
                    }
                    else
                    {
                        a = new Perro(nombre, edad, rol, tamanio);
                    }

                    a.Vacunas = vacunas;
                    a.Id = id;
                    

                }


            }
            catch (Exception)
            {
                 a = null;
            }
            finally
            {
                CloseConnection();      
            }

            return  a;
        }

        /// <summary>
        /// Recibe un entero que representa el ID, lo busca dentro de la DB y si lo encuentra lo elimina
        /// </summary>
        /// <param name="idEliminar"> ID a eliminar</param>
        /// <returns>
        /// Retorna true en caso de exito y false en caso de error
        /// </returns>
        public static bool EliminarPorId(int idEliminar)
        {
            bool exito = true;

            try
            {
                string query = $"DELETE FROM animales WHERE id = @idBuscada";

                OpenConnection(query);

                command.Parameters.AddWithValue("@idBuscada", idEliminar);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                exito = false;
            }
            finally
            {
                CloseConnection();
            }
            return exito;
        }

        /// <summary>
        /// Recibe un animal con los valores actualizados y los reemplaza en la DB
        /// </summary>
        /// <param name="p">Animal con los nuevos valores </param>
        /// <returns>
        /// Retorna true en caso de exito y false en caso de error
        /// </returns>
        public static bool Actualizar(Animal p)
        {
            bool exito = true;

            try
            {
                string raza = string.Empty;
                string colorDePelo = string.Empty;
                string rol = string.Empty;
                string tamanio = string.Empty;

                if (p.GetType().Name == typeof(Gato).Name)
                {
                    raza = ((Gato)p).Raza;
                    colorDePelo = ((Gato)p).ColorDePelo;
                }
                else
                {
                    tamanio = ((Perro)p).Tamanio;
                    rol = ((Perro)p).Rol;
                }

                string query = "UPDATE animales SET nombre=@nombre,edad=@edad,vacunas=@vacunas,rol=@rol,tamanio=@tamanio,raza=@raza, color_de_pelo=@color_de_pelo WHERE id = @animalModificado";
                
                OpenConnection(query);

                command.Parameters.AddWithValue("@nombre", p.Nombre);
                command.Parameters.AddWithValue("@edad", p.Edad);
                command.Parameters.AddWithValue("@vacunas", p.Vacunas);
                command.Parameters.AddWithValue("@rol", rol);
                command.Parameters.AddWithValue("@tamanio", tamanio);
                command.Parameters.AddWithValue("@raza", raza);
                command.Parameters.AddWithValue("@color_de_pelo", colorDePelo);
                command.Parameters.AddWithValue("@animalModificado", p.Id);

                command.ExecuteNonQuery();




            }
            catch (Exception)
            {
                exito = false;
            }
            finally
            {
                CloseConnection();
            }
            return exito;

        }

        /// <summary>
        /// Recibe un string que representa el valor del rol y elimina todos los registros que coincidan con dicho valor.
        /// </summary>
        /// <param name="rol">Rol que deben ser elinados</param>
        /// <returns>
        /// Retorna true en caso de exito y false en caso de error
        /// </returns>
        public static bool EliminarPorRol(string rol)
        {
            bool result = true;

            try
            {
                string query = $"DELETE FROM animales WHERE rol = @rolBuscado";

                OpenConnection(query);

                command.Parameters.AddWithValue("@rolBuscado", rol);

                command.ExecuteNonQuery();



            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }

        /// <summary>
        /// Recibe un entero que representa el valor de la edad y se encarga de traer todos los registros que coincidad con dicho valor
        /// </summary>
        /// <param name="edad">Edad que deben encontrar coincidencia</param>
        /// <returns>
        /// Retoena una lista con todos los animales encontrado o una lista nula en caso de error
        /// </returns>
        public static List<Animal> LeerPorEdad(int edadBuscada)
        {
            List<Animal> list = new List<Animal>();
            string query = string.Empty;

            try
            {

                query = "SELECT * FROM animales WHERE edad = edadBuscada";

                OpenConnection(query);

                command.Parameters.AddWithValue("@edadBuscada", edadBuscada);

                


                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = -1;
                        string rol = string.Empty;
                        id = reader.GetInt32(0);
                        string tamanio = string.Empty;
                        string colorDePelo = string.Empty;
                        string raza = string.Empty;

                        string nombre = reader.GetString(1);
                        int edad = reader.GetInt32(2);
                        string vacunas = reader.GetString(3);




                        if (!reader.IsDBNull(reader.GetOrdinal("rol")))
                        {
                            rol = reader.GetString(4);
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("tamanio")))
                        {
                            tamanio = reader.GetString(5);
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("raza")))
                        {
                            raza = reader.GetString(6);
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("color_de_pelo")))
                        {
                            colorDePelo = reader.GetString(7);
                        }


                        if (string.IsNullOrEmpty(rol))
                        {
                            Perro p = new Perro(nombre, edad, rol, tamanio);
                            p.Vacunas = vacunas;
                            p.Id = id;  
                            list.Add(p);


                        }
                        else
                        {
                            Gato g = new Gato(nombre, edad, raza, colorDePelo);
                            g.Vacunas = vacunas;
                            g.Id = id;  
                            list.Add(g);
                        }

                    }

                }

            }
            catch (Exception)
            {
                list = null;
            }
            finally
            {
                CloseConnection();
            }
            return list;

        }

        /// <summary>
        /// Se encarga de abrir la conexion a la DB y recibe por parametro la query a ejecutar
        /// </summary>
        /// <param name="query">Query que deber se ejecutada</param>
        private static void OpenConnection(string query)
        {
            

            connection.Open();
            command.CommandText = query;

            command.Parameters.Clear();
        }

        /// <summary>
        /// Se encarga de verificar si la conexion existe y esta abierta, de ser asi, la cierra
        /// </summary>
        private static void CloseConnection()
        {
            if (command.Connection is not null && command.Connection.State == System.Data.ConnectionState.Open)
            {
                command.Connection.Close();
            }
        }

    }
}
