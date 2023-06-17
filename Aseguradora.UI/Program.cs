using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Aseguradora.UI.Data;


using Aseguradora.Repositorios;
using Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;



var builder = WebApplication.CreateBuilder(args);




var bd = new CrearBD();
bd.Inicializar();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();


// DICONTAINTER
builder.Services.AddTransient<AgregarTitularUseCase>();
builder.Services.AddTransient<ListarTitularesUseCase>();
builder.Services.AddTransient<EliminarTitularUseCase>();
builder.Services.AddTransient<ModificarTitularUseCase>();
builder.Services.AddTransient<ObtenerTitularUseCase>();
builder.Services.AddScoped<IRepositorioTitular, RepositorioTitular>();

builder.Services.AddTransient<AgregarVehiculoUseCase>();
builder.Services.AddTransient<ListarVehiculosUseCase>();
builder.Services.AddTransient<EliminarVehiculoUseCase>();
builder.Services.AddTransient<ModificarVehiculoUseCase>();
builder.Services.AddTransient<ObtenerVehiculoUseCase>();
builder.Services.AddTransient<EsUnicoUseCase>();
builder.Services.AddScoped<IRepositorioVehiculo, RepositorioVehiculo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
