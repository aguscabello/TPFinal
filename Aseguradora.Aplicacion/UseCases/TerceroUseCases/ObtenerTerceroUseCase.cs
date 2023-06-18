namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ObtenerTerceroUseCase
{
       private readonly IRepositorioTercero _mirepo;

    public ObtenerTerceroUseCase (IRepositorioTercero mirepo)
    {
        this._mirepo = mirepo;
    }

    public Tercero? Ejecutar(int id)
    {
        return _mirepo.ObtenerTercero(id);
    }
}