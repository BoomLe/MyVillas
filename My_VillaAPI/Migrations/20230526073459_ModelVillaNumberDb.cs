using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace My_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class ModelVillaNumberDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Villas",
                type: "nvarchar(1000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    SpeciaDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 26, 14, 34, 59, 442, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 26, 14, 34, 59, 442, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 26, 14, 34, 59, 442, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 26, 14, 34, 59, 442, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 26, 14, 34, 59, 442, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 26, 14, 34, 59, 442, DateTimeKind.Local).AddTicks(1168));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 25, 12, 8, 52, 840, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 25, 12, 8, 52, 840, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 25, 12, 8, 52, 840, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 25, 12, 8, 52, 840, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 25, 12, 8, 52, 840, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdateDate",
                value: new DateTime(2023, 5, 25, 12, 8, 52, 840, DateTimeKind.Local).AddTicks(9500));
        }
    }
}
