using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniquePlacesToVisit.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AttractionId", "CreatedAt", "Rating", "ReviewText", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 11, 6, 23, 42, 32, 69, DateTimeKind.Local).AddTicks(3910), 5, "Много красиво място с невероятна история. Малко е встрани от пътя, но пътуването си заслужава!", new Guid("55bc6032-2837-41ec-8cb9-34a4c88cae5b") },
                    { 2, 2, new DateTime(2024, 11, 11, 23, 42, 32, 69, DateTimeKind.Local).AddTicks(4100), 5, "Много голям зоопарк със всякакви животни,които няма в никой друг зоопарк в България.", new Guid("55bc6032-2837-41ec-8cb9-34a4c88cae5b") },
                    { 3, 3, new DateTime(2024, 11, 14, 23, 42, 32, 69, DateTimeKind.Local).AddTicks(4116), 5, "Невероятно красиво място", new Guid("55bc6032-2837-41ec-8cb9-34a4c88cae5b") },
                    { 4, 4, new DateTime(2024, 11, 11, 23, 42, 32, 69, DateTimeKind.Local).AddTicks(4128), 5, "Задължително трябва да се посети", new Guid("55bc6032-2837-41ec-8cb9-34a4c88cae5b") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
