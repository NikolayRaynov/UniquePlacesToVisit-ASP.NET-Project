using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel;
using UniquePlacesToVisit.Data.Models;

namespace UniquePlacesToVisit.Data.Configurations
{
    public class AttractionConfiguration : IEntityTypeConfiguration<Attraction>
    {
        public void Configure(EntityTypeBuilder<Attraction> builder)
        {
            builder
                .HasOne(a => a.City)
                .WithMany(a => a.Attractions)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(u => u.User)
                .WithMany(u => u.Attractions)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(u => u.UserId)
                .HasDefaultValue(Guid.Parse("babedf22-6aca-4570-a7fc-23bc05fca770"));

            builder.HasData(SeedAttractions());
        }

        private IEnumerable<Attraction> SeedAttractions()
        {
            List<Attraction> attractions = new List<Attraction>()
            {
                new Attraction
                {
                   Id = 1,
                   Name = "Рилски манастир",
                   Description = "Исторически манастир в югозападна България, известен със своята архитектура и история.Той е ставропигиален манастир на Българската православна църква, сред най-значимите културни паметници в България, символ на страната, включен в Списъка на световното наследство на ЮНЕСКО.",
                   Location = "Рила планина, Благоевградска област",
                   ImagePath = "/images/attractions/rilski-manastir.jpg",
                   CityId = 15,
                   UserId = Guid.Parse("babedf22-6aca-4570-a7fc-23bc05fca770")
                },
                new Attraction
                {
                    Id = 2,
                    Name = "Зоопарк София",
                    Description = "Софийският зоопарк е една от атракциите в София. Той е сред Стоте национални туристически обекта на Българския туристически съюз. Понастоящем в софийската зоологическа градина се отглеждат голям брой екзотични животни, както и много животни, които са характерни за българските земи. ",
                    Location = "София",
                    ImagePath = "/images/attractions/zoo-sofia.jpg",
                    CityId = 1,
                    UserId = Guid.Parse("babedf22-6aca-4570-a7fc-23bc05fca770")
                },
                new Attraction
                {
                    Id = 3,
                    Name = "Деветашка пещера",
                    Description = "Освен с археологическите находки пещерата е известна и с многообразието от обитатели. Заради размножителния период на населяващите пещерата бозайници през юни и юли изцяло се затваря за посетители. Там обитават 12 вида защитени земноводни",
                    Location = "Ловеч",
                    ImagePath = "/images/attractions/devetashka-peshtera.jpg",
                    CityId = 23,
                    UserId = Guid.Parse("babedf22-6aca-4570-a7fc-23bc05fca770")
                },
                new Attraction
                {
                    Id = 4,
                    Name = "Делфинариум Варна",
                    Description = "Разположен е сред зеленината в северната част на варненската Морска градина, с чудесен изглед към морето.\nОткрит е на 19.08.1984 г. и е един от символите не само на Варна, а и на българския туризъм. Делфинариумът е неотменна точка в програмите на всички туристи, посещаващи Черноморието.",
                    Location = "Варна",
                    ImagePath = "/images/attractions/delfinarium-varna.jpg",
                    CityId = 3,
                    UserId = Guid.Parse("babedf22-6aca-4570-a7fc-23bc05fca770")
                }
            };

            return attractions;
        }
    }
}
