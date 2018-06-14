using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoGrabber test = new InfoGrabber();
            InfoPrinter test2 = new InfoPrinter();

            test2.PrintCPUInfo();

            Console.WriteLine("Processor Description" + test.GetCPUDescription());
            Console.WriteLine("Motherboard Manufacturer: " + test.GetMotherboardManufacturer());
            //Console.WriteLine("Motherboard Model: " + test.GetMotherboardModel());
            Console.WriteLine("Motherboard Name: " + test.GetMotherboardName());
        }
    }
}
