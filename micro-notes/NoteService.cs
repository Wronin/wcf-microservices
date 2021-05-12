using System.Collections.Generic;
using System.Linq;

namespace micro_notes {
    public class NoteService : INoteService {
        public void AddNote(string theme, string text) {
            Note note = new Note(theme, text);
            NotesDAO.Instance.Notes.Add(note);
        }
        public void AddNote1(Note note)
        {
            NotesDAO.Instance.Notes.Add(note);
        }

        public List<Note> GetNotes() {
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