using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public class ProductBussiness
    {
        //Cuidar que los metodos se escriben igual pero vienen de distintas clases
        public static void CreateSellProduct(Producto product) => ProductData.CreateProduct(product);
        public static void DeleteProduct(int id) => ProductData.DeleteProduct(id);
        public static void UpdateProduct(Producto product) => ProductData.UpdateProduct(product.Id, product);
        public static Producto GetProductById(int id) => ProductData.GetProductById(id);
        public static List<Producto> GetProducts() => ProductData.ProductList();
    }
}
