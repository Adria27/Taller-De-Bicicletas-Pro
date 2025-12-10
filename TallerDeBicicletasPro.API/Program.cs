using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using TallerDeBicicletasPro.Persistence.Context;
using TallerDeBicicletasPro.Application.Interfaces.Repositories;
using TallerDeBicicletasPro.Persistence.Repositories;
using TallerDeBicicletasPro.Application.Interfaces.Services;
using TallerDeBicicletasPro.Application.Services;
using TallerDeBicicletasPro.Application.Mapping.Profiles;

var builder = WebApplication.CreateBuilder(args);

// Habilitar MVC (necesario para Vistas)
builder.Services.AddControllersWithViews();

// Conexión a la BD
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Repositorios
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IBicicletaRepository, BicicletaRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IMecanicoRepository, MecanicoRepository>();
builder.Services.AddScoped<IReparacionRepository, ReparacionRepository>();

// Servicios
builder.Services.AddScoped<IBicicletaService, BicicletaService>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IMecanicoService, MecanicoService>();
builder.Services.AddScoped<IReparacionService, ReparacionService>();

// AutoMapper
builder.Services.AddAutoMapper(typeof(MainProfile));

builder.Services.AddControllers().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger solo en desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles(); // necesario para CSS y JS del frontend
app.UseRouting();

app.MapControllers();

// Ruta por defecto para MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
