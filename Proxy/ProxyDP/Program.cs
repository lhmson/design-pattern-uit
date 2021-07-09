using System;

namespace ProxyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new ProxyImage("car2dtopview.png");

            //image will be loaded from disk
            image.display();
            Console.WriteLine("After loading first time\n");

            //image will not be loaded from disk
            image.display();

            
        }
    }
}
