using MaplicationAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories.RepositoryInterfaces
{
    public interface ICoordinatorRepository
    {
        bool IsCoordinator(string id);
        Coordinator UpdateCoord(Coordinator _coordinator);
        Coordinator AddCoord(Coordinator _coordinator);
        List<Coordinator> BrowseCoords();
        Coordinator BrowseCoordById(string id);
    }
}
