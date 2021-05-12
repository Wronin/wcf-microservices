using System.Collections.Generic;
using System.ServiceModel;

namespace micro_notes {
    [ServiceContract]
    public interface INoteService {
        [OperationContract]
        void AddNote(Note note);
        [OperationContract]
        ICollection<Note> GetNotes();
        [OperationContract]
        void UpdateNote(int noteNumber);
        [OperationContract]
        void RemoveNote(int noteNumber);
    }
}