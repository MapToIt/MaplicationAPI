using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class SalaryTypes
    {
        [Key]
        public int TypeId { get; set; }

        public string SalaryType { get; set; }
    }
}
