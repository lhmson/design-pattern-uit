namespace FactoryMethod
{
    class Car : IVehicle
    {
        public void move()
        {
            System.Console.WriteLine("Car -- move");
        }
    }

    class Ship : IVehicle
    {
        public void move()
        {
            System.Console.WriteLine("Ship -- move");
        }
    }
}
