﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using micro_notes;

namespace Client
{
    [ServiceContract]
    public interface INoteService
    {
        [OperationContract]
        void AddNote(Note note);
        [OperationContract]
        ICollection<Note> GetNotes();
        [OperationContract]
        void UpdateNote(int noteNumber, Note note);
        [OperationContract]
        void RemoveNote(int noteNumber);
    }
}
