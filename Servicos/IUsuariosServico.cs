using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TesteBackendUol.Models;

namespace TesteBackendUol.Servicos
{
    public interface IUsuariosServico
    {
        Task<string> CadastrarUsuario(Usuario usuario);
    }
}
