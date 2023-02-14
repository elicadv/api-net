using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sistema_de_tarefas.Models;

namespace sistema_de_tarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]

        public ActionResult<List<UsuarioModel>> BuscarTodosUsuario()
        {
            return Ok();
        }
    }
}
