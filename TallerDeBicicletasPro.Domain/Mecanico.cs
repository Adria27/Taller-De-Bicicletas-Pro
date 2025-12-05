
namespace TallerDeBicicletasPro.Domain.Entities;

public class Mecanico
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Especialidad { get; set; } = string.Empty;

    // Relación con Reparaciones
    public List<Reparacion> Reparaciones { get; set; } = new();
}
