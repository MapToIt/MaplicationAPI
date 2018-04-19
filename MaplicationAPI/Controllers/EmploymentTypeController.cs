using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using MaplicationAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaplicationAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/EmploymentType")]
    public class EmploymentTypeController : Controller
    {
        private readonly EmploymentTypesService _EmploymentTypeService;

        public EmploymentTypeController(IEmploymentTypeRepository EmploymentTypeRepository)
        {
            _EmploymentTypeService = new EmploymentTypesService(EmploymentTypeRepository);
        }

        // GET api/EmploymentType
        [HttpGet]
        public List<EmploymentTypes> Get()
        {
            return _EmploymentTypeService.GetEmploymentTypes();
        }

    }
}