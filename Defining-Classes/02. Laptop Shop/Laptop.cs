using System;
using System.Text;

namespace _02.Laptop_Shop
{
    class Laptop
    {
        private string model;
        private decimal price;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery laptopBattery;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, string manufacturer = null, string processor = null, string ram = null, string graphicsCard = null, string hdd = null, string screen = null, string batteryModel = null, double batteryHours = 0)
            :this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.LaptopBattery = new Battery(batteryModel, batteryHours);
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model value cannot be empty!");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Price cannot be negative number!");
                }
                this.price = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer value cannot be empty!");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Processor value cannot be empty!");
                }
                this.processor = value;
            }
        }

        public string Ram
        {
            get { return this.ram; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("RAM value cannot be empty!");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Graphics card value cannot be empty!");
                }
                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("HDD value cannot be empty!");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Screen value cannot be empty!");
                }
                this.screen = value;
            }
        }

        public Battery LaptopBattery
        {
            get { return this.laptopBattery; }
            set { this.laptopBattery = value; }
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Laptop description:");
            result.AppendLine("Model: " + this.Model);

            if (manufacturer != null)
            {
                result.AppendLine("Manufacturer: " + this.Manufacturer);
            }
            if (processor != null)
            {
                result.AppendLine("Processor: " + this.Processor);
            }
            if (ram != null)
            {
                result.AppendLine("RAM: " + this.Ram);
            }
            if (graphicsCard != null)
            {
                result.AppendLine("Graphics Card: " + this.GraphicsCard);
            }
            if (hdd != null)
            {
                result.AppendLine("HDD: " + this.Hdd);
            }
            if (screen != null)
            {
                result.AppendLine("Screen: " + this.Screen);
            }
            if (laptopBattery.BatteryModel != null)
            {
                result.AppendLine("Battery: " + this.LaptopBattery.BatteryModel);
            }
            if (laptopBattery.BatteryLife != null)
            {
                result.AppendLine("Battery Life: " + this.LaptopBattery.BatteryLife + "hours");
            }
            result.AppendLine("Price: " + this.Price + " lv.");
            return result.ToString();
        }
    }
}
