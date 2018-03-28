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
            return _context.Map.AsNoTracking().Include("Event").Include("Event.State").Include("Event.Coordinator").ToList();
        }

        //By Event ID
        public Map GetMap(int eventId)
        {
            return _context.Map.AsNoTracking().Include("Event").Include("Event.State").Include("Event.Coordinator").FirstOrDefault(m => m.EventId == eventId);
        }

        public void AddMap(Map map)
        {
            _context.Map.Add(map);
            _context.SaveChanges();
        }

        public List<Tables> GetTablesByMap(int mapId)
        {
            return _context.Tables.AsNoTracking().Include("Company").Where(t => t.MapId == mapId).ToList();
        }

        public void AddTable(Tables table)
        {
            _context.Tables.Add(table);
            _context.SaveChanges();
        }

    }
}
  
