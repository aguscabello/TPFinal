namespace Aseguradora.Aplicacion.Entidades;

public class Siniestro
{
    public int Id {get;set;}
    public int IdPoliza {get;set;}
    public DateTime? FechaIngreso{get;set;}
    public DateTime? FechaOcurrencia {get;set;}
    public string? Direccion {get;set;}
    public string? Descripcion {get;set;}
    

}