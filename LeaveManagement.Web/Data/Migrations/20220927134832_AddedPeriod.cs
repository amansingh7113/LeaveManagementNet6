using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedPeriod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Period",
                table: "LeaveTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveTypes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "e806858c-c49c-443f-bc32-8d31e3dab2ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "05122632-eac2-4ab1-a4e7-7908ce452e38");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b376a6e3-6d62-4fd0-8847-e14ba3a513c6", "AQAAAAEAACcQAAAAEA9gbJD8gsN5uGLE0gqiRTxw6xqN/+9FtwUniXq7cfFZp4SykTlQs3667QC1ijPeEg==", "19b3263c-889f-40f4-9981-5241e2bbc598" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39d2a41f-8c2d-4976-9fb4-4da4d9bb2ab4", "AQAAAAEAACcQAAAAEGDTyWGXohr3Wk9ardCJifuEtjKgKyfgi6Oo4TV+HKgcQefGh7PnUBy1KiwsUPkefQ==", "7b4c8b78-7370-4a2e-a73b-9b11eaf63557" });
        }
    }
}
