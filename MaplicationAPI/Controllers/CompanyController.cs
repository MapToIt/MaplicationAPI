using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using MaplicationAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


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
        public void GetCompany(string id)
        {
            _companyService.GetCompany(id);
        }

        //PUT one attendee api/Company
        [HttpPut]
        public void InsertCompany(Company company)
        {
            _companyService.InsertCompany(company);
        }

        //POST api/Company
        [HttpPost]
        public void UpdateCompany(Company company)
        {
            _companyService.UpdateCompany(company);
        }
    }
}