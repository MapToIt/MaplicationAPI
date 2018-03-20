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
    [Route("api/Coordinator")]

    public class CoordinatorController : Controller
    {
        private readonly CoordinatorService _CoordinatorService;

        public object ModelState { get; private set; }

        public CoordinatorController(ICoordinatorRepository CoordinatoRepository)
        {
            _CoordinatorService = new CoordinatorService(CoordinatoRepository);
        }

        // GET api/ECoordinator/Details
        [HttpGet("Details")]
        public List<Coordinator> GetCoordinator()
        {
            return _CoordinatorService.GetCoords();
        }

        //GET api/Coordinator/Details/1
        [HttpGet("Details/{id}")]
        public Coordinator isCoordinator(int id)
        {
            return _CoordinatorService.isCoordinator(id);
        }

        //POST api/Coordinator/Add
        [HttpPost("Add")]
        public void AddCoord([FromBody]Coordinator _Coordinator)
        {
            
            _CoordinatorService.AddCoord(_Coordinator);
            return;
           
        }

        //PUT api/Coordinator/Update/1
        [HttpPut("Update")]
        public void UpdateCoord([FromBody]Coordinator _Coordinator)
        {
            
            _CoordinatorService.UpdateCoord(_Coordinator);
            return;
        }
    }
}

