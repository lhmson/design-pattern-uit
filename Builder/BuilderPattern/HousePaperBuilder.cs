
using System;

namespace BuilderPattern
{
    public class HousePaperBuilder : IHouseBuilder
    {
        private HousePaper _house;

        public void Reset()
        {
            _house = new HousePaper();
        }

        public HousePaper Build()
        {
            return _house;
        }

        public void AddArea(int area)
        {
            _house.area = area / 100;
        }

        public void AddColor(string color)
        {
            _house.color = color + " pencil ";
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
