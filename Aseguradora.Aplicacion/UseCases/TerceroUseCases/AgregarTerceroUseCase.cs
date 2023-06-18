namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class AgregarTerceroUseCase
{
    private readonly IRepositorioTercero _repoTercero;
    public AgregarTerceroUseCase(IRepositorioTercero repoTercero)
    {
        this._repoTercero = repoTercero;
    }
    public void Ejecutar(Tercero tercero)
    {
        _repoTercero.AgregarTercero(tercero);
    } 
}
