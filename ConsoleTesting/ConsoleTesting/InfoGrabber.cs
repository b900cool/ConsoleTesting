using System.Management;
using System;

namespace ConsoleTesting
{
    class InfoGrabber
    {
        
        
        public InfoGrabber()
        {
            
        }

        public string GetCoreCount()
        {
            return GetComponent("Win32_Processor", "NumberOfCores");
        }

        public string GetProcessorArchitecture()
        {
            return GetArchitectureDetail(Convert.ToInt32(GetComponent("Win32_Processor", "Architecture")));
        }

        public string GetMotherboardManufacturer()
        {
            return GetComponent("Win32_BaseBoard", "Manufacturer");
        }

        public string GetMotherboardModel()
        {
            return GetComponent("Win32_BaseBoard", "Model");
        }

        public string GetMotherboardName()
        {
            return GetComponent("Win32_BaseBoard", "Name");
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

        public string GetCPUDescription()
        {
            return GetComponent("Win32_Processor", "Description");
        }

        public static string GetComponent(string wmiClass, string index)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * from " + wmiClass);
            string data = "Unkown";
            foreach (var item in searcher.Get())
            {
                data = item[index].ToString();
            }

            return data;
        }

    }


}
