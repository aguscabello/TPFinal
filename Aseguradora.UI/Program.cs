using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

using Aseguradora.Repositorios;
using Aseguradora.Aplicacion.UseCases;

using Aseguradora.UI.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


builder.Services.AddTransient<AgregarTitularUseCase>();


var bd = new CrearBD();
bd.Inicializar();


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
