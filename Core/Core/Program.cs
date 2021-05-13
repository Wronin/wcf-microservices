using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using micro_notes;

namespace Core
{
    class Program
    {
        static void Main(string[] args) {
            // Service service = new Service();
            // Note note = new Note();
            // note.Text = "text";
            // note.Theme = "theme";
            // note.CreatingDate = DateTime.Now;
            // service.AddNote(note);
            ServiceHost host = new ServiceHost(typeof(Service), new Uri("http://localhost:1337/"));
            host.AddServiceEndpoint(typeof(INoteService), new BasicHttpBinding(), "");
            
            
            host.Open();
            Console.WriteLine("Сервер запущен");
            Console.ReadLine();
            host.Close();
        }
    }
}
