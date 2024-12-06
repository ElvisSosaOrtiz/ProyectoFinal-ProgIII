using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.AppDbContext;
using RepositoryContracts;
using ServiceContracts;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency injection
//builder.Services
//.AddScoped<IAsignaturaRepository, AsignaturaRepository>()
//.AddScoped<IEstudianteAsignaturaRepository, EstudianteAsignaturaRepository>()

builder.Services.AddDbContext<UniversidadDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IEstudianteRepository, EstudianteRepository>();
builder.Services.AddScoped<IEstudianteService, EstudianteService>();

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
