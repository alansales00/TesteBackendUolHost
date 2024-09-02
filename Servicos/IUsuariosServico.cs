using TesteBackendUol.Models;

namespace TesteBackendUol.Servicos
{
    public interface IUsuariosServico
    {
        public Task<string> CriarUsuario();

        public void ListarUsuarios();
    }
}
