using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet(Name = "GetProduct")]
        public IEnumerable<Producto> Products() { 
        return ProductBussiness.GetProducts().ToArray();
        }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            
            Producto producto = ProductBussiness.GetProductById(id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }
        [HttpDelete(Name = "DeleteProduct")]
        public void Delete([FromBody] int id)
        {
            ProductBussiness.DeleteProduct(id);
        }
        [HttpPut(Name = "UpdateProduct")]
        public void Put([FromBody] Producto product)
        {
            ProductBussiness.UpdateProduct(product);
        }
        [HttpPost(Name = "CreateProduct")]
        public void Post([FromBody] Producto product)
        {
            ProductBussiness.CreateSellProduct(product);
        }
    }
}
