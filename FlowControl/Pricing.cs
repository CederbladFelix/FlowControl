using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class Pricing
    {
        public const int YouthPrice = 80;
        public const int PensionerPrice = 90;
        public const int StandardPrice = 120;

        public const string YouthName = "Ungdoms";
        public const string PensionerName = "Pensionärs";
        public const string StandardName = "Standard";

        public static int GetPriceByAge(int age)
        {
            if (age < 20) return Pricing.YouthPrice;
            if (age > 64) return Pricing.PensionerPrice;
            return Pricing.StandardPrice;
        }

        public static String GetNameByAge(int age)
        {
            if (age < 20) return Pricing.YouthName;
            if (age > 64) return Pricing.PensionerName;
            return Pricing.StandardName;
        }
    }
}
