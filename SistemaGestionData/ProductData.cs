
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public static class ProductData
    {
        public static bool DeleteProduct(int productId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM Producto WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("id", productId);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool CreateProduct(Producto product)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario) VALUES (@descripciones, @costo, @precioVenta, @stock, @idUsuario)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("descripciones", product.Description);
                command.Parameters.AddWithValue("costo", product.Cost);
                command.Parameters.AddWithValue("precioVenta", product.SellPrice);
                command.Parameters.AddWithValue("stock", product.Stock);
                command.Parameters.AddWithValue("idUsuario", product.UserId);

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static Producto GetProductById(int id)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Producto WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int idProduct = Convert.ToInt32(reader[0]);
                    string description = reader.GetString(1);
                    double cost = Convert.ToDouble(reader[2]);
                    double sellPrice = Convert.ToDouble(reader[3]);
                    int stock = Convert.ToInt32(reader[4]);
                    int userId = Convert.ToInt32(reader[5]);

                    Producto product = new Producto(idProduct, description, cost, sellPrice, stock, userId);

                    return product;
                }
                throw new Exception("Id no fue encontrado");
            }
        }

        public static bool UpdateProduct(int id, Producto product)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE Producto SET Descripciones = @description, Costo = @cost, PrecioVenta = @sellPrice, Stock = @stock, IdUsuario = @userId WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("description", product.Description);
                command.Parameters.AddWithValue("cost", product.Cost);
                command.Parameters.AddWithValue("sellPrice", product.SellPrice);
                command.Parameters.AddWithValue("stock", product.Stock);
                command.Parameters.AddWithValue("userId", product.UserId);


                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static List<Producto> ProductList()
        {
            List<Producto> productList = new List<Producto>();
            string query = "SELECT * FROM Producto";

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

                                Producto product = new Producto();

                                product.Id = Convert.ToInt32(dataReader["Id"]);
                                product.Description = dataReader["Descripciones"].ToString();
                                product.Cost = Convert.ToDouble(dataReader["Costo"]);
                                product.SellPrice = Convert.ToDouble(dataReader["PrecioVenta"]);
                                product.Stock = Convert.ToInt32(dataReader["Stock"]);
                                product.UserId = Convert.ToInt32(dataReader["IdUsuario"]);

                                productList.Add(product);

                            }
                        }
                    }

                }
                return productList;

            }
            catch (Exception ex)
            {
                return productList;
            }
        }
    }
}


