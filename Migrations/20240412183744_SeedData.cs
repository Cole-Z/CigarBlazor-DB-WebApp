using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cigars.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cigar",
                table: "Cigar");

            migrationBuilder.RenameTable(
                name: "Cigar",
                newName: "cigar_set");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cigar_set",
                table: "cigar_set",
                column: "Id");

            migrationBuilder.InsertData(
                table: "cigar_set",
                columns: new[] { "Id", "Binder", "Body", "Brand", "Filler", "Name", "Origin", "Price", "Wrapper" },
                values: new object[] { 1, "Nicuraguan", "Full", "Drew Estate", "Nicuraguan", "Liga Privada No. 9", "Nicuraguan", 23.989999999999998, "Maduro Nicuraguan" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_cigar_set",
                table: "cigar_set");

            migrationBuilder.DeleteData(
                table: "cigar_set",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "cigar_set",
                newName: "Cigar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cigar",
                table: "Cigar",
                column: "Id");
        }
    }
}
