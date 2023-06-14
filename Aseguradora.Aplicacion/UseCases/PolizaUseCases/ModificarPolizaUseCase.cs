namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ModificarPolizaUseCase
    {
    private readonly IRepositorioPoliza _repoPoliza;

    public ModificarPolizaUseCase (IRepositorioPoliza repoPoliza)
    {
        this._repoPoliza = repoPoliza;
    }

    public void Ejecutar(Poliza poliza)
    {
        _repoPoliza.ModificarPoliza(poliza);
    }
}