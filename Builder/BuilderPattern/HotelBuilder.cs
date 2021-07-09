
using System;

namespace BuilderPattern
{
    public class HotelBuilder : IHouseBuilder
    {
        private Hotel _house;

        public void Reset()
        {
            _house = new Hotel();
        }

        public Hotel Build()
        {
            return _house;
        }

        public void AddArea(int area)
        {
            _house.area = area;
        }

        public void AddColor(string color)
        {
            _house.color = color;
        }

        public void AddDoors(int number)
        {
            _house.doors = number;
        }

        public void AddWindows(int number)
        {
            _house.windows = number;
        }

        public void AddRoof()
        {
            _house.roof = true;
        }

        public void AddGarage()
        {
            _house.garage = true;
        }

        public void AddSwimPool()
        {
            _house.swimPool = true;
        }

        public void AddGarden()
        {
            _house.garden = true;
        }
    }
}
