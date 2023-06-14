namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;

public class EliminarTitularUseCase
{
       private readonly IRepositorioTitular _mirepo;

    public EliminarTitularUseCase(IRepositorioTitular mirepo)
    {
        this._mirepo = mirepo;
    }

    public void Ejecutar(int dni)
    {
        _mirepo.EliminarTitular(dni);
    }
}