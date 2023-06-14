using Microsoft.EntityFrameworkCore;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Repositorios.Context;
public class AseguradoraContext : DbContext
{

    #nullable disable
    public DbSet<Titular> Titulares { get; set; }

    #nullable restore
    protected override void OnConfiguring(DbContextOptionsBuilder
    optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Aseguradora.sqlite");
    }
}