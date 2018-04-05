using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using MaplicationAPI.Services;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace MaplicationAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Company")]
    public class CompanyController : Controller
    {
        private readonly CompanyService _companyService;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyService = new CompanyService(companyRepository);
        }

        // GET all api/Company
        [HttpGet]
        public List<Company> Get()
        {
            return _companyService.GetCompanies();
        }

        // GET one api/Company/id
        [HttpGet("{id}")]
        public Company GetCompany(string id)
        {
            return _companyService.GetCompany(id);
        }

        //PUT one attendee api/Company
        [HttpPut]
        public Company InsertCompany([FromBody] Company company)
        {
            return _companyService.InsertCompany(company);
        }

        //POST api/Company
        [HttpPost]
        public Company UpdateCompany([FromBody] Company company)
        {
            return _companyService.UpdateCompany(company);
        }
    }
}