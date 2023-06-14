namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

public class ListarVehiculosUseCase
{
    private readonly IRepositorioVehiculo _repoVehiculo;
    public ListarVehiculosUseCase(IRepositorioVehiculo repoVehiculo)
    {
        this._repoVehiculo = repoVehiculo;
    }
    public List<Vehiculo> Ejecutar()
    {
        return _repoVehiculo.ListarVehiculos();

    }
} 