
using TesteBackendUol.Servicos;

namespace TesteBackendUol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddHttpClient("vingadores", client =>
            {
                client.BaseAddress = new Uri("https://raw.githubusercontent.com/uolhost/test-backEnd-Java/master/referencias/vingadores.json");
                client.DefaultRequestHeaders.Add("Accept", "application/jason");
            });
           

            builder.Services.AddControllers();

            builder.Services.AddScoped<IUsuariosServico, UsuarioVingadoresServico>();


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
