namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;

public class EliminarSiniestroUseCase
{
    private readonly IRepositorioSiniestro _repoSiniestro;
     public EliminarSiniestroUseCase(IRepositorioSiniestro repoSiniestro)
    {
        this._repoSiniestro = repoSiniestro;
    }
    public void Ejecutar(int id)
    {
        _repoSiniestro.EliminarSiniestro(id);
    } 
}
