using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PrototypeApp
{
    public class Computer : Device, IMyCloneable<Computer>, ICloneable
    {
        public Computer(string brandName, string modelName, int serialNumber, string processorName, int ramSize) : base(brandName, modelName, serialNumber)
        {
            ProcessorName = processorName;
            RamSize = ramSize;
        }
        protected Computer(Computer otherComputer) : base(otherComputer) 
        {
            ProcessorName = otherComputer.ProcessorName;
            RamSize = otherComputer.RamSize;
        }
        public string? ProcessorName { get; set; }
        public int RamSize { get; set; }

        public new Computer Clone() => new Computer(this);
        object ICloneable.Clone() => this.Clone();
    }
}
