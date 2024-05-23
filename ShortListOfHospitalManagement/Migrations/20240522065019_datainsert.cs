using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortListOfHospitalManagement.Migrations
{
    public partial class datainsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiseaseFK_Id",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DiseaseInformationID",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Epilepsy",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "DiseaseName",
                table: "DiseaseInformations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "ID",
                keyValue: 1,
                column: "AllergyName",
                value: "Drugs-Penicillin");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "ID",
                keyValue: 2,
                column: "AllergyName",
                value: "Drugs-Others");

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "ID", "AllergyName" },
                values: new object[,]
                {
                    { 3, "Animals" },
                    { 4, "Food" },
                    { 5, "Oinments" },
                    { 6, "Plants" },
                    { 7, "Sprays" },
                    { 8, "Other" }
                });

            migrationBuilder.UpdateData(
                table: "NCDs",
                keyColumn: "ID",
                keyValue: 1,
                column: "NCDName",
                value: "Asthma");

            migrationBuilder.UpdateData(
                table: "NCDs",
                keyColumn: "ID",
                keyValue: 2,
                column: "NCDName",
                value: "Cancer");

            migrationBuilder.InsertData(
                table: "NCDs",
                columns: new[] { "ID", "NCDName" },
                values: new object[,]
                {
                    { 3, "Disorder of ear" },
                    { 4, "Disorder of eye" },
                    { 5, "Mental Illness" },
                    { 6, "Oral Health Problem" },
                    { 7, "Hypertension" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_DiseaseInformations_DiseaseInformationID",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DiseaseInformationID",
                table: "Patients");

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NCDs",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NCDs",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NCDs",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NCDs",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NCDs",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "DiseaseFK_Id",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DiseaseInformationID",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Epilepsy",
                table: "Patients");

            migrationBuilder.AlterColumn<string>(
                name: "DiseaseName",
                table: "DiseaseInformations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "ID",
                keyValue: 1,
                column: "AllergyName",
                value: "Peanut");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "ID",
                keyValue: 2,
                column: "AllergyName",
                value: "Shellfish");

            migrationBuilder.UpdateData(
                table: "NCDs",
                keyColumn: "ID",
                keyValue: 1,
                column: "NCDName",
                value: "Diabetes");

            migrationBuilder.UpdateData(
                table: "NCDs",
                keyColumn: "ID",
                keyValue: 2,
                column: "NCDName",
                value: "Hypertension");
        }
    }
}
