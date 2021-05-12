using System;
using System.ServiceModel;

namespace micro_notes {
    internal class Program {
        public static void Main(string[] args) {
            ServiceHost host = new ServiceHost(typeof(NoteService), new Uri("http://localhost:25565/note-service"));

            host.AddServiceEndpoint(typeof(INoteService), new BasicHttpBinding(), "");
            
            host.Open();
            Console.WriteLine("Note service started");
            Console.ReadKey();
            
            host.Close();
        }
    }
}