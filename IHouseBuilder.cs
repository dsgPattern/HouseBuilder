namespace HouseBuilder
{
    interface IHouseBuilder
    {
        void AddDoors(int noOfDoors);
        void AddWindows(int noOfWindows);
        void AddRoof();
        void AddAttic(int noOfRooms);
        void AddGarage(int noOfCars);
        void SetupLandscape();
        void AddPool(double size);
        void AddFloors(int noOfFloors);
    }
}
