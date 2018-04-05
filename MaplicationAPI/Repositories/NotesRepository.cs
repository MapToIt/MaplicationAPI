using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models.Filters;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace MaplicationAPI.Repositories
{
    public class NotesRepository : INotesRepository
    {
        private readonly EntityFramework.MaplicationContext _context;

        public NotesRepository(MaplicationContext context)
        {
            _context = context;
        }

        public List<Notes> BrowseNotes(string Uid)
        {
            return _context.Notes.AsNoTracking().Where(n => n.Company.UserId == Uid).ToList();
        }

        public Notes GetNoteById(int id)
        {
            return _context.Notes
                .AsNoTracking()
                .Where(n => n.NoteId == id)
                .FirstOrDefault();
        }

        public List<Notes> getNotesByFilter(NotesFilter filter)
        {
            return _context.Notes
                .AsNoTracking()
                .Include(x => x.Event)
                .Include(x => x.Rating)
                .Include(x => x.Attendee)
                .Where(n => n.CompanyId == filter.CompanyId)
                .Where(matchesFilter(filter))
                .ToList();

        }

        public Notes updateNote(Notes note)
        {
            Notes updatedNote = _context.Notes.Where(n => n.NoteId == note.NoteId).FirstOrDefault();

            if(updatedNote != null){
                updatedNote.AttendeeId = note.AttendeeId;
                updatedNote.CompanyId = note.CompanyId;
                updatedNote.Date = note.Date;
                updatedNote.EventId = note.EventId;
                updatedNote.Note = note.Note;
                updatedNote.RatingId = note.RatingId;
                updatedNote.Recruiter = note.Recruiter;

                _context.SaveChanges();
            }

            return note;


        }

        public Notes addNote(Notes note)
        {
            note.Date = DateTime.Now;
            _context.Notes.Add(note);
            _context.SaveChanges();

            return note;
            
        }

        private System.Linq.Expressions.Expression<System.Func<Notes, bool>> matchesFilter(NotesFilter filter)
        {
            if (filter == null) { return notes => false; }

            return notes =>
                (filter.Start == null || notes.Event.StartTime >= filter.Start) &&
                (filter.End == null || notes.Event.EndTime <= filter.End) &&
                (filter.AttendeeName == null || (notes.Attendee.FirstName + " " + notes.Attendee.LastName).Contains(filter.AttendeeName)) &&
                (filter.Degree == null || (notes.Attendee.Degree.Contains(filter.Degree))) &&
                (filter.Rating == null || (notes.RatingId == filter.Rating.RatingId)) &&
                (filter.University == null || (notes.Attendee.University == filter.University));
        }
    }
}
