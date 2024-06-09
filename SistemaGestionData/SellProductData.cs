
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{

    public static class SellProductData
    {
        public static bool DeleteSellProduct(int sellProductId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM ProductoVendido WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("id", sellProductId);

                return command.ExecuteNonQuery() > 0;
            }
        }
        public static bool CreateSellProduct(ProductoVendido sellProduct)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO ProductoVendido(Stock, IdProducto,IdVenta) values(@stock,@idProducto,@idVenta)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("stock", sellProduct.Stock);
                command.Parameters.AddWithValue("idProducto", sellProduct.IdProduct);
                command.Parameters.AddWithValue("idVenta", sellProduct.IdSell);


                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }
        public static ProductoVendido GetSellProductById(int id)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM ProductoVendido WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int sellProductId = Convert.ToInt32(reader[0]);
                    int stock = Convert.ToInt32(reader[1]);
                    int productId = Convert.ToInt32(reader[2]);
                    int sellId = Convert.ToInt32(reader[3]);


                    ProductoVendido sellProduct = new ProductoVendido(sellProductId, stock, productId, sellId);

                    return sellProduct;
                }
                throw new Exception("Id no fue encontrado");
            }
        }

        public static bool UpdateSellProduct(int id, ProductoVendido sellProduct)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE ProductoVendido SET Stock = @stock,IdProducto = @idProduct,IdVenta = sellId WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("Stock", sellProduct.Stock);
                command.Parameters.AddWithValue("idProducto", sellProduct.IdProduct);
                command.Parameters.AddWithValue("idVenta", sellProduct.IdSell);

                //Id que esta en el WHERE
                command.Parameters.AddWithValue("id", id);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static List<ProductoVendido> SellProductList()
        {
            List<ProductoVendido> sellProductList = new List<ProductoVendido>();
            string query = "SELECT * FROM ProductoVendido";

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
                                ProductoVendido sellProduct = new ProductoVendido();
                                sellProduct.Id = Convert.ToInt32(dataReader["Id"]);
                                sellProduct.Stock = Convert.ToInt32(dataReader["Stock"]);
                                sellProduct.IdProduct = Convert.ToInt32(dataReader["IdProducto"]);
                                sellProduct.IdSell = Convert.ToInt32(dataReader["IdVenta"]);

                                sellProductList.Add(sellProduct);

                            }
                        }
                    }
                }
                return sellProductList;
            }
            catch (Exception ex)
            {
                return sellProductList;
            }
        }
    }
}


