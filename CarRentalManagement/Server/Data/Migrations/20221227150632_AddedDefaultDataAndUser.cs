using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "324cba02-c3cd-4c71-b59f-b145957f3af1", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "a42debb3-959a-4dda-b2b3-f3e04af26ea1", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "46a59707-7b64-47e4-81be-dec63039c38f", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEPuTy3BSQDoRlkmFaIXq+19mJwOMqIlw26RGxK+oVI8PBs4/Hxq05kQWkwBCvfD1cQ==", null, false, "62556313-1b1e-4e36-8777-d8676a0a29c3", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 27, 23, 6, 31, 538, DateTimeKind.Local).AddTicks(3747), new DateTime(2022, 12, 27, 23, 6, 31, 539, DateTimeKind.Local).AddTicks(9849), "Black", "System" },
                    { 2, "System", new DateTime(2022, 12, 27, 23, 6, 31, 540, DateTimeKind.Local).AddTicks(1299), new DateTime(2022, 12, 27, 23, 6, 31, 540, DateTimeKind.Local).AddTicks(1307), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 27, 23, 6, 31, 542, DateTimeKind.Local).AddTicks(2444), new DateTime(2022, 12, 27, 23, 6, 31, 542, DateTimeKind.Local).AddTicks(2473), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 12, 27, 23, 6, 31, 542, DateTimeKind.Local).AddTicks(2528), new DateTime(2022, 12, 27, 23, 6, 31, 542, DateTimeKind.Local).AddTicks(2530), "X5", "System" },
                    { 3, "System", new DateTime(2022, 12, 27, 23, 6, 31, 542, DateTimeKind.Local).AddTicks(2532), new DateTime(2022, 12, 27, 23, 6, 31, 542, DateTimeKind.Local).AddTicks(2535), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 12, 27, 23, 6, 31, 542, DateTimeKind.Local).AddTicks(2537), new DateTime(2022, 12, 27, 23, 6, 31, 542, DateTimeKind.Local).AddTicks(2539), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 27, 23, 6, 31, 542, DateTimeKind.Local).AddTicks(7392), new DateTime(2022, 12, 27, 23, 6, 31, 542, DateTimeKind.Local).AddTicks(7403), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 12, 27, 23, 6, 31, 542, DateTimeKind.Local).AddTicks(7407), new DateTime(2022, 12, 27, 23, 6, 31, 542, DateTimeKind.Local).AddTicks(7409), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

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
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Models",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Makes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Colours",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
