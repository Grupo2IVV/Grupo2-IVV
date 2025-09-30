using Microsoft.EntityFrameworkCore;
using PrimerParcialProgra.Data;

var builder = WebApplication.CreateBuilder(args);

// Connection string
var conn = builder.Configuration.GetConnectionString("DefaultConnection")
           ?? throw new InvalidOperationException("Missing connection string 'DefaultConnection'.");

// Services
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(conn));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger SIEMPRE (el examen lo pide accesible en Azure)
app.UseSwagger();
app.UseSwaggerUI();

// Health check simple
app.MapGet("/ping", () => Results.Ok("pong"));

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();