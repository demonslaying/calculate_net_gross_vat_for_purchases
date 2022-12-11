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
                    Name = "France",
                    Initials = "FR"
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
                    Name = "Portugal",
                    Initials = "PT"
                },
                new Country
                {
                    Id = 4,
                    Name = "Spain",
                    Initials = "ES"
                }
                );

            modelBuilder.Entity<VATRate>().HasData(
                new VATRate
                {
                    Id = 1,
                    Rate = 5.5f,
                    CountryId = 1
                },
                new VATRate
                {
                    Id = 2,
                    Rate = 20,
                    CountryId = 1
                },
                new VATRate
                {
                    Id = 3,
                    Rate = 10,
                    CountryId = 1
                },
                new VATRate
                {
                    Id = 4,
                    Rate = 5,
                    CountryId = 2
                },
                new VATRate
                {
                    Id = 5,
                    Rate = 20,
                    CountryId = 2
                },
                new VATRate
                {
                    Id = 6,
                    Rate = 6,
                    CountryId = 3
                },
                new VATRate
                {
                    Id = 7,
                    Rate = 13,
                    CountryId = 3
                },
                new VATRate
                {
                    Id = 8,
                    Rate = 23,
                    CountryId = 3
                },
                new VATRate
                {
                    Id = 9,
                    Rate = 21,
                    CountryId = 4
                },
                new VATRate
                {
                    Id = 10,
                    Rate = 10,
                    CountryId = 4
                }
                );

        }
    }
}
