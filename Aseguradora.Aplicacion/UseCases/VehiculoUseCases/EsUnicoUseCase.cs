namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class EsUnicoUseCase
{
       private readonly IRepositorioVehiculo _mirepo;

    public EsUnicoUseCase (IRepositorioVehiculo mirepo)
    {
        this._mirepo = mirepo;
    }

    public Vehiculo? Ejecutar(string dominio)
    {
        return _mirepo.EsUnico(dominio);
    }
}