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
        Map GetMap(int id);
        void AddMap(Map map);
    }
}  
