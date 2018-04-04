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
    [Route("api/RatingType")]
    public class RatingTypeController : Controller
    {
        private readonly RatingTypeService _RatingTypeService;

        public RatingTypeController(IRatingTypeRepository RatingTypeRepository)
        {
            _RatingTypeService = new RatingTypeService(RatingTypeRepository);
        }

        // GET api/RatingType
        [HttpGet]
        public List<RatingType> Get()
        {
            return _RatingTypeService.GetRatingType();
        }
    }
}