namespace HouseBuilderFluentVariant
{
    public interface IHouseBuilder
    {
        IHouseBuilder BuildAmenities(string amenity);
        IHouseBuilder BuildRooms(int noOfRooms);
        IHouseBuilder BuildOutside(string landscape);

        string Print3DHouse();
    }
}
