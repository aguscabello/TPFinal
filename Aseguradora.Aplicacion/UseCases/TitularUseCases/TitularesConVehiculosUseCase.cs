namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class TitularesConVehiculosUseCase
{
       private readonly IRepositorioTitular _mirepo;

    public TitularesConVehiculosUseCase (IRepositorioTitular mirepo)
    {
        this._mirepo = mirepo;
    }

    public List<Titular>? Ejecutar()
    {
        return _mirepo.TitularesConVehiculos();
    }
}