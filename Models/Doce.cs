using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BotasDocesAPI.Models
{
    public class Doce
    {
        [Key]
        public Guid Id { get; set; }= Guid.NewGuid();
        public string Nome { get; set; }
        public string Marca { get; set; }
        public decimal Preco { get; set; }

        [ForeignKey("ProdutoId")]
        public Guid ProdutoId { get; set; }
        public Produto? Produto { get; set; }
    }
}
