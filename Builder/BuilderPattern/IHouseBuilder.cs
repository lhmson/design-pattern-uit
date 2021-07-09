namespace BuilderPattern
{
    public interface IHouseBuilder
    {
        void AddArea(int area);
        void AddColor(string color);
        void AddDoors(int number);
        void AddWindows(int number);
        void AddRoof();
        void AddGarage();
        void AddSwimPool();
        void AddGarden();
        void Reset();
        //House Build();
    }
}
