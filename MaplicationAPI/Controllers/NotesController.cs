using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models.Filters;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using MaplicationAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaplicationAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Notes")]
    public class NotesController : Controller
    {
        private readonly NotesService _notesService;

        public NotesController(INotesRepository notesRepository)
        {
            _notesService = new NotesService(notesRepository);
        }

        // GET all api/notes/{Uid}
        [HttpGet("{Uid}")]
        public List<Notes> Get(string Uid)
        {
            return _notesService.GetNotes(Uid);
        }

        //GET byNoteId api/notes/byID/{id}
        [HttpGet("{id}")]
        public Notes GetNoteById(int id)
        {
            return _notesService.GetNoteById(id);
        }

        //POST uodateNote() api/notes
        [HttpPost]
        public Notes updateNote([FromBody] Notes note)
        {
            return _notesService.updateNote(note);
        }

        //PUT api/notes
        [HttpPut]
        public Notes AddNote([FromBody] Notes note)
        {
            return _notesService.addNote(note);
        }        

        //POST by filter api/notes/filter
        [HttpPost("filter")]
        public List<Notes> GetNotesByFilter([FromBody] NotesFilter filter)
        {
            return _notesService.getNotesByFilter(filter);
        }
    }
}