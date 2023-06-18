using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Repositorios;

public class RepositorioTitular : IRepositorioTitular

{
    public void  AgregarTitular(Titular titular)
    {
        using (var context = new AseguradoraContext())
        {             
            if ((context.Titulares.Where(t => t.Id == titular.Id).SingleOrDefault() == null) && (context.Titulares.Where(t => t.Dni == titular.Dni).SingleOrDefault() == null))
            {
                context.Add(titular);
                context.SaveChanges();
            }

            
        }
    }  
    public List<Titular> ListarTitulares()
    {
        using (var context = new AseguradoraContext())
        {
           List<Titular> a = context.Titulares.ToList();
           return a;
        }    
        
    }
    public void ModificarTitular(Titular titular)
    {
        using (var context = new AseguradoraContext())
        {
           
            var titularN = context.Titulares.Where(t => t.Id == titular.Id).SingleOrDefault();
            if (titularN != null)
            {
                
                 titularN.Nombre = titular.Nombre;
                 titularN.Apellido = titular.Apellido;
                 titularN.Dni = titular.Dni;
                 titularN.Correo = titular.Correo;
                 titularN.Direccion= titular.Direccion;
                 titularN.Telefono = titular.Telefono;
                 context.SaveChanges();

            }

        }

    }

    public Titular? ObtenerTitular(int dni)
    {
        using (var context = new AseguradoraContext())
        {      
            var t = context.Titulares.Where(t => t.Dni == dni).SingleOrDefault();
            if (t == null){
                return null;
            }
            return t;
        }
       
    }

        public Titular? EsTitularUnico(Titular titular)
    {
        using (var context = new AseguradoraContext())
        {      
            var t = context.Titulares.Where(t => t.Dni == titular.Dni).Where(t => t.Id != titular.Id).SingleOrDefault();
            if (t == null){
                return null;
            }
            return t;
        }
       
    }
    public void EliminarTitular(int id)
    {
        using (var context = new AseguradoraContext())
        
        {         
            var t = context.Titulares.Where(t => t.Id == id).SingleOrDefault();               
            if (t != null)
            {     
                context.Remove(t);           ///ELIMINAR EN CASCADA     
                context.SaveChanges();
            }
          
        }

    }
}