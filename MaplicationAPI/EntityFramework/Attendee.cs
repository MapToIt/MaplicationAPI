using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class Attendee
    {
        [Key]
        public int AttendeeId { get; set; }
        
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
        public byte[] Resume { get; set; }
        public string Degree { get; set; }
        public string University { get; set; }
        public string Chips { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
