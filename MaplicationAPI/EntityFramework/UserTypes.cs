using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class UserTypes
    {
        [Key]
        public int UserTypeId { get; set; }

        public string UserType { get; set; }
    }
}
