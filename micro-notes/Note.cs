using System;

namespace micro_notes {
    public class Note {
        private DateTime _creationDate;
        public DateTime CreatingDate {
            get => _creationDate;
        }

        private string _theme;
        public string Theme {
            get => _theme;
        }
        
        private string _text;
        public string Text {
            get => _text;
        }

        public Note(string theme, string text) {
            _creationDate = DateTime.Now;
            _theme = theme;
            _text = text;
        }
    }
}