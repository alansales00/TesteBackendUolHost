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
        public async Task<IActionResult> CadastrarUsuario(Usuario usuario)
        {
            var resposta = await _usuariosServico.CadastrarUsuario(usuario);
            
            return Ok(resposta.Vingadores[0].Codinome);
        }
    }
}
