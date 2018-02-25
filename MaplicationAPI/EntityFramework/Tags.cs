using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class Tags
    {
        [Key]
        public int TagId { get; set; }

        public string Tag { get; set; }
    }
}
