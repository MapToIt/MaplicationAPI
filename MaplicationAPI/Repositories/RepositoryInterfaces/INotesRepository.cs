using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories.RepositoryInterfaces
{
    public interface INotesRepository
    {
        List<Notes> BrowseNotes(string Uid);
        Notes GetNoteById(int id);
        List<Notes> getNotesByFilter(NotesFilter filter);
        Notes updateNote(Notes note);
        Notes addNote(Notes note);
        
    }
}
