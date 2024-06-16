using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet(Name = "GetUser")]

        public IEnumerable<Usuario> Users()
        {
            return UserBussiness.GetUsers().ToArray();
        }
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            Usuario usuario = UserBussiness.GetUserById(id);
     
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpDelete(Name = "DeleteUser")]
        public void Delete([FromBody] int id) {
            UserBussiness.DeleteUser(id);
        }
        [HttpPut(Name = "UpdateUser")]
        public void Put([FromBody]Usuario user) {
            UserBussiness.UpdateUser(user);
        }
        [HttpPost(Name ="CreateUser")]
        public void Post([FromBody]Usuario user)
        {
            UserBussiness.CreateUser(user);
        }
    }
}
