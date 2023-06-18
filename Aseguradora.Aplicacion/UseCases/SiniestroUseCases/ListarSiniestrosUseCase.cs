namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ListarSiniestrosUseCase
{
       private readonly IRepositorioSiniestro _repoSiniestro;

    public ListarSiniestrosUseCase (IRepositorioSiniestro repoSiniestro)
    {
        this._repoSiniestro = repoSiniestro;
    }

    public List<Siniestro> Ejecutar()
    {
        return _repoSiniestro.ListarSiniestros();
    }
}