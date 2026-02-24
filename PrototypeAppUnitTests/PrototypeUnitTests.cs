using PrototypeApp;

namespace PrototypeAppUnitTests
{
    public class PrototypeUnitTests
    {
        [Fact]
        public void TestIMyCloneableImplementation()
        {
            var gamingLaptop1 = CreateLaptop();
            var gamingLaptop2 = gamingLaptop1.Clone();

            Assert.False(object.ReferenceEquals(gamingLaptop1, gamingLaptop2));
        }

        [Fact]
        public void TestICloneableImplementation()
        {
            ICloneable laptop = CreateLaptop();

            var clone = laptop.Clone();

            Assert.NotNull(clone);
            Assert.IsType<GamingLaptop>(clone);
            Assert.False(object.ReferenceEquals(laptop, clone));
        }

        [Fact]
        public void TestFieldsEquals()
        {
            var gamingLaptop1 = CreateLaptop();

            var gamingLaptop2 = gamingLaptop1.Clone();

            Assert.Equal(gamingLaptop1.BrandName, gamingLaptop2.BrandName);
            Assert.Equal(gamingLaptop1.ModelName, gamingLaptop2.ModelName);
            Assert.Equal(gamingLaptop1.SerialNumber, gamingLaptop2.SerialNumber);
            Assert.Equal(gamingLaptop1.ProcessorName, gamingLaptop2.ProcessorName);
            Assert.Equal(gamingLaptop1.RamSize, gamingLaptop2.RamSize);
            Assert.Equal(gamingLaptop1.ScreenSize, gamingLaptop2.ScreenSize);
            Assert.Equal(gamingLaptop1.Weight, gamingLaptop2.Weight);
            Assert.Equal(gamingLaptop1.BatteryLife, gamingLaptop2.BatteryLife);
            Assert.Equal(gamingLaptop1.GpuModel, gamingLaptop2.GpuModel);
            Assert.Equal(gamingLaptop1.HasRgbBacklight, gamingLaptop2.HasRgbBacklight);
        }

        [Fact]
        public void TestChangeField()
        {
            var gamingLaptop1 = CreateLaptop();

            var gamingLaptop2 = gamingLaptop1.Clone();

            gamingLaptop2.SerialNumber = 987654321;

            Assert.Equal(gamingLaptop1.BrandName, gamingLaptop2.BrandName);
            Assert.Equal(gamingLaptop1.ModelName, gamingLaptop2.ModelName);
            Assert.NotEqual(gamingLaptop1.SerialNumber, gamingLaptop2.SerialNumber);
            Assert.Equal(gamingLaptop1.ProcessorName, gamingLaptop2.ProcessorName);
            Assert.Equal(gamingLaptop1.RamSize, gamingLaptop2.RamSize);
            Assert.Equal(gamingLaptop1.ScreenSize, gamingLaptop2.ScreenSize);
            Assert.Equal(gamingLaptop1.Weight, gamingLaptop2.Weight);
            Assert.Equal(gamingLaptop1.BatteryLife, gamingLaptop2.BatteryLife);
            Assert.Equal(gamingLaptop1.GpuModel, gamingLaptop2.GpuModel);
            Assert.Equal(gamingLaptop1.HasRgbBacklight, gamingLaptop2.HasRgbBacklight);
        }

        private GamingLaptop CreateLaptop()
        {
            return new GamingLaptop(
                brandName: "ASUS",
                modelName: "ROG Strix SCAR 17",
                serialNumber: 123456789,
                processorName: "AMD Ryzen 9 6900HX",
                ramSize: 32, // GB
                screenSize: 17.3, // inches
                weight: 2.9, // kg
                batteryLife: 8.5, // hours
                gpuModel: "NVIDIA GeForce RTX 3080 Ti",
                hasRgbBackLight: true
            );
        }
    }
}
