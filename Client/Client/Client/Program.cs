using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Client
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        string EchoWithGet(string s);

    }
    class Program
    {
        static void Main(string[] args)
        {
            Uri tcpUri = new Uri("http://localhost:1337/");
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<IMyService> factory = new ChannelFactory<IMyService>(binding, address);
            IMyService service = factory.CreateChannel();

            Console.WriteLine(service.EchoWithGet("Hello world"));
        }
    }
}
