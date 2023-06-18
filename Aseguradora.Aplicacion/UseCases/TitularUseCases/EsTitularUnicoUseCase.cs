namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class EsTitularUnicoUseCase
{
       private readonly IRepositorioTitular _mirepo;

    public EsTitularUnicoUseCase (IRepositorioTitular mirepo)
    {
        this._mirepo = mirepo;
    }

    public Titular? Ejecutar(Titular titular)
    {
        return _mirepo.EsTitularUnico(titular);
    }
}