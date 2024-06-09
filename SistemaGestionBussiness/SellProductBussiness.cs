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
        public static List<ProductoVendido> GetSellProduct()
        {
            return SellProductData.SellProductList();
        }
    }
}
