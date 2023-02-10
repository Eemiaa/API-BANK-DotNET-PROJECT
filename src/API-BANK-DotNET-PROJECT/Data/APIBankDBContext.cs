using Microsoft.EntityFrameworkCore;
using SharedKernel.Models;

namespace API_BANK_DotNET_PROJECT.Data
{
    public class APIBankDBContext : DbContext
    {
        public APIBankDBContext(DbContextOptions<APIBankDBContext> options) : base(options)
        {
        }

        public DbSet<Contas> Contas { get; set; }
        public DbSet<GiftCard> GiftCards { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<LogAutenticacao> LogsAutenticacao { get; set; }
        public DbSet<LogAutenticacao> LogsTransacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
