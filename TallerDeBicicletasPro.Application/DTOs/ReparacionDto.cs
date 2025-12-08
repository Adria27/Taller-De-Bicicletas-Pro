namespace TallerDeBicicletasPro.Application.DTOs
{
    public class ReparacionDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public decimal Costo { get; set; }
        public int BicicletaId { get; set; }
        public int MecanicoId { get; set; }
    }
}
