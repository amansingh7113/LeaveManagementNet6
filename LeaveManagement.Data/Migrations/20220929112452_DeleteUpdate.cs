using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class DeleteUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "40d447cc-d717-4c73-8651-33517dbf9169");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "eb94de7a-8574-4a44-9007-67552058def6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68f5c349-c159-490e-ba92-6f07ae9dc81e", "AQAAAAEAACcQAAAAEKAZq3cDms9dMcfHgkvBmo/WpnT60lTSZVDDHyF7kyiJcCL+cUqCwjYurcdOocqaQA==", "8318460e-a642-4761-90e5-46c82982df11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c469d5ee-269b-465a-bfe4-0ed2a1163d99", "AQAAAAEAACcQAAAAEGvZCcwqCai+lCflHQpImb0vIBM3IdCrTQDhnBdL9xp7CmOb3XJ2bFARx6gOvs9fSA==", "bd44f2b6-43ae-45f7-881f-ba1739e79173" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "93dcdbd7-6bec-41d8-ab6d-3227573ebcad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "369f7a54-a17a-48d8-b828-2c34ed580ec5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b188746a-068b-4697-993c-e1b64484aa80", "AQAAAAEAACcQAAAAEJSIbxgEos8G0JbLDPyP65XrIcCVgdiyKVuPdCDvYKV/f0qabXwP4F0nF3BSemks0Q==", "bc08fe68-7edf-4e99-983e-72370db478d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfc91418-3773-4bf8-a43c-865d779ac366", "AQAAAAEAACcQAAAAEC4dAY8M8rFzzxYb44srynen8S1GOZTRUdwYgMRU4PHN68VB1ZG+C+c001sgMxrvKA==", "1d28f7c5-d464-487c-a418-1cffe00cdea0" });
        }
    }
}
