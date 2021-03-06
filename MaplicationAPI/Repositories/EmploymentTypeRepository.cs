﻿using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories
{
    public class EmploymentTypeRepository : IEmploymentTypeRepository
    {
        private readonly EntityFramework.MaplicationContext _context;

        public EmploymentTypeRepository(MaplicationContext context)
        {
            _context = context;
        }


        public List<EmploymentTypes> BrowseEmploymentTypes()
        {
            return _context.EmploymentTypes.AsNoTracking().ToList();
        }
    }
}
