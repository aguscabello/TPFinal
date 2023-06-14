namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

public class AgregarTitularUseCase
{
    private readonly IRepositorioTitular _repoTitular;
    public AgregarTitularUseCase(IRepositorioTitular repoTitular)
    {
        this._repoTitular = repoTitular;
    }
    public void Ejecutar(Titular titular)
    {
        _repoTitular.AgregarTitular(titular);
    } 
}