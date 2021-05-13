using System.Collections.Generic;

namespace micro_notes {
    public class NotesDAO {
        private static NotesDAO _notesDao;
        private static readonly object mutex = new object();

        public static NotesDAO Instance {
            get{
                lock (mutex) {
                    if (_notesDao == null)
                        _notesDao = new NotesDAO();
                }
                return _notesDao;
            }
        }

        private ICollection<Note> _notes;

        public List<Note> Notes {
            get => _notes as List<Note>;
        }

        private NotesDAO() {
            _notes = new List<Note>();
        }
    }
}