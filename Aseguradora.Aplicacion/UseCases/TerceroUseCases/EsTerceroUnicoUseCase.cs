using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class EsTerceroUnicoUseCase
{
       private readonly IRepositorioTercero _mirepo;

    public EsTerceroUnicoUseCase (IRepositorioTercero mirepo)
    {
        this._mirepo = mirepo;
    }

    public Boolean Ejecutar(Tercero tercero)
    {
        return _mirepo.EsTerceroUnico(tercero);
    }
}