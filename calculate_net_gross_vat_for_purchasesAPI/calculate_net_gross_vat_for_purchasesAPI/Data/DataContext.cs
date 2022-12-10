namespace calculate_net_gross_vat_for_purchasesAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=countrydb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<VATRate> VATRates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Portugal",
                    Initials = "PT"
                },
                new Country
                {
                    Id = 2,
                    Name = "United Kingdom",
                    Initials = "UK"
                },
                new Country
                {
                    Id = 3,
                    Name = "Spain",
                    Initials = "ES"
                },
                new Country
                {
                    Id = 4,
                    Name = "France",
                    Initials = "FR"
                }
                );

            modelBuilder.Entity<VATRate>().HasData(
               new VATRate
               {
                   Id = 1,
                   Rate = 6,
                   CountryId = 1
               },
               new VATRate
               {
                   Id = 2,
                   Rate = 13,
                   CountryId = 1
               },
               new VATRate
               {
                   Id = 3,
                   Rate = 23,
                   CountryId = 1
               });
       
        }
    }
}
