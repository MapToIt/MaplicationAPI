using MaplicationAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Models.Filters
{
    public class JobPostingFilter
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Company { get; set; }
        public int? EmploymentTypeId { get; set; }
    }
}
