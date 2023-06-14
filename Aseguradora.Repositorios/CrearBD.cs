using Aseguradora.Repositorios.Context;
using Aseguradora.Repositorios;


public class CrearBD
{

    public void Ejecutar()
    {
        using (var context = new AseguradoraContext() )
        {
            context.Database.EnsureCreated();
            AseguradoraInit.Inicializar(context);
        }

        using (var context = new AseguradoraContext())
        {
            Console.WriteLine("-- Tabla Titulares --");
            foreach (var a in context.Titulares)
            {
                Console.WriteLine($"{a.Id} {a.Nombre}");
            }
            

        }
    }

}


