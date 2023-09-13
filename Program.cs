using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Running the program.
            Controller controller = new Controller();
            controller.Start();
        }
    }
}
