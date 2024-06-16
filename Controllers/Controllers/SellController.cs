using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellController : ControllerBase
    {
        [HttpGet(Name = "GetSell")]
        public IEnumerable<Venta> Sells() { 
        return SellBussiness.GetSells().ToArray();
        }
        [HttpGet("{id}")]
        public IActionResult GetSellById(int id)
        {
            
            Venta venta = SellBussiness.GetSellById(id);
            if (venta == null)
            {
                return NotFound();
            }
            
            return Ok(venta);
        }
        [HttpDelete(Name = "DeleteSell")]
        public void Delete([FromBody] int id)
        {
            SellBussiness.DeleteSell(id);
        }
        [HttpPut(Name = "UpdateSell")]
        public void Put([FromBody] Venta sell)
        {
            SellBussiness.UpdateSell(sell);
        }
        [HttpPost(Name = "CreateSell")]
        public void Post([FromBody] Venta sell)
        {
            SellBussiness.CreateSell(sell);
        }
    }
}
