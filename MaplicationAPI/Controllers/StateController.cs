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
    [Route("api/State")]
    public class StateController : Controller
    {
        private readonly StateService _StateService;

        public StateController(IStateRepository StateRepository)
        {
            _StateService = new StateService(StateRepository);
        }

        // GET api/State
        [HttpGet]
        public List<State> Get()
        {
            return _StateService.GetStates();
        }
    }
}