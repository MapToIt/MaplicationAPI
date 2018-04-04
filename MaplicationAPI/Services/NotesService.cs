using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models.Filters;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class NotesService
    {
        private readonly INotesRepository _NotesRepository;

        public NotesService(INotesRepository NotesRepository)
        {
            _NotesRepository = NotesRepository;
        }

        public List<Notes> GetNotes(string Uid)
        {
            return _NotesRepository.BrowseNotes(Uid);
        }

        public Notes GetNoteById(int id)
        {
            return _NotesRepository.GetNoteById(id);
        }

        public List<Notes> getNotesByFilter(NotesFilter filter)
        {
            return _NotesRepository.getNotesByFilter(filter);
        }

        public Notes updateNote(Notes note)
        {
            return _NotesRepository.updateNote(note);
        }

        public Notes addNote(Notes note)
        {
            return _NotesRepository.addNote(note);
        }

    }
}
