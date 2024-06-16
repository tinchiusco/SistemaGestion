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
        //Cuidar que los metodos se escriben igual pero vienen de distintas clases
        public static void CreateSell(Venta sell) => SellData.CreateSell(sell);
        public static void DeleteSell(int id) => SellData.DeleteSell(id);
        public static void UpdateSell(Venta sell) => SellData.UpdateSell(sell.Id, sell);
        public static Venta GetSellById(int id) => SellData.GetSellById(id);
        public static List<Venta> GetSells() => SellData.SellList();

    }
}
