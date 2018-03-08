using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class Map
    {
        [Key]
        public int MapId { get; set; }

        public int EventId { get; set; }
        public string Image { get; set; }
        public ICollection<Tables> Tables { get; set; }

        [ForeignKey("EventId")]
        public Event Event { get; set; }
}
}
