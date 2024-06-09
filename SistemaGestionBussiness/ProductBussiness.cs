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
        public static List<Producto> GetProduct() 
        { 
            return ProductData.ProductList(); }
    }
}
