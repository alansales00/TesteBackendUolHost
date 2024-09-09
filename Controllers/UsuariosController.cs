using Microsoft.AspNetCore.Mvc;
using TesteBackendUol.Models;
using TesteBackendUol.Servicos;


namespace TesteBackendUol.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuariosServico _usuariosServico;
        
        public UsuariosController(IUsuariosServico usuariosServico)
        {
            _usuariosServico = usuariosServico;
        }

        [HttpGet]
        public async Task<IActionResult> CriarUsuario()
        {
            var resposta = await _usuariosServico.CriarUsuario();
            return Ok(resposta);
        }

        [HttpPost]
        public ActionResult ListarUsuarios()
        {
            return Ok();
        }
    }
}
