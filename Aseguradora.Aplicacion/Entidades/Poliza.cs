namespace Aseguradora.Aplicacion.Entidades;
public class Poliza
{
    public int Id {get;set;}
    public double? ValorAsegurado{get;set;}
    public string? Franquicia{get;set;}
    //cobertura : civil o todo riesgo
    public string? Cobertura{get;set;}
    public DateTime? FechaInicio{get;set;}
    public DateTime? FechaFin{get;set;}   
    public int? VehiculoId{get;set;}

    public List<Siniestro>? Siniestros {get;set;}


    public override string ToString()
    {
        return  $"{Id}: {ValorAsegurado} {Franquicia} {Cobertura} {FechaInicio} {FechaFin} {VehiculoId}";
    }
}