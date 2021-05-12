using System.Collections.Generic;

namespace micro_notes {
    public interface INoteService {
        void AddNote(Note note);
        ICollection<Note> GetNotes();
        void UpdateNote(int noteNumber);
        void RemoveNote(int noteNumber);
    }
}