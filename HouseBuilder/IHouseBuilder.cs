namespace HouseBuilder
{
    public interface IHouseBuilder
    {
        void StartBuild();
        void BuildAmenities();
        void BuildRooms();
        void BuildOutside();



        string Print3DHouse();
    }
}
