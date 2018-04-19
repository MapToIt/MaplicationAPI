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
    [Route("api/SalaryTypes")]
    public class SalaryTypesController : Controller
    {
        private readonly SalaryTypesService _SalaryTypesService;

        public SalaryTypesController(ISalaryTypeRepository SalaryTypesRepository)
        {
            _SalaryTypesService = new SalaryTypesService(SalaryTypesRepository);
        }

        // GET api/SalaryTypes
        [HttpGet]
        public List<SalaryTypes> Get()
        {
            return _SalaryTypesService.GetSalaryTypes();
        }

    }
}