using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeApp
{
    public class GamingLaptop : Laptop, IMyCloneable<GamingLaptop>, ICloneable
    {
        public GamingLaptop(string brandName, string modelName, int serialNumber, string processorName, int ramSize, double screenSize, double weight, double batteryLife, string gpuModel, bool hasRgbBackLight) : base(brandName, modelName, serialNumber, processorName, ramSize, screenSize, weight, batteryLife)
        {
            GpuModel = gpuModel;
            HasRgbBacklight = hasRgbBackLight;
        }
        protected GamingLaptop(GamingLaptop otherGamingLaptop) : base(otherGamingLaptop)
        {
            GpuModel = otherGamingLaptop.GpuModel;
            HasRgbBacklight = otherGamingLaptop.HasRgbBacklight;
        }
        public string? GpuModel { get; set; }
        public bool HasRgbBacklight { get; set; }

        public new GamingLaptop Clone() => new GamingLaptop(this);

        object ICloneable.Clone() => this.Clone();
    }
}
