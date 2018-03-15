using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class EventAttendance
    {
        [Key]
        public int AttendanceId { get; set; }
        public string UserId { get; set; }
        public int UserTypeId { get; set; }

        [ForeignKey("EventId")]
        public Event Event { get; set; }
        
        [ForeignKey("UserTypeId")]
        public UserTypes UserTypes { get; set; }
    }
}
