﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.EntityFramework
{
    public class Coordinator
    {
        [Key]
        public int CoordinatorId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
