using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniquePlacesToVisit.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAttractions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attractions",
                columns: new[] { "Id", "CityId", "Description", "ImagePath", "Location", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, 15, "Исторически манастир в югозападна България, известен със своята архитектура и история.Той е ставропигиален манастир на Българската православна църква, сред най-значимите културни паметници в България, символ на страната, включен в Списъка на световното наследство на ЮНЕСКО.", "/images/attractions/rilski-manastir.jpg", "Рила планина, Благоевградска област", "Рилски манастир", new Guid("55bc6032-2837-41ec-8cb9-34a4c88cae5b") },
                    { 2, 1, "Софийският зоопарк е една от атракциите в София. Той е сред Стоте национални туристически обекта на Българския туристически съюз. Понастоящем в софийската зоологическа градина се отглеждат голям брой екзотични животни, както и много животни, които са характерни за българските земи. ", "/images/attractions/zoo-sofia.jpg", "София", "Зоопарк София", new Guid("55bc6032-2837-41ec-8cb9-34a4c88cae5b") },
                    { 3, 23, "Освен с археологическите находки пещерата е известна и с многообразието от обитатели. Заради размножителния период на населяващите пещерата бозайници през юни и юли изцяло се затваря за посетители. Там обитават 12 вида защитени земноводни", "/images/attractions/devetashka-peshtera.jpg", "Ловеч", "Деветашка пещера", new Guid("55bc6032-2837-41ec-8cb9-34a4c88cae5b") },
                    { 4, 3, "Разположен е сред зеленината в северната част на варненската Морска градина, с чудесен изглед към морето.\nОткрит е на 19.08.1984 г. и е един от символите не само на Варна, а и на българския туризъм. Делфинариумът е неотменна точка в програмите на всички туристи, посещаващи Черноморието.", "/images/attractions/delfinarium-varna.jpg", "Варна", "Делфинариум Варна", new Guid("55bc6032-2837-41ec-8cb9-34a4c88cae5b") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
