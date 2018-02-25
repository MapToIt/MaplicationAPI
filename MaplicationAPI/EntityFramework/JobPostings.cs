using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class JobPostings
    {
        [Key]
        public int JobId { get; set; }

        public string Chips { get; set; }
        public int CompanyId { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
}
