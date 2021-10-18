using System;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicHouseBuilder bhb = new BasicHouseBuilder();
            bhb.AddAttic(3);
            bhb.AddDoors(2);
            bhb.AddFloors(1);
            bhb.AddGarage(1);
            bhb.AddWindows(6);
           // bhb.AddRoof();
            bhb.SetupLandscape();

            Console.WriteLine(bhb.Print3DHouse());
            Console.ReadLine();
        }
    }
}
