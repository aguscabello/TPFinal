namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class EsVehiculoUnicoUseCase
{
       private readonly IRepositorioVehiculo _mirepo;

    public EsVehiculoUnicoUseCase (IRepositorioVehiculo mirepo)
    {
        this._mirepo = mirepo;
    }

    public Boolean Ejecutar(Vehiculo vehiculo)
    {
        return _mirepo.EsVehiculoUnico(vehiculo);
    }
}