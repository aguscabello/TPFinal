namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class EsPolizaUnicaUseCase
    {
    private readonly IRepositorioPoliza _repoPoliza;

    public EsPolizaUnicaUseCase (IRepositorioPoliza repoPoliza)
    {
        this._repoPoliza = repoPoliza;
    }

    public Boolean Ejecutar(DateTime inicio, DateTime final, int vehiculoId)
    {
        return _repoPoliza.EsPolizaUnica(inicio,final,vehiculoId);
    }
}