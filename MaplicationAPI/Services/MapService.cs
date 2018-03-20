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

        public void AddMap(Map map)
        {
            _MapRepository.AddMap(map);
            return;
        }

    }
}
