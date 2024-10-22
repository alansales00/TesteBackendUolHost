using TesteBackendUol.Models;

namespace TesteBackendUol.Repositorios
{
    public interface IRepository
    {
        Task CadastrarUsuario(Usuario usuario, VingadoresLista vingadores);
    }
}
