using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ApplicationServer.Http;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new HttpServiceHost(typeof(CatalogService), "http://localhost:8080/catalog"))
            {
                host.Open();
                ShowEndpointsOf(host);
                WaitForKey();
            }
        }
        private static void ShowEndpointsOf(ServiceHost host)
        {
            Console.WriteLine("Host is opened with the following endpoints:");
            foreach (var ep in host.Description.Endpoints)
            {
                Console.WriteLine("\tEndpoint: address = {0}; binding = {1}", ep.Address, ep.Binding);
            }
        }

        private static void WaitForKey()
        {
            Console.WriteLine("Press any key to stop host...");
            Console.ReadKey();
        }
    }

}