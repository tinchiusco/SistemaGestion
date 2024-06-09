using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public class SellBussiness
    {
        public static List<Venta> GetSell() {
            return SellData.SellList();
        }
    }
}
