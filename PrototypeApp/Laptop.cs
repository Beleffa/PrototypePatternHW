namespace PrototypeApp
{
    public class Laptop : Computer, IMyCloneable<Laptop>, ICloneable
    {
        public Laptop(string brandName, string modelName, int serialNumber, string processorName, int ramSize, double screenSize, double weight, double batteryLife) : base(brandName, modelName, serialNumber, processorName, ramSize)
        {
            ScreenSize = screenSize;
            Weight = weight;
        }
        protected Laptop(Laptop otherLaptop) : base(otherLaptop)
        {
            ScreenSize = otherLaptop.ScreenSize;
            Weight = otherLaptop.Weight;
            BatteryLife = otherLaptop.BatteryLife;
        }
        public double ScreenSize { get; set; }
        public double Weight { get; set; }
        public double BatteryLife { get; set; }

        public new Laptop Clone() => new Laptop(this);
        object ICloneable.Clone() => this.Clone();
    }
}
