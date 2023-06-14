using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Repositorios.Context;

namespace Aseguradora.Repositorios;
public class AseguradoraInit
{
    public static void Inicializar(AseguradoraContext context)
    {
        if (context.Titulares.Count() > 0) // ya fue inicializada
        {
            return;
        }
        context.Add(new Titular() { Nombre = "Juan", Correo ="juan@gmail.com" });       
        context.SaveChanges();
    }
}