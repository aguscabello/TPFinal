namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;

public class EliminarTerceroUseCase
{
    private readonly IRepositorioTercero _repoTercero;
     public EliminarTerceroUseCase(IRepositorioTercero repoTercero)
    {
        this._repoTercero = repoTercero;
    }
    public void Ejecutar(int id)
    {
        _repoTercero.EliminarTercero(id);
    } 
}
