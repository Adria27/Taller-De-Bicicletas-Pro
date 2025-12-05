

namespace TallerDeBicicletasPro.Domain.Entities;

public class Bicicleta
{
    public int Id { get; set; }
    public string Marca { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public int Año { get; set; }

    // Relación con Cliente
    public int ClienteId { get; set; }
    public Cliente? Cliente { get; set; }

    // Relación con Reparaciones
    public List<Reparacion> Reparaciones { get; set; } = new();
}