using TesteBackendUol.Models;

namespace TesteBackendUol.Services
{
    public interface ICommonService
    {
        public Task<List<User>> GetAllUsers();
        public Task<string> UpdateUser(int id, User usuario);
        public Task<string> DeleteUser(int id);
    }
}
