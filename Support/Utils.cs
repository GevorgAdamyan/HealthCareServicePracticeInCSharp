using System;
using Bogus;

namespace SeleniumVScode.Support
{
    public class Utils
    {
        private static Faker faker = new Faker();
        private static Random random = new Random();

        public static int GenerateRandomNumber(int min, int max, bool maxInclusive)
        {
            if (maxInclusive)
                return random.Next(min, max + 1);
            else
                return random.Next(min, max);
        }

        public static DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }

        public static string GenerateRandomText()
        {
            return faker.Lorem.Paragraph();
        }

        public static bool GenerateRandomBoolean()
        {
            int ind = random.Next(0, 2);
            switch (ind)
            {
                case 1:
                    return true;
                case 0:
                    return false;
                default:
                    return false;
            }
        }
    }
}
