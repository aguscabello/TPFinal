using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Repositorios;

public class RepositorioPoliza : IRepositorioPoliza

{
    public void  AgregarPoliza(Poliza poliza)
    {
        using (var context = new AseguradoraContext())
        {             
            if ((context.Polizas.Where(t => t.Id == poliza.Id).SingleOrDefault() == null) ){   
                context.Add(poliza);
                context.SaveChanges();
            }
        }
    }

     public List<Poliza> ListarPolizas()
    {
        using (var context = new AseguradoraContext())
        {
           List<Poliza> a = context.Polizas.ToList();
           return a;
        }     
        
    }

    public void ModificarPoliza(Poliza poliza)
    {
        using (var context = new AseguradoraContext())
        {
            var polizaN = context.Polizas.Where(t => t.Id == poliza.Id).SingleOrDefault();
            if (polizaN != null)
            {
                 polizaN.VehiculoId = poliza.VehiculoId;
                 polizaN.ValorAsegurado = poliza.ValorAsegurado;
                 polizaN.Franquicia = poliza.Franquicia;
                 poliza.Cobertura = poliza.Cobertura;
                 poliza.FechaInicio = poliza.FechaInicio;
                 poliza.FechaFin = poliza.FechaFin;


                 context.SaveChanges();

            }

        }

    }


    public Poliza? ObtenerPoliza(int id)
    {
        using (var context = new AseguradoraContext())
        {
            var t = context.Polizas.Where(t => t.Id== id).SingleOrDefault();
            if (t == null){
                return null;
            }
            return t;
        }
       
    }

    public Boolean EsPolizaUnica(DateTime inicio, DateTime final, int vehiculoId)
    {
        using (var context = new AseguradoraContext())
        {
            List<Poliza> polizas = context.Polizas.Where(p => p.VehiculoId == vehiculoId).ToList();
            Boolean existeSuperposicion = polizas.Any(poliza =>
            (inicio >= poliza.FechaInicio && inicio <= poliza.FechaFin) ||
            (final >= poliza.FechaInicio && final <= poliza.FechaFin) ||
            (inicio <= poliza.FechaInicio && final >= poliza.FechaFin) );

            return !existeSuperposicion;
            
        }

    }


    

    public void EliminarPoliza(int id)
    {
        using (var context = new AseguradoraContext())
        {                         
            var t = context.Polizas.Where(t => t.Id == id).SingleOrDefault();
            if (t != null)
            {  
                context.Remove(t);
                context.SaveChanges();
           }

           ///ELIMINAR EN CASCADA

            
        }

    }

   
}