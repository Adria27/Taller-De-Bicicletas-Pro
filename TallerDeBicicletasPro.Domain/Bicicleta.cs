namespace TallerDeBicicletasPro.Domain.Entities;

public class Bicicleta
{
    public int Id { get; set; }

    // Campos reales usados en la UI y DTO
    public string Modelo { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public decimal Precio { get; set; }

    // Relaciones (opcional por ahora)
    public List<Reparacion> Reparaciones { get; set; } = new();
}
