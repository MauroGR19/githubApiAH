using AppVenta.Aplicaciones.Servicios;
using AppVenta.Infraestructura.Datos.Contextos;
using AppVenta.Dominio.Interfaces.Repositorio;
using AppVenta.Dominio;
using AppVenta.Infraestructura.Datos.Repositorios;
using AppVenta.Aplicaciones.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddTransient<ProductoContexto>();

//repo
builder.Services.AddTransient<IRepositorioBase<Producto >, ProductoRepositorio>();

//Servicio
builder.Services.AddTransient<IServicioBase<Producto, Guid>, ProductoServicio>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
