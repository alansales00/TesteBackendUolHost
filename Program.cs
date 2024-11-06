
using TesteBackendUol.Data;
using TesteBackendUol.Services;
using Microsoft.EntityFrameworkCore;
using TesteBackendUol.Clients;

namespace TesteBackendUol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddHttpClient<AvengersClient>();
            builder.Services.AddHttpClient<JusticeLeagueClient>();

            builder.Services.AddDbContext<ContextoAplicacao>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddControllers();

            builder.Services.AddScoped<IAvengersService, AvengersService>();
            builder.Services.AddScoped<IJusticeLeagueService, JusticeLeagueService>();
            builder.Services.AddScoped<ICommonService, CommonService>();


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
