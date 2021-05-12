using System.Collections.Generic;
using System.Linq;

namespace micro_notes {
    public class NoteService : INoteService {
        public void AddNote(Note note) {
            NotesDAO.Instance.Notes.Add(note);
        }

        public ICollection<Note> GetNotes() {
            return NotesDAO.Instance.Notes;
        }

        public void UpdateNote(int noteNumber, Note note) {
            NotesDAO.Instance.Notes[noteNumber] = note;
        }

        public void RemoveNote(int noteNumber) {
            NotesDAO.Instance.Notes.RemoveAt(noteNumber);
        }
    }
}