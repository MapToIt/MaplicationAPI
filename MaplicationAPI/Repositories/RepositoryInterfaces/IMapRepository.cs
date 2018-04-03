using MaplicationAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories.RepositoryInterfaces
{
    public interface IMapRepository
    {
        List<Map> GetAllMaps();
        Map GetMap(int eventId);
        void AddMap(Map map);
        List<Tables> GetTablesByMap(int mapId);
        void AddTable(Tables table);
        void UpdateTable(Tables table);
        void UpdateMap(Map map);
        void DeleteTable(int tableId);
        Tables GetEmptyTable(int eventId);
    }
}  
