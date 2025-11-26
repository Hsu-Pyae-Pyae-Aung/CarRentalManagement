using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(8752), new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(8767), new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(8998), new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(9001), new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(9086), new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(9089), new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(9091), new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(9094), new DateTime(2025, 11, 25, 2, 44, 10, 960, DateTimeKind.Local).AddTicks(9095) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(214), new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(230), new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(451), new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(454), new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(543), new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(546), new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(549), new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(551), new DateTime(2025, 11, 25, 2, 42, 50, 681, DateTimeKind.Local).AddTicks(552) });
        }
    }
}
