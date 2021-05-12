using System;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Client
{
    [DataContract]
    public class Note
    {
        
        private DateTime _creationDate;
        [DataMember]
        public DateTime CreatingDate
        { get; set; }

        private string _theme;
        [DataMember]
        public string Theme
        { get; set; }

        private string _text;
        [DataMember]
        public string Text
        { get; set; }

        public Note(string theme, string text)
        {
            _creationDate = DateTime.Now;
            _theme = theme;
            _text = text;
        }

        public Note()
        {

        }

        public override string ToString()
        {
            return $"--{_creationDate}--\n[{_theme}]\n{_text}";
        }
    }
}