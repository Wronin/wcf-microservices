using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using micro_note;

namespace Client
{
    [ServiceContract]
    public interface INoteService
    {
        [OperationContract]
        void AddNote(Note note);
        [OperationContract]
        List<Note> GetNotes();
        [OperationContract]
        void UpdateNote(int noteNumber, Note note);
        [OperationContract]
        void RemoveNote(int noteNumber);
    }
}
