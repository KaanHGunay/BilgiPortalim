using System.Data.Entity;

namespace Bilgi.VeriTabani
{
    class Context : DbContext
    {
        public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<SosyalMedya> SosyalMedyalar { get; set; }
        public DbSet<SosyalMedyaHesabi> SosyalMedyaHesaplari { get; set; }
        public DbSet<TelefonNumarasi> TelefonNumaralari { get; set; }
        public DbSet<Bilgi> Bilgiler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kisi>()
                .Property(t => t.DogumTarihi)
                .HasColumnType("datetime2");
        }
    }
}
