using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class SalaryTypesService
    {
        private readonly ISalaryTypeRepository _SalaryTypesRepository;

        public SalaryTypesService(ISalaryTypeRepository SalaryTypesRepository)
        {
            _SalaryTypesRepository = SalaryTypesRepository;
        }

        public List<SalaryTypes> GetSalaryTypes()
        {
            return _SalaryTypesRepository.BrowseSalaryTypes();
        }
    }
}
