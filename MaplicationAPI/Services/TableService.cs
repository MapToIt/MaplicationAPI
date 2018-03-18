using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class TableService
    {
        private readonly ITableRepository _TableRepository;

        public TableService(ITableRepository TableRepository)
        {
            _TableRepository = TableRepository;
        }
    }
}
