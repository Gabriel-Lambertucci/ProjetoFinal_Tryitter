using projetofinal_tryitter.Repository;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Tryitter API",
        Description = "An ASP.NET Core Web API by Gabriel Lambertucci",
    });
});

builder.Services.AddDbContext<TryitterContext>();
builder.Services.AddScoped<ITryitterContext, TryitterContext>();
builder.Services.AddScoped<ITryitterRepository, TryitterRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    }

    );
}

using (var client = new TryitterContext())
      {
        client.Database.EnsureDeleted();
        client.Database.EnsureCreated();
      }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }
