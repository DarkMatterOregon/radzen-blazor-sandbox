using Microsoft.EntityFrameworkCore.Migrations;

namespace RadzenBlazorSandbox.Data.Migrations
{
    public partial class StudentClassRosterSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "81ebae2c-1095-49f5-8eb9-949026cde159", "d3ec0ae1-5642-4afc-818e-1aa9c83c29df", "Admin", "ADMIN" },
                    { "8d81d183-dc89-4028-a665-1d476bd72d76", "0ddb424f-78af-44b4-98d1-e21b06217747", "Educator", "EDUCATOR" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "First Class" });

            migrationBuilder.InsertData(
                table: "Rosters",
                columns: new[] { "Id", "ClassId", "StudentId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Rosters",
                columns: new[] { "Id", "ClassId", "StudentId" },
                values: new object[] { 1, 1, 2 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Adam" },
                    { 2, "Eve" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81ebae2c-1095-49f5-8eb9-949026cde159");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d81d183-dc89-4028-a665-1d476bd72d76");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rosters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Rosters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
