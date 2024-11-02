namespace TesteBackendUol.Clients
{
    public class AvengersClient
    {
        private readonly HttpClient _httpClient;
        public AvengersClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://raw.githubusercontent.com/uolhost/test-backEnd-Java/master/referencias/vingadores.json");
        }

        public async Task<string> GetContent()
        {
            var response = await _httpClient.GetAsync(_httpClient.BaseAddress);
            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }
    }
}
