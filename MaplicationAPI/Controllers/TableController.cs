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
    [Route("api/Table")]
    public class TableController : Controller
    {
        private readonly TableService _TableService;

        public TableController(ITableRepository TableRepository)
        {
            _TableService = new TableService(TableRepository);
        }
    }
}
