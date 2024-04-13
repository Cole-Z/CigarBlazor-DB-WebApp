using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cigars.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Binder", "Filler", "Origin", "Wrapper" },
                values: new object[] { "Nicaraguan", "Nicaraguan", "Nicaraguan", "Maduro Nicaraguan" });

            migrationBuilder.InsertData(
                table: "cigar_set",
                columns: new[] { "Id", "Binder", "Body", "Brand", "Filler", "Name", "Origin", "Price", "Wrapper" },
                values: new object[,]
                {
                    { 2, "Dominican", "Full", "Arturo Fuente", "Dominican", "OpusX", "Dominican", 29.989999999999998, "Maduro Dominican" },
                    { 3, "Nicaraguan", "Full", "Padron", "Nicaraguan", "1926 Serie", "Nicaraguan", 34.5, "Natural Nicaraguan" },
                    { 4, "Cuban", "Medium-Full", "Cohiba", "Cuban", "Behike", "Cuban", 45.75, "Colorado Cuban" },
                    { 5, "Cuban", "Medium", "Montecristo", "Cuban", "No. 2", "Cuban", 22.75, "Maduro Cuban" },
                    { 6, "Nicaraguan", "Medium", "Rocky Patel", "Nicaraguan", "Vintage 1990", "Nicaraguan", 18.5, "Sumatra" },
                    { 7, "Dominican", "Medium-Full", "Romeo y Julieta", "Dominican", "Churchill", "Dominican", 21.25, "Maduro Dominican" },
                    { 8, "Nicaraguan", "Full", "Oliva", "Nicaraguan", "Serie V", "Nicaraguan", 19.989999999999998, "Sun Grown Nicaraguan" },
                    { 9, "Dominican", "Full", "La Flor Dominicana", "Dominican", "Andalusian Bull", "Dominican", 28.989999999999998, "Colorado Ecuadorian" },
                    { 10, "Nicaraguan", "Full", "Black Works Studio", "Nicaraguan", "Killer Bee", "Nicaraguan", 13.75, "Maduro Ecuadorian" },
                    { 11, "Nicaraguan", "Full", "Black Works Studio", "Nicaraguan", "NBK", "Nicaraguan", 14.5, "San Andres Mexican" },
                    { 12, "Nicaraguan", "Full", "Black Label Trading Company", "Nicaraguan", "Lawless", "Nicaraguan", 11.75, "Pennsylvania Broadleaf" },
                    { 13, "Nicaraguan", "Medium", "Black Works Studio", "Nicaraguan", "Green Hornet", "Nicaraguan", 12.99, "Candela" },
                    { 14, "Nicaraguan", "Medium-Full", "Black Label Trading Company", "Nicaraguan", "Royalty", "Nicaraguan", 10.5, "Connecticut Broadleaf" },
                    { 15, "Nicaraguan", "Full", "Black Label Trading Company", "Nicaraguan", "Bishops Blend", "Nicaraguan", 11.99, "Maduro Nicaraguan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Binder", "Filler", "Origin", "Wrapper" },
                values: new object[] { "Nicuraguan", "Nicuraguan", "Nicuraguan", "Maduro Nicuraguan" });
        }
    }
}
