namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ListarTitularesUseCase
{
    private readonly IRepositorioTitular _repoTitular;
    public ListarTitularesUseCase(IRepositorioTitular repoTitular)
    {
        this._repoTitular = repoTitular;
    }
    public List<Titular> Ejecutar()
    {
        return _repoTitular.ListarTitulares();
    }
}