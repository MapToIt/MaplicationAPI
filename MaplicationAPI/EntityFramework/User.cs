using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public int UserTypeId { get; set; }

        [ForeignKey("UserTypeId")]
        public UserTypes UserType { get; set; }
    }
}
