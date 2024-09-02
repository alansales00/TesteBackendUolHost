using TesteBackendUol.Models;
using Newtonsoft.Json;
using System.IO;
using TesteBackendUol.Clientes;


namespace TesteBackendUol.Servicos

{
    public class UsuariosServico : IUsuariosServico
    {
        private readonly IClient _client;

        public UsuariosServico(IClient client)
        {
            _client = client;
        }
        public async Task<string> CriarUsuario() 
        {
            var codinomes = await _client.GetCodinomes();
            return codinomes;
        }

        public void ListarUsuarios() { }


    }
}
