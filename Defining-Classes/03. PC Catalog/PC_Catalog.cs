using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PC_Catalog
{
    class PC_Catalog
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Computer pc = new Computer(
                name: "Pravetz",
                processor: new Component("i7-3770k", 500m),
                graphicsCard: new Component("NVIDIA 900-52055-0020-000 GRID K2 8GB", 150m),
                motherboard: new Component("ASRock 990FX Extreme3", 300.99m));

            Computer pc2 = new Computer(
                name: "HP",
                processor: new Component("Core i3-3220 (3.30 GHz, 3 MB cache, 2 cores)", 300m),
                graphicsCard: new Component("Intel HD Graphics", 200m),
                motherboard: new Component("ASUS Z97-A LGA 1150 Intel Z97 HDMI SATA 6Gb/s ", 220m));

            Computer pc3 = new Computer(
                name: "ASUS",
                processor: new Component("Core i5-4130", 420m),
                graphicsCard: new Component("NVIDIA GeForce GTX 970", 1200m),
                motherboard: new Component("ASUS MAXIMUS VII HERO", 580m));

            List<Computer> computers = new List<Computer>() { pc, pc2, pc3 };

            //Sort with LINQ
            var output = from element in computers
                         orderby element.Price ascending
                         select element;

            foreach (var computer in output)
            {
                Console.WriteLine(computer);
            }

            //Sort with lambda expression:
            //computers = computers.OrderBy(x => x.Price).ToList();

            //or:
            //computers.Sort((a, b) => a.Price.CompareTo(b.Price));
        }
    }
}
