using System.Collections.Generic;
using TesteBackendUol.Models;

namespace TesteBackendUol.Servicos
{
    public interface IUsuariosServico
    {
        Task<VingadoresLista> CadastrarUsuario(Usuario usuario);
    }
}
