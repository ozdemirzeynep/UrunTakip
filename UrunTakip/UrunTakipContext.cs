using UrunTakip.Models;
using Microsoft.EntityFrameworkCore;

namespace UrunTakip
{
    class UrunTakipContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            //DB BAĞLANTISI VB DATABASE INSTANCE'INI İLGİLENDİREN İNCE AYARLAR
            dbContextOptionsBuilder.UseSqlServer("Server=localhost;Database=UrunTakip;Integrated Security=True;");
        }

        public DbSet<Product> Products { get; set; }

    }

    
}
