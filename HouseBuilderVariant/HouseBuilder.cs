using HouseBuilderVariant;

namespace HouseBuilderFluentVariant
{
    public class HouseBuilder: IHouseBuilder
    {
        private House _house = new House();

        public IHouseBuilder BuildAmenities(string amenity)
        {
            //nothing implemented yet
            return this;
        }

        public IHouseBuilder BuildRooms(int noOfRooms)
        {
            _house.NoOfDoors += noOfRooms;
            _house.NoOfWindows += noOfRooms;
            return this;
        }

        public IHouseBuilder BuildOutside(string landscape)
        {
            _house.LandscapeInformation += landscape + " ";
            return this;
        }

        public string Print3DHouse()
        {
            return _house.PrintHouse();
        }
    }
}
