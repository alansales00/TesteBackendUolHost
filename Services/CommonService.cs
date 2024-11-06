using Microsoft.EntityFrameworkCore;
using TesteBackendUol.Data;
using TesteBackendUol.Models;

namespace TesteBackendUol.Services
{
    public class CommonService : ICommonService
    {
        private readonly ContextoAplicacao _contexto;
        public CommonService(ContextoAplicacao contexto) 
        {
            _contexto = contexto;
        }

        public async Task<List<User>> GetAllUsers()
        {
            List<User> users = await _contexto.Usuarios.ToListAsync();
            return users;
        }
        public async Task<string> UpdateUser(int id, User usuario) 
        {
            var user = await _contexto.Usuarios.FindAsync(id);
            user.Nome = usuario.Nome;
            user.Email = usuario.Email;
            user.Telefone = usuario.Telefone;
            _contexto.Usuarios.Update(usuario);
            await _contexto.SaveChangesAsync();
            return "Usuário atualizado";

        }

        public async Task<string> DeleteUser(int id)
        {
            var user = await _contexto.Usuarios.FindAsync(id);
            _contexto.Usuarios.Remove(user);
            await _contexto.SaveChangesAsync();
            return "Usuário Deletado";
        }
    }
}
