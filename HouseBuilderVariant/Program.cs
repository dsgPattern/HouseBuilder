using System;
using HouseBuilderFluentVariant;

namespace HouseBuilderVariant
{
    class Program
    {
        static void Main(string[] args)
        {
            //each call will return the builder and each method can be called multiple times - inside the method there can be a validation if only the first call is executed and the rest are ignored
            // this way, the Client becomes the director, and it has greater flexibility at the cost of a Product not very well constructed - e.g.: you can add multiple "fountains", or maybe too manys
            var houseBuilder = new HouseBuilder()
                .BuildOutside("fountains")
                .BuildOutside("trees")
                .BuildRooms(10)
                .BuildAmenities("grill and terrace");

            Console.WriteLine(houseBuilder.Print3DHouse());

            Console.ReadLine();
        }
    }
}
