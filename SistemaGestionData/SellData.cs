using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public static class SellData
    {

        public static bool DeleteSell(int sellId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM Venta WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("id", sellId);

                return command.ExecuteNonQuery() > 0;
            }
        }
        public static bool CreateSell(Venta sell)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO Venta(Comentarios, IdUsuario) values(@comentarios,@idUsuario)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("comentarios", sell.Commentary);
                command.Parameters.AddWithValue("idUsuario", sell.IdUser);

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
        public static Venta GetSellById(int id)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Venta WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int sellId = Convert.ToInt32(reader[0]);
                    string commentary = reader.GetString(1);
                    int userId = Convert.ToInt32(reader[2]);

                    Venta sell = new Venta(sellId, commentary, userId);
                    return sell;
                }
                throw new Exception("Id no fue encontrado");
            }
        }
        public static bool UpdateSell(int id, Venta sell)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE Venta SET Comentarios = @comentarios,IdUsuario = @idUsuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("Comentarios", sell.Commentary);
                command.Parameters.AddWithValue("idUsuario", sell.IdUser);


                //Id que esta en el WHERE
                command.Parameters.AddWithValue("id", id);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static List<Venta> SellList()
        {
            List<Venta> sellList = new List<Venta>();
            string query = "SELECT * FROM Venta";

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
                                Venta sell = new Venta();
                                sell.Id = Convert.ToInt32(dataReader["Id"]);
                                sell.Commentary = dataReader["Comentarios"].ToString();
                                sell.IdUser = Convert.ToInt32(dataReader["IdUsuario"]);

                                sellList.Add(sell);
                            }
                        }
                    }
                }
                return sellList;
            }
            catch (Exception ex)
            {
                return sellList;
            }
        }
    }
}
