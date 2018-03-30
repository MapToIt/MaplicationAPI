using MaplicationAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Models
{
    public class RSVP
    {
        public string UserId { get; set; }
        public string UserType { get; set; }
        public int Event { get; set; }
    }
}
