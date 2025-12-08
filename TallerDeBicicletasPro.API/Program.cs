using Microsoft.EntityFrameworkCore;
using TallerDeBicicletasPro.Persistence.Context;
using TallerDeBicicletasPro.Application.Interfaces.Repositories;
using TallerDeBicicletasPro.Persistence.Repositories;
using TallerDeBicicletasPro.Application.Interfaces.Services;
using TallerDeBicicletasPro.Application.Services;
using TallerDeBicicletasPro.Application.Profiles;

var builder = WebApplication.CreateBuilder(args);

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

// DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Repositories
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IBicicletaRepository, BicicletaRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IMecanicoRepository, MecanicoRepository>();
builder.Services.AddScoped<IReparacionRepository, ReparacionRepository>();

// Services
builder.Services.AddScoped<IBicicletaService, BicicletaService>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IMecanicoService, MecanicoService>();
builder.Services.AddScoped<IReparacionService, ReparacionService>();

// AutoMapper
builder.Services.AddAutoMapper(typeof(TallerProfile).Assembly);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
