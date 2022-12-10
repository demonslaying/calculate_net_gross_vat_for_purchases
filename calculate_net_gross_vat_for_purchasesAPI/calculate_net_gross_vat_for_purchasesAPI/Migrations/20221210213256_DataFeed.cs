using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace calculatenetgrossvatforpurchasesAPI.Migrations
{
    /// <inheritdoc />
    public partial class DataFeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Initials", "Name" },
                values: new object[,]
                {
                    { 1, "PT", "Portugal" },
                    { 2, "UK", "United Kingdom" },
                    { 3, "ES", "Spain" },
                    { 4, "FR", "France" }
                });

            migrationBuilder.InsertData(
                table: "VATRates",
                columns: new[] { "Id", "CountryId", "Rate" },
                values: new object[,]
                {
                    { 1, 1, 6f },
                    { 2, 1, 13f },
                    { 3, 1, 23f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
