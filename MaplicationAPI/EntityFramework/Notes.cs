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

        [ForeignKey("CompanyId")]
        public User Company { get; set; }
        [ForeignKey("AttendeeId")]
        public User Attendee { get; set; }

    }
}
