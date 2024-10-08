using TesteBackendUol.Clientes;
using TesteBackendUol.Servicos;

namespace TesteBackendUol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
           

            builder.Services.AddControllers();

            builder.Services.AddScoped<IUsuariosServico, UsuariosServico>();

            builder.Services.AddHttpClient<IVingadoresClient, VingadoresClient>();
            builder.Services.AddHttpClient<ILigaDaJusticaClient, LigaDaJusticaClient>();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
