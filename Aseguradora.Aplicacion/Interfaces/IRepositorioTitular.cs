namespace Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public interface IRepositorioTitular
{
    void AgregarTitular(Titular titular);    
    List<Titular> ListarTitulares();
    void ModificarTitular(Titular titular);
    void EliminarTitular(int id);    
    Titular? ObtenerTitular(int dni);

    Boolean EsTitularUnico (Titular titular);

    List<Titular>? TitularesConVehiculos();
}