namespace HouseBuilder
{
    public class HouseBuilderDirector
    {
        //takes care to call methods in a proper order, no matter the builder
        // the builder is responsible for how each step is implemented(built)
        // the director knows the order
        public void BuildHouse(IHouseBuilder houseBuilder)
        {
            houseBuilder.StartBuild();
            houseBuilder.BuildRooms();
            houseBuilder.BuildAmenities();
            houseBuilder.BuildOutside();
        }
    }
}
