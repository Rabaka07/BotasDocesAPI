using Microsoft.EntityFrameworkCore;
using BotasDocesAPI.Models;

namespace BotasDocesAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<BotasDocesAPI.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<BotasDocesAPI.Models.Compra> Compra { get; set; } = default!;
        public DbSet<BotasDocesAPI.Models.Doce> Doce { get; set; } = default!;
        public DbSet<BotasDocesAPI.Models.Produto> Produto { get; set; } = default!;
    }
}
