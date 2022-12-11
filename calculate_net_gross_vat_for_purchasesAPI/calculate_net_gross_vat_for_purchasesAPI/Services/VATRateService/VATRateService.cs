namespace calculate_net_gross_vat_for_purchasesAPI.Services.VATRateService
{
    public class VATRateService : IVATRateService
    {
        private readonly DataContext _context;

        public VATRateService(DataContext context)
        {
            this._context = context;
        }

        public async Task<List<VATRate>> GetAllVATRates()
        {
            var vatRates = await _context.VATRates.ToListAsync();
            return vatRates;
        }

        public async Task<List<VATRate?>> GetVATRatesByCountryId(int id)
        {
            var vatRates = await _context.VATRates.Where(vatRate => id == vatRate.CountryId).ToListAsync();
            if (vatRates is null) return null;

            return vatRates;
        }

    }
}
