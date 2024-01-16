

namespace RazorPagesFilmes.Modelo
{
    public class RazorPagesFilmes
    {
        public int ID { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public DateTime DataLancamento { get; set; }

        public string Genero { get; set; } = string.Empty;

        public decimal Preco { get; set; }
    }
    
}