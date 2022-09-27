using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedOwn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9db56f17-c41d-460b-a1b7-b24b23e685d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "f54cc069-e05e-47b9-86d5-a95e93e5ffec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11c66d4f-d016-4f94-b7d1-ae0cb0f7e17a", "AQAAAAEAACcQAAAAEAxiMBUxX8NlGeBwxfiIkjU2uPel8cR0Dn0lUtyxQ3qBWqanZPDjyOu9pFmk3kzpTw==", "a7a16fa2-f44a-444d-9197-ab05c6a723bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "021d143f-9dbb-4eae-8a34-1df0acf2d075", "AQAAAAEAACcQAAAAEGi/UGWTa7kABqkQ9MyF0CCDCWXr59030bcynLIn6OiJf98m8thsNhJ2sa5+BN3htQ==", "4b8217ca-02b1-429d-b327-ca12358cddd6" });
        }
    }
}
