namespace calculate_net_gross_vat_for_purchasesAPI.Services.VATRateService
{
    public interface IVATRateService
    {
        Task<List<VATRate>> GetAllVATRates();

        Task<List<VATRate?>> GetVATRatesByCountryId(int id);
    }
}
