namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class ModificarTerceroUseCase
{
    private readonly IRepositorioTercero _repoTercero;

    public ModificarTerceroUseCase(IRepositorioTercero repoTercero)
    {
        this._repoTercero = repoTercero;
    }

    public void Ejecutar(Tercero tercero)
    {
        _repoTercero.ModificarTercero(tercero);
    }
}