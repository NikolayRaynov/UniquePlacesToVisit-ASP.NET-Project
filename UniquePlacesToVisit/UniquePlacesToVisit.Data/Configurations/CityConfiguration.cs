using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UniquePlacesToVisit.Data.Models;

namespace UniquePlacesToVisit.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(SeedCities());
        }

        public IEnumerable<City> SeedCities()
        {
            string[] cityNames = {
                "София", "Пловдив", "Варна", "Бургас", "Русе", "Стара Загора", "Плевен",
                "Добрич", "Сливен", "Шумен", "Перник", "Хасково", "Ямбол", "Пазарджик",
                "Благоевград", "Велико Търново", "Габрово", "Видин", "Казанлък", "Кюстендил",
                "Кърджали", "Монтана", "Ловеч", "Разград", "Силистра", "Свищов", "Дупница",
                "Търговище", "Сандански", "Петрич", "Карлово", "Несебър", "Септември", "Поморие", "Балчик"
            };

            List<City> cities = new List<City>();

            for (int i = 0; i < cityNames.Length; i++)
            {
                cities.Add(new City
                {
                    Id = i + 1,
                    Name = cityNames[i]
                });
            }

            return cities;
        }
    }
}
