namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ObtenerVehiculosUseCase
{
       private readonly IRepositorioVehiculo _mirepo;

    public ObtenerVehiculosUseCase (IRepositorioVehiculo mirepo)
    {
        this._mirepo = mirepo;
    }

    public Vehiculo? Ejecutar(string dominio)
    {
        return _mirepo.ObtenerVehiculo(dominio);
    }
}