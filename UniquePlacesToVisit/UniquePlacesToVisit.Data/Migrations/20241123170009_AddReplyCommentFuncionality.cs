using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniquePlacesToVisit.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddReplyCommentFuncionality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentCommentId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ParentCommentId" },
                values: new object[] { new DateTime(2024, 11, 14, 19, 0, 8, 807, DateTimeKind.Local).AddTicks(8430), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ParentCommentId" },
                values: new object[] { new DateTime(2024, 11, 19, 19, 0, 8, 807, DateTimeKind.Local).AddTicks(8514), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ParentCommentId" },
                values: new object[] { new DateTime(2024, 11, 22, 19, 0, 8, 807, DateTimeKind.Local).AddTicks(8522), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ParentCommentId" },
                values: new object[] { new DateTime(2024, 11, 20, 19, 0, 8, 807, DateTimeKind.Local).AddTicks(8529), null });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 13, 19, 0, 8, 808, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 18, 19, 0, 8, 808, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 21, 19, 0, 8, 808, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 18, 19, 0, 8, 808, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ParentCommentId",
                table: "Comments",
                column: "ParentCommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Comments_ParentCommentId",
                table: "Comments",
                column: "ParentCommentId",
                principalTable: "Comments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Comments_ParentCommentId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ParentCommentId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ParentCommentId",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 7, 23, 43, 10, 699, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 12, 23, 43, 10, 699, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 15, 23, 43, 10, 699, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 13, 23, 43, 10, 699, DateTimeKind.Local).AddTicks(2054));

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
    }
}
