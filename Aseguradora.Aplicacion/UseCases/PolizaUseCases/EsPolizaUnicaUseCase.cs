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

    public Boolean Ejecutar(Poliza poliza)
    {
        return _repoPoliza.EsPolizaUnica( poliza);
    }
}