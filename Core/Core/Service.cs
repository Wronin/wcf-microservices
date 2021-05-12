using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Core
{
    class Service : INoteService
    {
        public void AddNote(Note note)
        {
            Uri tcpUri = new Uri("http://localhost:25565/note-service");
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<INoteService> factory = new ChannelFactory<INoteService>(binding, address);
            INoteService service = factory.CreateChannel();

            service.AddNote(note);

        }

        public ICollection<Note> GetNotes()
        {
            Uri tcpUri = new Uri("http://localhost:25565/note-service");
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<INoteService> factory = new ChannelFactory<INoteService>(binding, address);
            INoteService service = factory.CreateChannel();

            return service.GetNotes();
        }

        public void RemoveNote(int noteNumber)
        {
            Uri tcpUri = new Uri("http://localhost:25565/note-service");
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<INoteService> factory = new ChannelFactory<INoteService>(binding, address);
            INoteService service = factory.CreateChannel();

            service.RemoveNote(noteNumber);
        }

        public void UpdateNote(int noteNumber, Note note)
        {
            Uri tcpUri = new Uri("http://localhost:25565/note-service");
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<INoteService> factory = new ChannelFactory<INoteService>(binding, address);
            INoteService service = factory.CreateChannel();

            service.UpdateNote(noteNumber, note);
        }

        
    }
}
