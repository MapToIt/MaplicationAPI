using MaplicationAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Models.Filters
{
    public class EventFilter
    {
        public State State { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
