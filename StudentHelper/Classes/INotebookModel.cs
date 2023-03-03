using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHelper
{
    internal interface INotebookModel
    {
        void AddNote(NoteModel note);
        void RemoveNote(NoteModel note);
    }
}
