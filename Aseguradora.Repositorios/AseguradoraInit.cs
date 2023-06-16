// using Aseguradora.Aplicacion.Entidades;
// using Aseguradora.Repositorios.Context;

// namespace Aseguradora.Repositorios;
// public class AseguradoraInit
// {
//     public static void Inicializar(AseguradoraContext context)
//     {
//         if (context.Titulares.Count() > 0) // ya fue inicializada
//         {
//             return;
//         }
//         context.Add(new Titular() { Nombre = "Juan", Correo ="juan@gmail.com" }); 
//         context.Add(new Titular() { Nombre = "Tobias", Correo ="tobias@gmail.com" });  
//         context.Add(new Titular() { Nombre = "Lara", Correo ="lara@gmail.com" });       
         
//         context.SaveChanges();
//     }
// }