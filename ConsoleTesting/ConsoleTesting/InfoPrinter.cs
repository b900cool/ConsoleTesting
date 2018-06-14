using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class InfoPrinter
    {
        private InfoGrabber grabber;


        public InfoPrinter()
        {
            grabber = new InfoGrabber();

        }

        public void PrintCPUInfo()
        {
            Console.WriteLine("Number of Physical Cores: " + grabber.GetCoreCount());
            Console.WriteLine("Processor Architecture: " + grabber.GetProcessorArchitecture());
        }

    }
}
