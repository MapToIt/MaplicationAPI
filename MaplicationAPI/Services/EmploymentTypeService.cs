using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class EmploymentTypesService
    {
        private readonly IEmploymentTypeRepository _EmploymentTypesRepository;

        public EmploymentTypesService(IEmploymentTypeRepository EmploymentTypesRepository)
        {
            _EmploymentTypesRepository = EmploymentTypesRepository;
        }

        public List<EmploymentTypes> GetEmploymentTypes()
        {
            return _EmploymentTypesRepository.BrowseEmploymentTypes();
        }
    }
}
