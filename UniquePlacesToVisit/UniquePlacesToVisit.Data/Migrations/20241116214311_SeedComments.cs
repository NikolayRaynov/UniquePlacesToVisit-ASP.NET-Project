using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniquePlacesToVisit.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedAt", "ReCommentText", "ReviewId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 7, 23, 43, 10, 699, DateTimeKind.Local).AddTicks(1969), "Съгласен съм, мястото е уникално!", 1, new Guid("6551c87a-71ef-45f5-9f14-dcae5e2868fa") },
                    { 2, new DateTime(2024, 11, 12, 23, 43, 10, 699, DateTimeKind.Local).AddTicks(2041), "Част от животните липсваха.", 2, new Guid("6551c87a-71ef-45f5-9f14-dcae5e2868fa") },
                    { 3, new DateTime(2024, 11, 15, 23, 43, 10, 699, DateTimeKind.Local).AddTicks(2049), "Съгласен съм, мястото е уникално!", 3, new Guid("6551c87a-71ef-45f5-9f14-dcae5e2868fa") },
                    { 4, new DateTime(2024, 11, 13, 23, 43, 10, 699, DateTimeKind.Local).AddTicks(2054), "Съгласен съм, мястото е уникално!", 4, new Guid("6551c87a-71ef-45f5-9f14-dcae5e2868fa") }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 6, 23, 43, 10, 699, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 23, 43, 10, 699, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 43, 10, 699, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 23, 43, 10, 699, DateTimeKind.Local).AddTicks(8173));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 6, 23, 42, 32, 69, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 23, 42, 32, 69, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 42, 32, 69, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 23, 42, 32, 69, DateTimeKind.Local).AddTicks(4128));
        }
    }
}
