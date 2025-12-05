namespace TallerDeBicicletasPro.Domain.Entities;

public class Cliente
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    // Relación con Bicicletas
    public List<Bicicleta> Bicicletas { get; set; } = new();
}
