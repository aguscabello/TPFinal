namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ObtenerVehiculoUseCase
{
       private readonly IRepositorioVehiculo _mirepo;

    public ObtenerVehiculoUseCase (IRepositorioVehiculo mirepo)
    {
        this._mirepo = mirepo;
    }

    public Vehiculo? Ejecutar(int id)
    {
        return _mirepo.ObtenerVehiculo(id);
    }
}