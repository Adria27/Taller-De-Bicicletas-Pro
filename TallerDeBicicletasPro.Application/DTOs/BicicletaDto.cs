namespace TallerDeBicicletasPro.Application.DTOs
{
    public class BicicletaDto
    {
        public int Id { get; set; }
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public int Ano { get; set; }
        public int ClienteId { get; set; }
    }
}
