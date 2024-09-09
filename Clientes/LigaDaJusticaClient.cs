namespace TesteBackendUol.Clientes
{
    public class LigaDaJusticaClient : ILigaDaJusticaClient
    {
        private readonly HttpClient _client;
        public LigaDaJusticaClient(HttpClient client)
        {
            _client = client;
            ConfigureCliente();
        }

        private void ConfigureCliente()
        {
            _client.BaseAddress = new Uri("https://raw.githubusercontent.com/uolhost/test-backEnd-Java/master/referencias/liga_da_justica.xml");
        }
        public async Task<string> GetCodinomesAsync()
        {
            var response = await _client.GetAsync(_client.BaseAddress);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
