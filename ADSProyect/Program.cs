using ADSProyect.DB;
using ADSProyect.Interfaces;
using ADSProyect.Models;
using ADSProyect.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Configurando DBContext
builder.Services.AddDbContext<ApplicationDbContext>(opciones => opciones.UseSqlServer("name = DefaultConnection"));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Confugurando inyeccion de dependencias
builder.Services.AddScoped<IEstudiante, EstudianteRepository>();

builder.Services.AddScoped<ICarrera, CarreraRepository>();

builder.Services.AddScoped<IMateria, MateriaRepository>();

builder.Services.AddScoped<IProfesor, ProfesorRepository>();

builder.Services.AddScoped<IGrupo, GrupoRepository>();

// Configurando CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(configuration =>
    {
        configuration.WithOrigins(builder.Configuration["allowedOrigins"]!).AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
