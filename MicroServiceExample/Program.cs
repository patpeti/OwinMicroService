using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            WebApp.Start<Startup>(url: baseAddress);
            
            Console.ReadLine();
        }
    }
}
