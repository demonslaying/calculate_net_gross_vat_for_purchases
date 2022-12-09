namespace calculate_net_gross_vat_for_purchasesAPI.Models
{
    public class VATRate
    {
        public int Id { get; set; }
        public float Rate { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }  = new Country();
    }
}
