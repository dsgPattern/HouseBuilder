using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilder
{
    class House
    {
        public bool HasRoof { get; set; }
        public int NoOfDoors { get; set; }
        public int NoOfWindows { get; set; }
        public bool HasAttic { get; set; }
        public bool HasGarage => NoOfSupportedCars > 0;
        public int NoOfSupportedCars { get; set; }
        public int NoOfFloors { get; set; }
        public string LandscapeInformation { get; set; }
        public double PoolSize { get; set; }
        public bool HasPool => PoolSize > 0;

        public string PrintHouse()
        {
            var stringBuilder = new StringBuilder("This is a house with:");
            if (!HasRoof)
            {
                stringBuilder.Append(" no roof, ");
            }

            stringBuilder.Append($"{NoOfDoors} doors, {NoOfWindows} windows, ");
            if (NoOfFloors > 0)
            {
                stringBuilder.Append($"{NoOfFloors} floors.");
            }

            if (!string.IsNullOrEmpty(LandscapeInformation))
            {
                stringBuilder.Append(LandscapeInformation + "\n");
            }

            if (HasPool)
            {
                stringBuilder.Append($"The house benefits of a {PoolSize}mp for entertaining and relaxation. \n");
            }

            if (HasAttic)
            {
                stringBuilder.Append("For a nice office space, it comes with an attic.");
            }

            return stringBuilder.ToString();
        }
    }
}
