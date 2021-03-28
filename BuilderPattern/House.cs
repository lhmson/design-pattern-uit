
namespace BuilderPattern
{
    public abstract class House
    {
        public int area { get; set; }
        public string color { get; set; }
        public int doors { get; set; }
        public int windows { get; set; }
        public bool roof { get; set; }
        public bool garage { get; set; }
        public bool swimPool { get; set; }
        public bool garden { get; set; }

        //the constructor calls pretty ugly.
        //public House(int area, string color, bool doors, bool windows, bool roof, bool garage, bool swimpool, bool garden)
        //{
        //    this.area = area;
        //    this.color = color;
        //    this.windows = windows;
        //    this.roof = roof;
        //    this.garage = garage;
        //    this.swimPool = swimPool;
        //    this.garden = garden;
        //}

        public override string ToString()
        {
            var strBuilded = area + "m2" + " ";
            strBuilded += color + " ";
            strBuilded += doors + " doors ";
            strBuilded += windows + " windows ";
            if (roof) strBuilded += " roof ";
            if (garage) strBuilded += " garage ";
            if (swimPool) strBuilded += " swimPool ";
            if (garden) strBuilded += " garden ";
            return strBuilded;
        }
    }
}
