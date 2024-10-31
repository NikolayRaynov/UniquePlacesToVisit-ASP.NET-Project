using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePlacesToVisit.Common
{
    public static class EntityValidationConstans
    {
        public static class Attraction
        {
            public const int AttractionNameMinLength = 5;
            public const int AttractionNameMaxLength = 80;
            public const int DescriptionMinLenth = 10;
            public const int DescriptionMaxLenth = 500;
            public const int LocationMinLenth = 10;
            public const int LocationMaxLenth = 300;
            public const int MaxImagePathLength = 255;
        }

        public static class City
        {
            public const int CityNameMinLength = 5;
            public const int CityNameMaxLength = 85;
        }

        public static class Comment
        {
            public const int ReCommentTextMinLength = 5;
            public const int ReCommentTextMaxLength = 500;
        }

        public static class Review
        {
            public const int ReviewTextMinLength = 5;
            public const int ReviewTextMaxLength = 500;
        }
    }
}
