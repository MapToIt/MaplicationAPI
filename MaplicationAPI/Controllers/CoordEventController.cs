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
    [Route("api/CoordEvent")]
    public class CoordEventController : Controller
    {
        private readonly CoordEventService _CoordEventService;

        public CoordEventController(ICoordEventRepository CoordEventRepository)
        {
            _CoordEventService = new CoordEventService(CoordEventRepository);
        }

        // GET api/CoordEvent
        [HttpGet]
        public List<Event> Get()
        {
            return _CoordEventService.GetCoordEvent();
        }
    }
}