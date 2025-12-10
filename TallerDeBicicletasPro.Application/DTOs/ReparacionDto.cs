namespace TallerDeBicicletasPro.Application.DTOs
{
    public class ReparacionDto
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public decimal Costo { get; set; }

        public DateTime FechaEntrada { get; set; }

        public DateTime? FechaSalida { get; set; }

        public int BicicletaId { get; set; }
        public int MecanicoId { get; set; }

        // 🔥 IMPORTANTE
        public string Estado { get; set; } = "Pendiente";
    }
}
