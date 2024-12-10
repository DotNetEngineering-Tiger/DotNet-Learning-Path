
using Microsoft.Azure.Cosmos.Fluent;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var configurationSection = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false).Build();

            // Registering CosmosDb
            var cosmosConnectionString = configurationSection["cosmos:connectionString"];
            var client = new CosmosClientBuilder(cosmosConnectionString);
            builder.Services.AddSingleton(client);

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
