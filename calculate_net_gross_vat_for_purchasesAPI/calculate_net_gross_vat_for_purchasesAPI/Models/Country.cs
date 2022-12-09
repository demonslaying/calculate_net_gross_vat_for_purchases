namespace calculate_net_gross_vat_for_purchasesAPI.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Initials { get; set; } = string.Empty;
        public virtual List<VATRate> VateRate { get; set; } = new List<VATRate>();
    }
}
