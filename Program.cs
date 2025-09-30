using Microsoft.EntityFrameworkCore;
using PrimerParcialProgra.Data;

var builder = WebApplication.CreateBuilder(args);

// Leer la cadena de conexión (puede venir de appsettings o de Azure)
var conn = builder.Configuration.GetConnectionString("DefaultConnection");

// Fallback: si no hay cadena, usar InMemory para que la app NO se caiga
if (string.IsNullOrWhiteSpace(conn))
{
    builder.Services.AddDbContext<AppDbContext>(opt =>
        opt.UseInMemoryDatabase("PrimerParcialDb"));
    Console.WriteLine("⚠️ Usando InMemoryDatabase porque no se encontró 'DefaultConnection'.");
}
else
{
    builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(conn));
}

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger siempre disponible (lo pide el examen)
app.UseSwagger();
app.UseSwaggerUI();

// Healthcheck
app.MapGet("/ping", () => Results.Ok("pong"));

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();