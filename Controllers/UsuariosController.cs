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

        [HttpPost]
        public ActionResult CriarUsuario()
        {
            var resposta = _usuariosServico.CriarUsuario();
            return Ok(resposta);
        }

        [HttpGet]
        public ActionResult ListarUsuarios()
        {
            return Ok();
        }
    }
}
