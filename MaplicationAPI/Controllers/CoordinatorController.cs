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

        public CoordinatorController(ICoordinatorRepository CoordinatoRepository)
        {
            _CoordinatorService = new CoordinatorService(CoordinatoRepository);
        }

       // GET api/Coordinator
        [HttpGet()]

        public List<Coordinator> GetCoordinator()
        {
            return _CoordinatorService.GetCoordinator();
        }

        //GET api/Coordinator/{id}
        [HttpGet("{id}")]
        public Coordinator Get(string id)
        {
            return _CoordinatorService.GetCoordById(id);
        }    

        //POST api/Coordinator

        [HttpPost()]
        public void AddCoord([FromBody]Coordinator _Coordinator)
        {
            
            _CoordinatorService.AddCoord(_Coordinator);
            return;
           
        }


        //PUT api/Coordinator

        [HttpPut()]
        public void UpdateCoord([FromBody]Coordinator _Coordinator)
        {
            
            _CoordinatorService.UpdateCoord(_Coordinator);
            return;
        }
    }
}

