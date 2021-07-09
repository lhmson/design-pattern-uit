namespace BuilderPattern
{
    public class Architect
    {
        private IHouseBuilder _builder;
        public Architect(IHouseBuilder builder)
        {
            AcceptBuilder(builder);
        }

        public void ChangeBuilder(IHouseBuilder builder)
        {
            AcceptBuilder(builder);
        }

        public void BuildPresidentVilla()
        {
            _builder.AddArea(500);
            _builder.AddColor("Orange");
            _builder.AddDoors(12);
            _builder.AddWindows(20);
            _builder.AddRoof();
            _builder.AddSwimPool();
            _builder.AddGarage();
            _builder.AddGarden();
            //return _builder.Build();
        }

        public void BuildHotel4Stars()
        {
            _builder.AddArea(200);
            _builder.AddColor("Pink");
            _builder.AddDoors(8);
            _builder.AddWindows(5);
            _builder.AddRoof();
            _builder.AddGarden();
            //return _builder.Build();
        }

        public void BuildPaperHotel4Stars()
        {
            _builder.AddArea(200);
            _builder.AddColor("Pink");
            _builder.AddDoors(8);
            _builder.AddWindows(5);
            _builder.AddRoof();
            _builder.AddGarden();
            //return _builder.Build();
        }

        private void AcceptBuilder(IHouseBuilder builder)
        {
            _builder = builder;
            //..........
            _builder.Reset();
        }
    }
}
