using calculate_net_gross_vat_for_purchasesAPI.Models;

namespace calculate_vatTests
{
    public class CalculateVAT
    {
        [Fact]
        public void calculateWithVATPortugalRate23Test()
        {
            // Arrange
            VATRate rate23 = new VATRate { Rate = 23, CountryId = 3 };

            float priceWithoutVAT = 434.78f;

            // Act
            float tax = (float)Math.Round(priceWithoutVAT * (rate23.Rate / 100),2);
            float priceWithVAT = priceWithoutVAT + tax;

            // Assert
            Assert.Equal(534.78f, priceWithVAT);
        }

        [Fact]
        public void calculateWithoutVATFranceRate10Test()
        {
            // Arrange
            VATRate rate10 = new VATRate { Rate = 10, CountryId = 1 };

            float priceWithVAT = 500f;

            // Act
            float tax = (float)Math.Round(priceWithVAT * (rate10.Rate / 100), 2);
            float priceWithoutVAT = priceWithVAT - tax;

            // Assert
            Assert.Equal(450f, priceWithoutVAT);
        }
    }
}