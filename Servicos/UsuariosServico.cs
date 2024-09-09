using TesteBackendUol.Models;
using Newtonsoft.Json;
using System.IO;
using TesteBackendUol.Clientes;


namespace TesteBackendUol.Servicos

{
    public class UsuariosServico : IUsuariosServico
    {
        private readonly ILigaDaJusticaClient _client;

        public UsuariosServico(ILigaDaJusticaClient client)
        {
            _client = client;
        }
        public async Task<string> CriarUsuario() 
        {
            var codinomes = await _client.GetCodinomesAsync();
            
            return codinomes;
        }

        public void ListarUsuarios() { }


    }
}
