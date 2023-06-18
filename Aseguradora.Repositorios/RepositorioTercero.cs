using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Repositorios;

public class RepositorioTercero : IRepositorioTercero

{
    public void  AgregarTercero(Tercero tercero)
    {
        using (var context = new AseguradoraContext())
        {             
            if ((context.Terceros.Where(t => t.Id == tercero.Id).SingleOrDefault() == null) && (context.Terceros.Where(t => t.Dni == tercero.Dni).SingleOrDefault() == null) )
            {
                context.Add(tercero);
                context.SaveChanges();
            }

            
        }
    }  

    public List<Tercero> ListarTerceros()
    {
        using (var context = new AseguradoraContext())
        {
           List<Tercero> a = context.Terceros.ToList();
           return a;
        }    
        
    }

    public void ModificarTercero(Tercero tercero)
    {
        using (var context = new AseguradoraContext())
        {
            var terceroN = context.Terceros.Where(t => t.Id == tercero.Id).SingleOrDefault();
            if (terceroN != null)
            {
                 terceroN.Nombre = tercero.Nombre;
                 terceroN.Apellido = tercero.Apellido;
                 terceroN.NombreAseguradora = tercero.NombreAseguradora;
                 terceroN.Telefono = tercero.Telefono;
                 context.SaveChanges();

            }

        }

    }

    
    public Tercero? ObtenerTercero(int id)
    {
        using (var context = new AseguradoraContext())
        {
            var t = context.Terceros.Where(t => t.Id== id).SingleOrDefault();
            if (t == null){
                return null;
            }
            return t;
        }

    }

    public void EliminarTercero(int id)
    {
        using (var context = new AseguradoraContext())
        
        {         
            var t = context.Terceros.Where(t => t.Id == id).SingleOrDefault();               
            if (t != null)
            {     
                context.Remove(t);        
                context.SaveChanges();
            }
          
        }

    }

    
}


   