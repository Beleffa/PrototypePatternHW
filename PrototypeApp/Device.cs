using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeApp
{
    public class Device: IMyCloneable<Device>, ICloneable
    {
        public Device(string brandName, string modelName, int serialNumber)
        {
            BrandName = brandName;
            ModelName = modelName;
            SerialNumber = serialNumber;
        }
        protected Device(Device otherDevice)
        {
            BrandName = otherDevice.BrandName;
            ModelName = otherDevice.ModelName;
            SerialNumber = otherDevice.SerialNumber;
        }
        public string? BrandName { get; set; }
        public string? ModelName { get; set; }
        public int SerialNumber { get; set; }

        public Device Clone() => new Device(this);

        object ICloneable.Clone() => this.Clone();
    }
}
