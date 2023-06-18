using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Repositorios;

public class RepositorioSiniestro : IRepositorioSiniestro

{
    public void  AgregarSiniestro(Siniestro siniestro)
    {
        using (var context = new AseguradoraContext())
        {             
            if ((context.Siniestros.Where(s => s.Id == siniestro.Id).SingleOrDefault() == null))
            {
                context.Add(siniestro);
                context.SaveChanges();
            }

            
        }
    }  

      public List<Siniestro> ListarSiniestros()
    {
        using (var context = new AseguradoraContext())
        {
           List<Siniestro> a = context.Siniestros.ToList();
           return a;
        }    
        
    }

     public void ModificarSiniestro(Siniestro siniestro)
    {
        using (var context = new AseguradoraContext())
        {
            var siniestroN = context.Siniestros.Where(s => s.Id == siniestro.Id).SingleOrDefault();
            if (siniestroN != null)
            {
                 siniestroN.FechaIngreso =siniestro.FechaIngreso;
                 siniestroN.FechaOcurrencia =siniestro.FechaOcurrencia;
                 siniestroN.Direccion =siniestro.Direccion;
                 siniestroN.Descripcion =siniestro.Descripcion;
                 siniestro.PolizaId=siniestro.PolizaId;
                 context.SaveChanges();

            }

        }

    }

    
    public Siniestro? ObtenerSiniestro(int id)
    {
        using (var context = new AseguradoraContext())
        {
            var s = context.Siniestros.Where(s => s.Id== id).SingleOrDefault();
            if (s == null){
                return null;
            }
            return s;
        }

    }


    public void EliminarSiniestro(int id)
    {
        using (var context = new AseguradoraContext())
        {                         
            var s = context.Siniestros.Where(s => s.Id == id).SingleOrDefault();
            if (s != null)
            {  
                context.Remove(s);
                context.SaveChanges();
            }

           ///ELIMINAR EN CASCADA

            
        }

    }

    public Boolean VerificarCobertura(DateTime ocurrencia, int polizaId)
    {
        using (var context = new AseguradoraContext())
        {
            List<Poliza> polizas = context.Polizas.Where(p => p.Id == polizaId).ToList();
            foreach(Poliza poliza in polizas)
            {
                if (ocurrencia >= poliza.FechaInicio && ocurrencia <= poliza.FechaFin)
                {
                     Poliza? polizaActiva = context.Polizas.Where(p => p.Id == polizaId).SingleOrDefault();
                     if (polizaActiva != null && polizaActiva.Id == poliza.Id)
                        {
                                return true;
                        }
                }
            }
            return false;
         }
    }
   
}
       
    

