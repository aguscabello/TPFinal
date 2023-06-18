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
                 polizaN.Cobertura = poliza.Cobertura;
                 polizaN.FechaInicio = poliza.FechaInicio;
                 polizaN.FechaFin = poliza.FechaFin;


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

    public Boolean EsPolizaUnica(Poliza poliza)
    {
        using (var context = new AseguradoraContext())
        {
            List<Poliza> polizas = context.Polizas.Where(p => p.VehiculoId == poliza.VehiculoId).Where(p => p.Id != poliza.Id).ToList();
            Boolean existeSuperposicion = polizas.Any(polizaN =>
            (poliza.FechaInicio >= polizaN.FechaInicio && poliza.FechaInicio <= polizaN.FechaFin) ||
            (poliza.FechaFin >= polizaN.FechaInicio && poliza.FechaFin <= polizaN.FechaFin) ||
            (poliza.FechaInicio <= polizaN.FechaInicio && poliza.FechaFin >= polizaN.FechaFin) );

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