using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDP
{
    public class ProxyImage : Image
    {
        private RealImage _realImage;
        private string _fileName;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }
        public void display()
        {
            if (_realImage == null) // lazy loading
            {
                _realImage = new RealImage(_fileName);
            }
            //if (_fileName == "spaceship.png") return; // validation
            _realImage.display();
        }
    }
}
