namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class VerificarCoberturaUseCase
{
       private readonly IRepositorioSiniestro _mirepo;

    public VerificarCoberturaUseCase (IRepositorioSiniestro mirepo)
    {
        this._mirepo = mirepo;
    }

    public Boolean Ejecutar(DateTime ocurrencia, int polizaId)
    {
        return _mirepo.VerificarCobertura(ocurrencia,polizaId);
    }
}