

namespace TallerDeBicicletasPro.Domain.Entities;

public class Reparacion
{
    public int Id { get; set; }

    public int BicicletaId { get; set; }
    public Bicicleta? Bicicleta { get; set; }

    public int MecanicoId { get; set; }
    public Mecanico? Mecanico { get; set; }

    public DateTime Fecha { get; set; } = DateTime.Now;
    public string Descripcion { get; set; } = string.Empty;

    public decimal Costo { get; set; }
    public string Estado { get; set; } = "Pendiente";
}
