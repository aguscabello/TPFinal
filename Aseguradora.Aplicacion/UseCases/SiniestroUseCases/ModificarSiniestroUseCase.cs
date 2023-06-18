namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class ModificarSiniestroUseCase
{
    private readonly IRepositorioSiniestro _repoSiniestro;

    public ModificarSiniestroUseCase(IRepositorioSiniestro repoSiniestro)
    {
        this._repoSiniestro = repoSiniestro;
    }

    public void Ejecutar(Siniestro siniestro)
    {
        _repoSiniestro.ModificarSiniestro(siniestro);
    }
}