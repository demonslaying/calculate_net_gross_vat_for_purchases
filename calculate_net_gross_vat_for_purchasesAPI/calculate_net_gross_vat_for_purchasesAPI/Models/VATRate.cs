namespace calculate_net_gross_vat_for_purchasesAPI.Models
{
    public class VATRate
    {
        public int Id { get; set; }
        public float Rate { get; set; }
        [Required]
        public virtual Country Country { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
    }
}
