namespace HouseBuilder
{
    public class BasicHouseBuilder: IHouseBuilder
    {
        private House _house;
        public BasicHouseBuilder()
        {
           
        }
        
        public string Print3DHouse()
        {
            return _house.PrintHouse();
        }

        public void StartBuild()
        {
            _house = new House();

        }

        public void BuildAmenities()
        {
        }

        public void BuildRooms()
        {
            _house.NoOfDoors = 10;
            _house.NoOfWindows=20;
        }

        public void BuildOutside()
        {
        }
    }
}
