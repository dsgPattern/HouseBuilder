namespace HouseBuilder
{
    public class MansionHouseBuilder: IHouseBuilder
    {
        private House _house;
        public void StartBuild()
        {
            _house = new House();
            _house.HasRoof = true;
        }

        public void BuildAmenities()
        {
            _house.HasAttic = true;
        }

        public void BuildRooms()
        {
            _house.NoOfDoors = 20;
            _house.NoOfWindows = 25;
        }

        public void BuildOutside()
        {
            _house.PoolSize = 100;
            _house.NoOfSupportedCars = 10;
            _house.LandscapeInformation = "Statui si alte cele";
        }

        public string Print3DHouse()
        {
            return _house.PrintHouse();
        }
    }
}
