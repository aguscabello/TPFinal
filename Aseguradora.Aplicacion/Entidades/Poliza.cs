namespace Aseguradora.Aplicacion.Entidades;
public class Poliza
{
    public int Id {get;set;}
    public int VehiculoId{get;set;}
    public double ValorAsegurado{get;set;}
    public string Franquicia{get;set;} ="";


    //cobertura : Responsabilidad Civil o Todo Riesgo
    public string Cobertura{get;set;} ="";
    public DateTime FechaInicio{get;set;} = new DateTime (2000,1,1);
    public DateTime FechaFin{get;set;}  = new DateTime (2000,1,1);
    

    public List<Siniestro>? Siniestros {get;set;}



}