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

            Console.WriteLine("Number of Physical Cores: " + test.getCoreCount());
            Console.WriteLine("Processor Architecture: " + test.getProcessorArchitecture());
            Console.WriteLine("Motherboard Manufacturer: " + test.getMotherboardManufacturer());
            Console.WriteLine("Motherboard Model: " + test.getMotherboardModel());
            Console.WriteLine("Motherboard Name: " + test.getMotherboardName());
        }
    }
}
