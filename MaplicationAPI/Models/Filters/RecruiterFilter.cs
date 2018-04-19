using MaplicationAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Models.Filters
{
    public class RecruiterFilter
    {
        public string Company { get; set; }
        public int? CompanyId { get; set; }
        public string JobTitle { get; set; }
        public string AlmaMater { get; set; }
        public string Name { get; set; }
    }
}
