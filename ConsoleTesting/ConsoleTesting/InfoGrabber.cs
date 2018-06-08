using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ConsoleTesting
{
    class InfoGrabber
    {
        private ManagementObjectSearcher processor, motherboard;
        public InfoGrabber()
        {
            processor = new ManagementObjectSearcher("Select * from Win32_Processor");
            motherboard = new ManagementObjectSearcher("Select * from Win32_BaseBoard");
        }

        public int getCoreCount()
        {
            var numberOfCores = 0;
            foreach (var item in processor.Get())
            {
                numberOfCores += int.Parse(item["NumberOfCores"].ToString());
            }
            return numberOfCores;
        }

        public string getProcessorArchitecture()
        {
            string architecture = "Unknown";
            foreach (var item in processor.Get())
            {
                 architecture = GetArchitectureDetail(int.Parse(item["Architecture"].ToString()));
            }
            return architecture;
        }

        public string getMotherboardManufacturer()
        {
            string manufacturer = "Unkown";
            foreach (var item in motherboard.Get())
            {
                manufacturer = item["Manufacturer"].ToString();
            }


            return manufacturer;
        }

        public string getMotherboardModel()
        {
            string model = "Unkown";
            foreach (var item in motherboard.Get())
            {
                model = item["Model"].ToString();
            }


            return model;
        }

        public string getMotherboardName()
        {
            string name = "Unkown";
            foreach (var item in motherboard.Get())
            {
                name = item["Name"].ToString();
            }


            return name;
        }

        private static string GetArchitectureDetail(int architectureNumber)
        {
            switch (architectureNumber)
            {
                case 0: return "x86";
                case 1: return "MIPS";
                case 2: return "Alpha";
                case 3: return "PowerPC";
                case 6: return "Itanium-based systems";
                case 9: return "x64";
                default:
                    return "Unkown";
            }
        }
    }
}
