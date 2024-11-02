using TesteBackendUol.Models;

namespace TesteBackendUol.Services
{
    public interface IAvengersService
    {
        public Task<string> RegisterUser(User usuario);
    }
}
