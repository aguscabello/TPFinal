namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ObtenerSiniestroUseCase
{
       private readonly IRepositorioSiniestro _mirepo;

    public ObtenerSiniestroUseCase (IRepositorioSiniestro mirepo)
    {
        this._mirepo = mirepo;
    }

    public Siniestro? Ejecutar(int id)
    {
        return _mirepo.ObtenerSiniestro(id);
    }
}