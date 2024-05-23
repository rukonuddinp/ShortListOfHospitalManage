using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortListOfHospitalManagement.Migrations
{
    public partial class initialmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_DiseaseInformations_DiseaseFK_Id",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DiseaseFK_Id",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Epilepsy",
                table: "Patients");

            migrationBuilder.AlterColumn<string>(
                name: "PatientName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "EpilepsyVal",
                table: "Patients",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PatientName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EpilepsyVal",
                table: "Patients",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "Epilepsy",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DiseaseFK_Id",
                table: "Patients",
                column: "DiseaseFK_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_DiseaseInformations_DiseaseFK_Id",
                table: "Patients",
                column: "DiseaseFK_Id",
                principalTable: "DiseaseInformations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
