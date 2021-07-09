namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            while (!stop)
            {
                System.Console.Write("Where are u?\n");
                System.Console.Write("1. Inside VN    2.Outside VN\n");
                System.Console.Write("Your choose = ");
                string strChoose = System.Console.ReadLine();
                int choose = int.Parse(strChoose);
                switch (choose)
                {
                    case 1:
                        VehicleCreator carcreator = new CarCreator();
                        carcreator.moveVehicle();
                        break;
                    case 2:
                        VehicleCreator shipcreator = new ShipCreator();
                        shipcreator.moveVehicle();
                        break;
                    default:
                        stop = true;
                        break;
                }
            }

            System.Console.ReadLine();
        }
    }
}
