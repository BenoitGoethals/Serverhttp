using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Nancy.Hosting.Self;
namespace Serverhttp
{
    class Program
    {
        static void Main()
        {
            using (var nancyHost = new NancyHost(new Uri("http://localhost:1234")))
            {
                nancyHost.Start();

                Console.WriteLine("Nancy now listening - navigating to http://localhost:1234. Press enter to stop");
                try
                {
                    Process.Start("http://localhost:1234");
                }
                catch (Exception)
                {
                }
                Console.ReadKey();
            }

            Console.WriteLine("Stopped. Good bye!");
        }
    }
}
