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
                 vehiculoN.Dominio = vehiculo.Dominio;
                 vehiculoN.Anio = vehiculo.Anio;
                 vehiculo.TitularId= vehiculo.TitularId;
                 context.SaveChanges();

            }

        }

    }

    public Vehiculo? ObtenerVehiculo(int id)
    {
        using (var context = new AseguradoraContext())
        {
            var v = context.Vehiculos.Where(v => v.Id == id).SingleOrDefault();
            if (v == null){
                return null;
            }
            return v;
        }
       
    }
    public Boolean EsVehiculoUnico(Vehiculo vehiculo)
    {
        using (var context = new AseguradoraContext())
        {
            var v= context.Vehiculos.Where(v => v.Dominio == vehiculo.Dominio).Where(v => v.Id != vehiculo.Id).SingleOrDefault();
            if (v == null){
                return true;
            }
            return false;
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