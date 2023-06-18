namespace Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

public interface IRepositorioSiniestro
{
    void AgregarSiniestro(Siniestro siniestro);
    void EliminarSiniestro(int Id);
    List<Siniestro> ListarSiniestros();
    void ModificarSiniestro(Siniestro siniestro);
    Siniestro? ObtenerSiniestro(int id);
    Boolean VerificarCobertura(DateTime ocurrencia, int polizaId);
}