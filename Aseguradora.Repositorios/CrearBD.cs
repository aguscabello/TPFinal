using Microsoft.EntityFrameworkCore;
using Aseguradora.Repositorios;

public class CrearBD : DbContext
{

    public void Inicializar()
    {
        using (var context = new AseguradoraContext() )
        {
            context.Database.EnsureCreated();
            var connection = context.Database.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "PRAGMA journal_mode=DELETE;";
                command.ExecuteNonQuery();
            }
        
        }

        // using (var context = new AseguradoraContext())
        // {
        //     Console.WriteLine("-- Tabla Titulares --");
        //     foreach (var a in context.Titulares)
        //     {
        //         Console.WriteLine($"{a.Id} {a.Nombre}");
        //     }          

        // }


    }

}


