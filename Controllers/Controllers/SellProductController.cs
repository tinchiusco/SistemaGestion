using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellProductController : ControllerBase
    {
        [HttpGet(Name ="GetSellProduct")]
        public IEnumerable<ProductoVendido> SellProducts()
        {
            return SellProductBussiness.GetSellProduct();
        }
        [HttpGet("{id}")]
        public IActionResult GetSellProductById(int id)
        {
            ProductoVendido productoVendido = SellProductBussiness.GetSellProductById(id);
            if (productoVendido == null)
            {
                return NotFound();
            }
            return Ok(productoVendido);
        }
        [HttpDelete(Name = "DeleteSellProduct")]
        public void Delete([FromBody] int id)
        {
            SellProductBussiness.DeleteSellProduct(id);
        }
        [HttpPut(Name = "UpdateSellProduct")]
        public void Put([FromBody] ProductoVendido sellProduct)
        {
            SellProductBussiness.UpdateSellProduct(sellProduct);
        }
        [HttpPost(Name = "CreateSellProduct")]
        public void Post([FromBody] ProductoVendido sellProduct)
        {
            SellProductBussiness.CreateSellProduct(sellProduct);
        }
    }
}
