using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "331a1262-db4d-4b23-b14b-ace5a63befb0", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEI0hqowj1iOWIkrPuRmwYq2vTqFk7dYzeM6+AMXT6qqRfOV0oQX3YzYCLom+90iL3A==", null, false, "85302570-fb6c-48f9-8bd7-6758b0463c9b", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4025), new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4060), new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4340), new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4344), new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4465), new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4468), new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4471), new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4474), new DateTime(2025, 11, 26, 12, 35, 3, 615, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7305), new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7323), new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7597), new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7601), new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7699), new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7702), new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7705), new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7707), new DateTime(2025, 11, 26, 11, 41, 21, 433, DateTimeKind.Local).AddTicks(7708) });
        }
    }
}
