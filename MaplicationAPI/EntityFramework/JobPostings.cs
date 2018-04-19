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

        public int CompanyId { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public int EmploymentTypeId { get; set; }
        public int? BaseSalary { get; set; }
        public int? SalaryTypeId { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime ValidThrough { get; set; }
        public Boolean Active { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        [ForeignKey("EmploymentTypeId")]
        public EmploymentTypes EmploymentType { get; set; }
        [ForeignKey("SalaryTypeId")]
        public EmploymentTypes SalaryType { get; set; }
    }
}
