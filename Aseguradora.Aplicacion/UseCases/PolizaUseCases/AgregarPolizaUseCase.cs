namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class AgregarPolizaUseCase
{
    private readonly IRepositorioPoliza _repoPoliza;
    public AgregarPolizaUseCase(IRepositorioPoliza repoPoliza)
    {
        this._repoPoliza = repoPoliza;
    }
    public void Ejecutar(Poliza poliza)
    {
        _repoPoliza.AgregarPoliza(poliza);
    } 
}
