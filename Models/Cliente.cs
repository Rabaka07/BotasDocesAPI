using System.ComponentModel.DataAnnotations;

namespace BotasDocesAPI.Models
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public ICollection<Doce> Doces { get; set; } = new List<Doce>();
    }
}
