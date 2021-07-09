using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDP
{
    public class RealImage : Image
    {

        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            loadFromDisk(_fileName);
        }

        public void display()
        {
            // do many things
            Console.WriteLine("Displaying " + _fileName);
        }

        private void loadFromDisk(string fileName)
        {
            // seem to be slow operations
            Console.WriteLine("Loading " + fileName);
        }
    }
}
