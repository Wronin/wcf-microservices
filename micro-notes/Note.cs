using System;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace micro_notes
{
    [DataContract]
    public class Note
    {
        [DataMember]
        public DateTime CreatingDate { get; set; }

        [DataMember]
        public string Theme { get; set; }

        [DataMember]
        public string Text { get; set; }

        public override string ToString()
        {
            return $"--{CreatingDate}--\n[{Theme}]\n{Text}";
        }
    }
}