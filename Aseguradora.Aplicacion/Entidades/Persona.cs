namespace Aseguradora.Aplicacion.Entidades;

public abstract class Persona
{
    public  int Id {get;set;}
    public string? Apellido {get;set;} = " ";
    public string? Nombre {get;set;} = " ";
    public int? Dni {get;set;}
    public int? Telefono {get;set;}      

    
}