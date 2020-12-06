using Microsoft.EntityFrameworkCore;
using WebApiOdata.Entities;

namespace WebApiOdata.EFContext
{
    public class EFContext : DbContext
    {

        public EFContext(DbContextOptions<EFContext> options)
       : base(options)
        {
        }
        public DbSet<Kullanici> Kullanicis { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder options)
    //=> options.UseSqlite("Data Source=db/EFApp.db");
    }
}