using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Service), new Uri("http://localhost:1338/"));
            host.AddServiceEndpoint(typeof(INoteService), new BasicHttpBinding(), "");

            host.Open();
            Console.WriteLine("Сервер запущен");
            Console.ReadLine();
            host.Close();
        }
    }
}
