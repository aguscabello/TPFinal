using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Repositorios;

public class RepositorioTitular : IRepositorioTitular

{
    public void  AgregarTitular(Titular titular)
    {
        using (var context = new AseguradoraContext())
        {             
            if ((context.Titulares.Where(t => t.Id == titular.Id).SingleOrDefault() == null) && (context.Titulares.Where(t => t.Dni == titular.Dni).SingleOrDefault() == null)){
                context.Add(titular);
                context.SaveChanges();
            }

            
        }
    }  
    public List<Titular> ListarTitulares()
    {
        List<Titular> a = new List<Titular>(); 
        return a;
    }
    public void ModificarTitular(Titular titular){}
    public void EliminarTitular(int id){}
}