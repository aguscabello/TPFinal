namespace Aseguradora.Aplicacion.Entidades;

public class Titular: Persona 
{
    public string? Correo {get;set;}
    public string? Direccion {get;set;}
    public List<Vehiculo>? Vehiculos {get;set;}

    public override string ToString()
    {
        return   $"{Id}: {Nombre} {Apellido} {Dni} {Telefono} {Direccion} {Correo}";
    }

}