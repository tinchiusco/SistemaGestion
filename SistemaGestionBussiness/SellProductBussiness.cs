using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class SellProductBussiness
    {
        //Cuidar que los metodos se escriben igual pero vienen de distintas clases
        public static void CreateSellProduct(ProductoVendido sellProduct) => SellProductData.CreateSellProduct(sellProduct);
        public static void DeleteSellProduct(int id) => SellProductData.DeleteSellProduct(id);
        public static void UpdateSellProduct(ProductoVendido sellProduct) => SellProductData.UpdateSellProduct(sellProduct.Id, sellProduct);
        public static ProductoVendido GetSellProductById(int id) => SellProductData.GetSellProductById(id);
        public static List<ProductoVendido> GetSellProduct() => SellProductData.SellProductList();
    }
}
