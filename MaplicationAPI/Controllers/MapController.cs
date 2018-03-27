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
    [Route("api/Map")]
    public class MapController : Controller
    {
        private readonly MapService _MapService;

        public MapController(IMapRepository MapRepository)
        {
            _MapService = new MapService(MapRepository);
        }

        // GET api/Map/Details
        [HttpGet("Details")]
        public List<Map> GetAllMaps()
        {
            return _MapService.GetAllMaps();
        }

        //GET api/Map/Details/1
        [HttpGet("Details/{eventId}")]
        public Map GetMap(int eventId)
        {
            return _MapService.GetMap(eventId);
        }

        //POST api/Map/Add
        [HttpPost("Add")]
        public void AddMap([FromBody]Map map)
        {
            if (!ModelState.IsValid)
            {
                return;
                //return BadRequest(ModelState);
            }
            _MapService.AddMap(map);
            return;
            //return CreatedAtRoute("DefaultApi", new { id = book.Book_Id }, book);
        }

        //GET api/Map/Tables/1
        [HttpGet("Tables/{mapId}")]
        public List<Tables> GetTablesByMap(int mapId)
        {
            return _MapService.GetTablesByMap(mapId);
        }

        //POST api/Map/Tables/Add
        [HttpPost("Tables/Add")]
        public void AddTable([FromBody]Tables table)
        {
            if (!ModelState.IsValid)
            {
                Console.Write("ModelState invalid");
                return;
            }
            _MapService.AddTable(table);
            return;
        }

    }
}
