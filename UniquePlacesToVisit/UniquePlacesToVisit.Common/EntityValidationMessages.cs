using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePlacesToVisit.Common
{
    public static class EntityValidationMessages
    {
        public static class City
        {
            public const string CityNameIsRequired = "City name is required";
        }

        public class Attraction
        {
            public const string AttractionNameIsRequired = "Attraction name is required";
            public const string DescriptionIsRequired = "Description is required";
            public const string LocationIsRequired = "Location is required";
        }
    }
}
