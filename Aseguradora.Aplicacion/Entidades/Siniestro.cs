namespace Aseguradora.Aplicacion.Entidades;

public class Siniestro
{
    public int Id {get;set;}
    public int PolizaId{get;set;}
    public DateTime FechaIngreso{get;set;} = new DateTime (2000,1,1);
    public DateTime FechaOcurrencia {get;set;} = new DateTime (2000,1,1);
    public string  Direccion {get;set;} ="";
    public string Descripcion {get;set;} ="";
    
    public List<Tercero>? Terceros {get;set;}

}