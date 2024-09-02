using Microsoft.Net.Http.Headers;

namespace TesteBackendUol.Clientes
{
    public class UsuarioClient : IClient
    {
        private readonly HttpClient _client;
        public UsuarioClient(HttpClient client)
        {
            _client = client;
            ConfigureCliente();
        }

        public async Task<string> GetCodinomes()
        {
            var httpReponseMessage = await _client.GetAsync(_client.BaseAddress);
            var response = await httpReponseMessage.Content.ReadAsStringAsync();
            return response;
        }

        private void ConfigureCliente()
        {
            _client.BaseAddress = new Uri("https://raw.githubusercontent.com/uolhost/test-backEnd-Java/master/referencias/vingadores.json");
            _client.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/json");
        }
    }
}
