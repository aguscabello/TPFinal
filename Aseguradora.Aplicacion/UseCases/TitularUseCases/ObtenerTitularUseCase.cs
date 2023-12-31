namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ObtenerTitularUseCase
{
       private readonly IRepositorioTitular _mirepo;

    public ObtenerTitularUseCase (IRepositorioTitular mirepo)
    {
        this._mirepo = mirepo;
    }

    public Titular? Ejecutar(int dni)
    {
        return _mirepo.ObtenerTitular(dni);
    }
}