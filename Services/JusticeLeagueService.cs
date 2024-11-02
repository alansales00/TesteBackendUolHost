using TesteBackendUol.Clients;
using TesteBackendUol.Models;

namespace TesteBackendUol.Services
{
    public class JusticeLeagueService : IJusticeLeagueService
    {
        private readonly JusticeLeagueClient _client;

        public JusticeLeagueService(JusticeLeagueClient client)
        {
            _client = client;
        }
        public async Task<string> RegisterUser(User usuario) 
        {
            var codinamesString = await _client.GetContent();
            return codinamesString;
        }
    }
}
