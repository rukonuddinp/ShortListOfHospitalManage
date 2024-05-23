using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortListOfHospitalManagement.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiseaseInformations",
                columns: new[] { "ID", "DiseaseName" },
                values: new object[,]
                {
                    { 1, "Fever" },
                    { 2, "Chickenpox" },
                    { 3, "COVID-19" },
                    { 4, "Measles" },
                    { 5, "Meningitis" },
                    { 6, "Monkeypox" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiseaseInformations",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiseaseInformations",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiseaseInformations",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiseaseInformations",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiseaseInformations",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiseaseInformations",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
