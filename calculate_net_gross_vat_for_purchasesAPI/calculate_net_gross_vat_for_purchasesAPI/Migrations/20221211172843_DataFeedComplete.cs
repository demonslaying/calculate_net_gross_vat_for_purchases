using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace calculatenetgrossvatforpurchasesAPI.Migrations
{
    /// <inheritdoc />
    public partial class DataFeedComplete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Initials", "Name" },
                values: new object[] { "FR", "France" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Initials", "Name" },
                values: new object[] { "PT", "Portugal" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Initials", "Name" },
                values: new object[] { "ES", "Spain" });

            migrationBuilder.UpdateData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Rate",
                value: 5.5f);

            migrationBuilder.UpdateData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Rate",
                value: 20f);

            migrationBuilder.UpdateData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Rate",
                value: 10f);

            migrationBuilder.InsertData(
                table: "VATRates",
                columns: new[] { "Id", "CountryId", "Rate" },
                values: new object[,]
                {
                    { 4, 2, 5f },
                    { 5, 2, 20f },
                    { 6, 3, 6f },
                    { 7, 3, 13f },
                    { 8, 3, 23f },
                    { 9, 4, 21f },
                    { 10, 4, 10f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Initials", "Name" },
                values: new object[] { "PT", "Portugal" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Initials", "Name" },
                values: new object[] { "ES", "Spain" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Initials", "Name" },
                values: new object[] { "FR", "France" });

            migrationBuilder.UpdateData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Rate",
                value: 6f);

            migrationBuilder.UpdateData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Rate",
                value: 13f);

            migrationBuilder.UpdateData(
                table: "VATRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "Rate",
                value: 23f);
        }
    }
}
