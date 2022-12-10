namespace calculate_net_gross_vat_for_purchasesAPI.Services.CountryService
{
    public class CountryService : ICountryService
    {
        private readonly DataContext _context;

        public CountryService(DataContext context)
        {
            this._context = context;
        }

        public async Task<List<Country>> GetAllCountries()
        {
            var countries = await _context.Countries.ToListAsync();
            return countries;
        }

        public async Task<Country?> GetCountry(int id)
        {
            var country = await _context.Countries.FindAsync(id);
            if (country is null) return null;

            return country;
        }
    }
}
