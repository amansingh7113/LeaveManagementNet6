using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedSRC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "f4c24f10-7bdf-4745-8d81-89ff113a4683");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "1f52651a-bf7e-486b-a1a6-a13802d365e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4ae21c5-c762-4899-af18-3b6acf2b7ef2", "AQAAAAEAACcQAAAAEOmifzWV/ZnRiGRLeNjK9bpIS0dPusm5WXX9aD7NgrJXAmBNK7RBCOJQTpn13OvTrQ==", "c0037e6e-c4b6-4f73-8112-978a89cde3b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef385b43-9d3d-4a34-9b91-86528c931324", "AQAAAAEAACcQAAAAEHYbx9CHYkhmr3Yzr85Nsp+vfaY4s+yZxrVs5ZST3K0thXLIH0vW9XmJdh88f6kUYA==", "7e93b2af-6e6d-47cb-aa60-bc6f81b532ee" });
        }
    }
}
