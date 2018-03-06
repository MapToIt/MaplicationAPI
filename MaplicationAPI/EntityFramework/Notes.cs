using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class Notes
    {
        [Key]
        public int NoteId { get; set; }

        public string Note { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Major { get; set; }
        public string email { get; set; }

        [ForeignKey("CompanyId")]
        public User Company { get; set; }

    }
}
