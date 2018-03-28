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
    [Route("api/Chips")]
    public class ChipsController : Controller
    {
        private readonly ChipsService _ChipsService;

        public ChipsController(IChipsRepository ChipsRepository)
        {
            _ChipsService = new ChipsService(ChipsRepository);
        }

        // GET api/State
        [HttpGet]
        public List<Tags> Get()
        {
            return _ChipsService.GetChips();
        }

    }
}