using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace My_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addModelLocalUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 29, 15, 59, 56, 633, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 29, 15, 59, 56, 633, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 29, 15, 59, 56, 633, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 29, 15, 59, 56, 633, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 29, 15, 59, 56, 633, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 29, 15, 59, 56, 633, DateTimeKind.Local).AddTicks(5427));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 27, 17, 56, 23, 533, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 27, 17, 56, 23, 533, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 27, 17, 56, 23, 533, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 27, 17, 56, 23, 533, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 27, 17, 56, 23, 533, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 27, 17, 56, 23, 533, DateTimeKind.Local).AddTicks(6138));
        }
    }
}
