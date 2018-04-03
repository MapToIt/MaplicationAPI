using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class Notes
    {
        [Key]
        public int NoteId { get; set; }

        public string Note { get; set; }
        public int CompanyId { get; set; }
        public int AttendeeId { get; set; }
        public int EventId { get; set; }
        public DateTime Date { get; set; }
        public int RatingId { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        [ForeignKey("AttendeeId")]
        public Attendee Attendee { get; set; }
        [ForeignKey("EventId")]
        public Event Event { get; set; }
        [ForeignKey("RatingId")]
        public RatingType Rating { get; set; }

    }
}
