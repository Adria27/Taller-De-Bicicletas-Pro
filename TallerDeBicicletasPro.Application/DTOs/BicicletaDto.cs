namespace TallerDeBicicletasPro.Application.DTOs
{
    public class BicicletaDto
    {
        public int Id { get; set; }

        // Solo los datos que realmente usas en la UI
        public string Modelo { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public decimal Precio { get; set; }
    }
}
