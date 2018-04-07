using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models;
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

        public List<NoteModel> getNotesByFilter(NotesFilter filter)
        {
            List<Notes> allNotes = _NotesRepository.getNotesByFilter(filter);
            List<NoteModel> groupedNotes = new List<NoteModel>();

            foreach (Notes note in allNotes)
            {
                if(groupedNotes.Count() == 0)
                {
                    NoteModel newNote = new NoteModel();
                    newNote.notes = new List<Notes>();
                    newNote.notes.Add(note);
                    newNote.averageRating = note.Rating.Value;
                    groupedNotes.Add(newNote);
                }
                else
                {
                    if (groupedNotes.Any(x => x.notes.Any(n => n.AttendeeId == note.AttendeeId)))
                    {
                        NoteModel newNote = groupedNotes.Where(x => x.notes.Any(n => n.AttendeeId == note.AttendeeId)).FirstOrDefault();
                        newNote.notes.Add(note);
                        newNote.averageRating += note.Rating.Value;
                    }
                    else
                    {
                        NoteModel newNote = new NoteModel();
                        newNote.notes = new List<Notes>();
                        newNote.notes.Add(note);
                        newNote.averageRating = note.Rating.Value;
                        groupedNotes.Add(newNote);
                    }
                }
            }

            foreach (NoteModel set in groupedNotes)
            {
                set.averageRating = set.averageRating / set.notes.Count();
                set.notes = set.notes.OrderByDescending(n => n.Date).ToList();
            }

            return groupedNotes;
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
