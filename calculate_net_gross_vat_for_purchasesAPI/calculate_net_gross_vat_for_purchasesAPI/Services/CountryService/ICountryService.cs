namespace calculate_net_gross_vat_for_purchasesAPI.Services.CountryService
{
    public interface ICountryService
    {
        Task<List<Country>> GetAllCountries();

        Task<Country?> GetCountry(int id);
    }
}
