using MaplicationAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories.RepositoryInterfaces
{
    public interface ICoordinatorRepository
    {
        bool isCoordinator(string id);
        void CoordEvent(Coordinator _coordinator);
        void UpdateCoord(Coordinator _coordinator);
        void AddCoord(Coordinator _coordinator);
    }
}
