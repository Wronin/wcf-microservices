using System.Collections.Generic;
using System.ServiceModel;

namespace micro_notes {
    [ServiceContract]
    public interface INoteService {
        [OperationContract]
        void AddNote(string theme, string text);
        [OperationContract]
        void AddNote1(Note note);
        [OperationContract]
        List<Note> GetNotes();
        [OperationContract]
        void UpdateNote(int noteNumber, Note note);
        [OperationContract]
        void RemoveNote(int noteNumber);
    }
}