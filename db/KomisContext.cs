using System.Data.Entity;

namespace Projekt_IK.db
{
    public class KomisContext : DbContext
    {
        public KomisContext() : base("Komis-DB")
        {
            Database.SetInitializer<KomisContext>(new KomisDbInitializer());

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutoNaSprzedazConfigurations());
        }

        public DbSet<Marka> Marka { get; set; }
        public DbSet<Model> Model { get; set; }
        public DbSet<RokProdukcji> RokProdukcji { get; set; }
        public DbSet<PojemnoscSilnika> PojemnoscSilnika { get; set; }
        public DbSet<RodzajPaliwa> RodzajPaliwa { get; set; }
        public DbSet<RodzajNadwozia> RodzajNadwozia { get; set; }
        public DbSet<KolorNadwozia> KolorNadwozia { get; set; }
        public DbSet<TypSkrzyniBiegow> TypSkrzyniBiegow { get; set; }
        public DbSet<AutoNaSprzedaz> AutoAutoNaSprzedaz { get; set; }
        public DbSet<Uzytkownik> Uzytkownik { get; set; }
    }
}