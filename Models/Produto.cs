using System.ComponentModel.DataAnnotations;

namespace BotasDocesAPI.Models
{
    public class Produto
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Estilo { get; set; }
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
