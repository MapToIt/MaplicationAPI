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

        public Map AddMap(Map map)
        {
            _context.Map.Add(map);
            _context.SaveChanges();
            return _context.Map.Where(m => m.EventId == map.EventId).FirstOrDefault();
        }

        public List<Tables> GetTablesByMap(int mapId)
        {
            return _context.Tables.AsNoTracking().Include("Company").Include("Company.State").Where(t => t.MapId == mapId).ToList();
        }

        public void AddTable(Tables table)
        {
            _context.Tables.Add(table);
            _context.SaveChanges();
        }

        public void UpdateTable(Tables table)
        {
            var existingTable = _context.Tables.Update(table);

            if (existingTable != null)
            {

                _context.SaveChanges();
            }
            else
            {
                return;
            }
            return;
        }

        public void UpdateMap(Map map)
        {
            var existingMap = _context.Map.Update(map);

            if (existingMap != null)
            {

                _context.SaveChanges();
            }
            else
            {
                return;
            }
            return;
        }

        public void DeleteTable(int tableId)
        {
            var toDelete = _context.Tables.Find(tableId);
            _context.Tables.Remove(toDelete);
            _context.SaveChanges();
        }
        
        public Tables GetEmptyTable(int eventId)
        {
            Map map = _context.Map.Where(m => m.EventId == eventId).FirstOrDefault();

            if (map != null)
            {
                return _context.Tables.Where(t => t.MapId == map.MapId).Where(t => t.CompanyId == null).FirstOrDefault();
            }

            return null;
        }

    }
}
  
