using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaplicationAPI.EntityFramework;

namespace MaplicationAPI.Models.Filters
{
    public class NotesFilter
    {
        public string AttendeeName { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string Degree { get; set; }
        public string University { get; set; }
        public RatingType Rating { get; set; }
        public int? CompanyId { get; set; }
    }
}
