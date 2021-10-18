using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilder
{
    public class BasicHouseBuilder: IHouseBuilder
    {
        private readonly House _house;
        public BasicHouseBuilder()
        {
            _house = new House();
        }

        public void AddDoors(int noOfDoors)
        {
            _house.NoOfDoors = noOfDoors;
        }

        public void AddWindows(int noOfWindows)
        {
            _house.NoOfWindows = noOfWindows;
        }

        public void AddRoof()
        {
            _house.HasRoof = true;
        }

        public void AddAttic(int noOfRooms)
        {
           
        }

        public void AddGarage(int noOfCars)
        {
            
        }

        public void SetupLandscape()
        {
            _house.LandscapeInformation = "Simple house landscape";
        }

        public void AddPool(double size)
        {
           
        }

        public void AddFloors(int noOfFloors)
        {
            
        }

        public string Print3DHouse()
        {
            return _house.PrintHouse();
        }
    }
}
