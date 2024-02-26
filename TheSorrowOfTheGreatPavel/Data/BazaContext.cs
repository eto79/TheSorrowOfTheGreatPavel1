using Microsoft.EntityFrameworkCore;
using TheSorrowOfTheGreatPavel.Models;
namespace TheSorrowOfTheGreatPavel.Data
{
    public class BazaContext : DbContext
    {
        public BazaContext (DbContextOptions<BazaContext> options) : base(options) {    Database.EnsureCreated(); }
        public DbSet<KyrsListModel> KyrsList { get; set; }
        public DbSet<ProffileModel> Proffile { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<KyrsModel> Kyrs { get; set; }
    }
}
