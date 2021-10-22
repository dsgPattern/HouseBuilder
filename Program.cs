using System;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            IHouseBuilder bhb = new BasicHouseBuilder();
            IHouseBuilder mansionHouseBuilder = new MansionHouseBuilder();
            var buildDirector = new HouseBuilderDirector();
            buildDirector.BuildHouse(bhb);
            buildDirector.BuildHouse(mansionHouseBuilder);
            Console.WriteLine(bhb.Print3DHouse());
            Console.WriteLine(mansionHouseBuilder.Print3DHouse());
            
            Console.ReadLine();
        }
    }
}
