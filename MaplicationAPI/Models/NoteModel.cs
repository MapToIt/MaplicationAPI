using MaplicationAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Models
{
    public class NoteModel
    {
        public List<Notes> notes { get; set; }
        public double averageRating { get; set; }
    }
}
