using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;



namespace SistemaGestionData
{
    public static class UserData
    {


        public static bool DeleteUser(int userId)
        {

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {

                string query = "DELETE FROM Usuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("id", userId);

                return command.ExecuteNonQuery() > 0;
            }
        }
        public static bool CreateUser(Usuario user)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO Usuario(nombre,apellido,nombreUsuario,contraseña,mail) values(@nombre,@apellido,@nombreUsuario,@contraseña,@mail)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("nombre", user.Name);
                command.Parameters.AddWithValue("apellido", user.LastName);
                command.Parameters.AddWithValue("nombreUsuario", user.UserName);
                command.Parameters.AddWithValue("contraseña", user.Password);
                command.Parameters.AddWithValue("mail", user.Mail);

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }
        public static Usuario GetUserById(int id)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Usuario WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int userId = Convert.ToInt32(reader[0]);
                    string name = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string userName = reader.GetString(3);
                    string password = reader.GetString(4);
                    string mail = reader.GetString(5);

                    Usuario usuario = new Usuario(userId, name, lastName, userName, password, mail);

                    return usuario;
                }
                throw new Exception("Id no fue encontrado");
            }
        }
        public static bool UpdateUser(int id, Usuario usuario)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE Usuario SET nombre = @nombre, apellido = @apellido, nombreUsuario = @nombreUsuario, contraseña = @contraseña, mail = @mail WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("nombre", usuario.Name);
                command.Parameters.AddWithValue("apellido", usuario.LastName);
                command.Parameters.AddWithValue("nombreUsuario", usuario.UserName);
                command.Parameters.AddWithValue("contraseña", usuario.Password);
                command.Parameters.AddWithValue("mail", usuario.Mail);
                //Id que esta en el WHERE
                command.Parameters.AddWithValue("id", id);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static List<Usuario> UserList()
        {
            List<Usuario> userList = new List<Usuario>();
            string query = "SELECT * FROM Usuario";

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Usuario user = new Usuario();
                                user.Id = Convert.ToInt32(dataReader["Id"]);
                                user.Name = dataReader["Nombre"].ToString();
                                user.LastName = dataReader["Apellido"].ToString();
                                user.UserName = dataReader["NombreUsuario"].ToString();
                                user.Password = dataReader["Contraseña"].ToString();
                                user.Mail = dataReader["Mail"].ToString();

                                userList.Add(user);

                            }
                        }
                        
                    }
                }
                return userList;


            }
            catch (Exception ex)
            {
                return userList;
            }
        }
    }
}
