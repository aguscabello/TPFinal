namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class AgregarSiniestroUseCase
{
    private readonly IRepositorioSiniestro _repoSiniestro;
    public AgregarSiniestroUseCase(IRepositorioSiniestro repoSiniestro)
    {
        this._repoSiniestro = repoSiniestro;
    }
    public void Ejecutar(Siniestro siniestro)
    {
        _repoSiniestro.AgregarSiniestro(siniestro);
    } 
}
