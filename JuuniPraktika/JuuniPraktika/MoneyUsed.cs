using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuuniPraktika
{
    class MoneyUsed
    {
        /// <summary>
        /// Identifies the 5 categories that money is used on.
        /// </summary>
        public void Used()
        {
            UsedFood = 0;
            UsedClothes = 0;
            UsedTransport = 0;
            UsedOther = 0;
            UsedBiggies = 0;
        }
        public static double UsedFood { get; set; }
        public static double UsedClothes { get; set; }
        public static double UsedTransport { get; set; }
        public static double UsedOther { get; set; }
        public static double UsedBiggies { get; set; }
    }
}
