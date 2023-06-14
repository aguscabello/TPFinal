namespace Aseguradora.Aplicacion.Entidades;


public class Vehiculo
{
    public int Id {get;set;}
    public string? Dominio {get;set;}
    public string? Marca {get;set;}
    public int? Anio {get;set;}
    public int? TitularId {get;set;}   
    //un vehiculo puede tener varias polizas a lo largo del tiempo
    public List<Poliza>? Polizas {get;set;}

    public Vehiculo(string dominio, string marca, int anio, Titular titular)
    {
        Dominio = dominio;
        Marca = marca;
        Anio = anio;
        TitularId = titular.Id;       
    }
    public Vehiculo(){}

    public override string ToString()
    {
        return  $"{Id}: {Dominio} {Marca} {Anio}";
    }

}