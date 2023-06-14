namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ModificarTitularUseCase
{
       private readonly IRepositorioTitular _mirepo;

    public ModificarTitularUseCase (IRepositorioTitular mirepo)
    {
        this._mirepo = mirepo;
    }

    public void Ejecutar(Titular titular)
    {
        _mirepo.ModificarTitular(titular);
    }
}