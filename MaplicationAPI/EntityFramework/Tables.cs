using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class Tables
    {
        [Key]
        public int TableId { get; set; }

        public int MapId { get; set; }
        public int? CompanyId { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }


        [ForeignKey("MapId")]
        public Map Map { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
}
