using Microsoft.EntityFrameworkCore;
using TesteBackendUol.Models;

namespace TesteBackendUol.Data
{
    public class ContextoAplicacao : DbContext
    {

        public ContextoAplicacao(DbContextOptions<ContextoAplicacao> options) : base(options)
        {

        }

        public DbSet<User> Usuarios { get; set; }
    }


}
