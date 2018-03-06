using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaplicationAPI.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaplicationAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Attendee")]
    public class AttendeeController : Controller
    {
        // POST api/attendee
        [HttpPost]
        public void Post([FromBody] Attendee attendee)
        {

        }
    }
}