using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public int StreetNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public int ZipCode { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
        public string Chips { get; set; }
        public ICollection<Recruiter> Recruiters { get; set; }
        public ICollection<JobPostings> Jobs { get; set; }

        [ForeignKey("StateId")]
        public State State { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

    }
}
