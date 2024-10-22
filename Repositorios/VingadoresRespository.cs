using TesteBackendUol.Models;

namespace TesteBackendUol.Repositorios
{
    //colocar o dbcontext e criar o banco
    public class VingadoresRespository : IRepository
    {
        
        public Task CadastrarUsuario(Usuario usuario, VingadoresLista vingadores) 
        {
            // bool userExists = await _database.KeyExistsAsync(userKey);
            return Task.FromResult(0);
        }
    }
}
