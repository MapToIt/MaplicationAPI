using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories
{
    public class MapRepository : IMapRepository
    {

        private readonly EntityFramework.MaplicationContext _context;

        public MapRepository(MaplicationContext context)
        {
            _context = context;
        }

        public List<Map> GetAllMaps()
        {
            return _context.Map.AsNoTracking().Include("Event").ToList();
        }

        public Map GetMap(int id)
        {
            return _context.Map.AsNoTracking().Include("Event").FirstOrDefault(m => m.MapId == id);
        }

        public void AddMap(Map map)
        {
            _context.Map.Add(map);
            _context.SaveChanges();
        }

    }
}
  
