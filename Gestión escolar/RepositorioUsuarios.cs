using MySql.Data.MySqlClient;
using System;

namespace Gestión_escolar
{
    public class RepositorioUsuarios
    {
  
        string connectionString = "Server=localhost;Database=escuela;Uid=root;Pwd=Morfito3264352!;";

        public Persona IntentarLogin(string user, string pass, string rolRequerido)
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM Usuarios WHERE usuario = @user AND password = @pass AND rol = @rol";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@pass", pass);
                        cmd.Parameters.AddWithValue("@rol", rolRequerido);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nombreDb = reader["nombre"].ToString();

                              
                                if (rolRequerido == "Docente")
                                    return new Docente { Nombre = nombreDb };

                                if (rolRequerido == "Directivo-Administrativo")
                                    return new Directivo_Administrativo { Nombre = nombreDb };

                                if (rolRequerido == "Estudiante")
                                    return new Estudiante { Nombre = nombreDb };

                                if (rolRequerido == "Auxiliar")
                                    return new Auxiliar { Nombre = nombreDb };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en Login: " + ex.Message);
                }
                return null;
            }
        }
    }
}
