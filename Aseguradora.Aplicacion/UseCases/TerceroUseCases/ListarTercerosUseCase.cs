namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ListarTercerosUseCase
{
       private readonly IRepositorioTercero _repoTercero;

    public ListarTercerosUseCase (IRepositorioTercero repoTercero)
    {
        this._repoTercero = repoTercero;
    }

    public List<Tercero> Ejecutar()
    {
        return _repoTercero.ListarTerceros();
    }
}