using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class MapService
    {
        private readonly IMapRepository _MapRepository;

        public MapService(IMapRepository MapRepository)
        {
            _MapRepository = MapRepository;
        }

        public List<Map> GetAllMaps()
        {
            return _MapRepository.GetAllMaps();
        }

        public Map GetMap(int eventId)
        {
            return _MapRepository.GetMap(eventId);
        }

        public Map AddMap(Map map)
        {

            return _MapRepository.AddMap(map); ;
        }

        public List<Tables> GetTablesByMap(int mapId)
        {
            return _MapRepository.GetTablesByMap(mapId);
        }

        public Tables AddTable(Tables table)
        {
            return _MapRepository.AddTable(table);
        }

        public void UpdateTable(Tables table)
        {
            _MapRepository.UpdateTable(table);
        }

        public void UpdateMap(Map map)
        {
            _MapRepository.UpdateMap(map);
        }

        public void DeleteTable(int tableId)
        {
            _MapRepository.DeleteTable(tableId);
        }

        public Tables GetEmptyTable(int eventId)
        {
            return _MapRepository.GetEmptyTable(eventId);
        }

    }
}
