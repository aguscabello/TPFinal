namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ObtenerPolizaUseCase
    {
    private readonly IRepositorioPoliza _repoPoliza;

    public ObtenerPolizaUseCase (IRepositorioPoliza repoPoliza)
    {
        this._repoPoliza = repoPoliza;
    }

    public Poliza?  Ejecutar(int id)
    {
        return _repoPoliza.ObtenerPoliza(id);
    }
}