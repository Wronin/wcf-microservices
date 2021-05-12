using System;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace micro_notes {
    [DataContract]
    public class Note {
        [DataMember]
        private DateTime _creationDate;
        public DateTime CreatingDate {
            get => _creationDate;
        }
        
        [DataMember]
        private string _theme;
        public string Theme {
            get => _theme;
        }
        
        [DataMember]
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