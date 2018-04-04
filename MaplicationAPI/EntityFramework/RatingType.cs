using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class RatingType
    {
        [Key]
        public int RatingId { get; set; }

        public string Rating { get; set; }
        public int Value { get; set; }
    }
}
