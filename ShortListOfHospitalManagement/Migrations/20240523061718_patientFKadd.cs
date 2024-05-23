using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortListOfHospitalManagement.Migrations
{
    public partial class patientFKadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_DiseaseInformations_DiseaseInformationID",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DiseaseInformationID",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Patients",
                newName: "PatientName");

            migrationBuilder.RenameColumn(
                name: "DiseaseInformationID",
                table: "Patients",
                newName: "EpilepsyVal");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_DiseaseInformations_DiseaseFK_Id",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DiseaseFK_Id",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "PatientName",
                table: "Patients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EpilepsyVal",
                table: "Patients",
                newName: "DiseaseInformationID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DiseaseInformationID",
                table: "Patients",
                column: "DiseaseInformationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_DiseaseInformations_DiseaseInformationID",
                table: "Patients",
                column: "DiseaseInformationID",
                principalTable: "DiseaseInformations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
