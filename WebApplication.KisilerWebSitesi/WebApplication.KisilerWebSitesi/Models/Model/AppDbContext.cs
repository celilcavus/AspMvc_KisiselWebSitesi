using System.Data.Entity;
using WebApplication.KisilerWebSitesi.Models.Entity;

namespace WebApplication.KisilerWebSitesi.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Anasayfa> Anasayfa { get; set; }
        public DbSet<iconlar> iconlar { get; set; }
    }
}