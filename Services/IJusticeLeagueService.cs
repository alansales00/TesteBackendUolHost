using TesteBackendUol.Models;

namespace TesteBackendUol.Services
{
    public interface IJusticeLeagueService
    {
        public Task<string> RegisterUser(User usuario);
    }
}
