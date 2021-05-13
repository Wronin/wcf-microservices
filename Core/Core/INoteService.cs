using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Core
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
