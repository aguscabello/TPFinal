using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Repositorios;

public class RepositorioVehiculo : IRepositorioVehiculo

{
    public void  AgregarVehiculo(Vehiculo vehiculo)
    {
        using (var context = new AseguradoraContext())
        {             
            if ((context.Vehiculos.Where(t => t.Id == vehiculo.Id).SingleOrDefault() == null) ){   
                context.Add(vehiculo);
                context.SaveChanges();
            }
        }
    }

     public List<Vehiculo> ListarVehiculos()
    {
        using (var context = new AseguradoraContext())
        {
           List<Vehiculo> a = context.Vehiculos.ToList();
           return a;
        }     
        
    }

    public void ModificarVehiculo(Vehiculo vehiculo)
    {
        using (var context = new AseguradoraContext())
        {
            var vehiculoN = context.Vehiculos.Where(t => t.Id == vehiculo.Id).SingleOrDefault();
            if (vehiculoN != null)
            {
                 vehiculoN.Dominio = vehiculo.Dominio;
                 vehiculoN.Marca = vehiculo.Marca;
                 vehiculoN.Anio = vehiculo.Anio;
                 vehiculo.TitularId= vehiculo.TitularId;
                 context.SaveChanges();

            }

        }

    }


    public Vehiculo? ObtenerVehiculo(string dominio)
    {
        using (var context = new AseguradoraContext())
        {
            var t = context.Vehiculos.Where(t => t.Dominio == dominio).SingleOrDefault();
            if (t == null){
                return null;
            }
            return t;
        }
       
    }

    public void EliminarVehiculo(int id)
    {
        using (var context = new AseguradoraContext())
        {                         
            var t = context.Vehiculos.Where(t => t.Id == id).SingleOrDefault();
            if (t != null)
            {  
                context.Remove(t);
                context.SaveChanges();
           }

           ///ELIMINAR EN CASCADA

            
        }

    }

   
}