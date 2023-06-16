namespace Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public interface IRepositorioVehiculo
{   
    void AgregarVehiculo(Vehiculo vehiculo);
    void EliminarVehiculo(int id);
    void ModificarVehiculo(Vehiculo vehiculo);
    List<Vehiculo> ListarVehiculos();
    Vehiculo? ObtenerVehiculo(string dominio);
   
    
}