using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string EventTitle { get; set; }
        public string Description { get; set; }
        public int StreetNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public int ZipCode { get; set; }

        [ForeignKey("StateId")]
        public State State { get; set; }
    }
}
