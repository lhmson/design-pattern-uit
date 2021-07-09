using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            var builder1 = new HotelBuilder();
            var architect = new Architect(builder1);
            architect.BuildHotel4Stars();
            var newHotel = builder1.Build();

            var builder2 = new VillaBuilder();
            architect.ChangeBuilder(builder2);
            architect.BuildPresidentVilla();
            var newVilla = builder2.Build();

            var builder3 = new HousePaperBuilder();
            architect.ChangeBuilder(builder3);
            architect.BuildPaperHotel4Stars();
            var newHotelPaper = builder3.Build();

            Console.WriteLine($"Hotel: {newHotel}");
            Console.WriteLine($"Villa: {newVilla}");
            Console.WriteLine($"Villa: {newHotelPaper}");
        }
    }
}
