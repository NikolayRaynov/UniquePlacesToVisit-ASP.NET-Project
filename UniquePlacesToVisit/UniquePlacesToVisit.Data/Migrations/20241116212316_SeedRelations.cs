using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniquePlacesToVisit.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attractions_ApplicationUsers_UserId",
                table: "Attractions");

            migrationBuilder.DropForeignKey(
                name: "FK_Attractions_Cities_CityId",
                table: "Attractions");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ApplicationUsers_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Reviews_ReviewId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_ApplicationUsers_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Attractions_AttractionId",
                table: "Reviews");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Attractions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("55bc6032-2837-41ec-8cb9-34a4c88cae5b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Attractions_ApplicationUsers_UserId",
                table: "Attractions",
                column: "UserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attractions_Cities_CityId",
                table: "Attractions",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ApplicationUsers_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Reviews_ReviewId",
                table: "Comments",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_ApplicationUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Attractions_AttractionId",
                table: "Reviews",
                column: "AttractionId",
                principalTable: "Attractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attractions_ApplicationUsers_UserId",
                table: "Attractions");

            migrationBuilder.DropForeignKey(
                name: "FK_Attractions_Cities_CityId",
                table: "Attractions");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ApplicationUsers_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Reviews_ReviewId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_ApplicationUsers_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Attractions_AttractionId",
                table: "Reviews");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Attractions",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("55bc6032-2837-41ec-8cb9-34a4c88cae5b"));

            migrationBuilder.AddForeignKey(
                name: "FK_Attractions_ApplicationUsers_UserId",
                table: "Attractions",
                column: "UserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attractions_Cities_CityId",
                table: "Attractions",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ApplicationUsers_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Reviews_ReviewId",
                table: "Comments",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_ApplicationUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Attractions_AttractionId",
                table: "Reviews",
                column: "AttractionId",
                principalTable: "Attractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
