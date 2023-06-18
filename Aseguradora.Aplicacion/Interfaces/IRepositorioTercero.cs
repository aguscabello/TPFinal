namespace Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public interface IRepositorioTercero
{
    void AgregarTercero(Tercero tercero);    
    List<Tercero> ListarTerceros();
    void ModificarTercero(Tercero tercero);
    void EliminarTercero(int id);    
    Tercero? ObtenerTercero(int id);
    Boolean EsTerceroUnico (Tercero tercero);
}