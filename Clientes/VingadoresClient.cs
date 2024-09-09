
namespace TesteBackendUol.Clientes
{
    public class VingadoresClient : IVingadoresClient
    {
        private readonly HttpClient _client;
        public VingadoresClient(HttpClient client)
        {
            _client = client;
            ConfigureCliente();
        }

        private void ConfigureCliente()
        {
            _client.BaseAddress = new Uri("https://raw.githubusercontent.com/uolhost/test-backEnd-Java/master/referencias/vingadores.json");
        }
        public async Task<string> GetCodinomesAsync()
        {
            var response = await _client.GetAsync(_client.BaseAddress);
            return await response.Content.ReadAsStringAsync();
        }

        
    }
}
