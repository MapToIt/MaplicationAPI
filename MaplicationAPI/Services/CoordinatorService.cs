using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class CoordinatorService
    {
        private readonly ICoordinatorRepository _coordinatorRepository;

        public CoordinatorService(ICoordinatorRepository coordinatorRepository)
        {
            _coordinatorRepository = coordinatorRepository;
        }

        public bool isCoordinator(string id)
        {
            return _coordinatorRepository.isCoordinator(id);
        }
        public void AddCoord(Coordinator _coordinator)
        {
            _coordinatorRepository.AddCoord(_coordinator);
        }

        public void UpdateCoord(Coordinator _coordinator)
        {
            _coordinatorRepository.UpdateCoord(_coordinator);
        }

        internal List<Coordinator> GetCoords()
        {
            throw new NotImplementedException();
        }

        internal Coordinator isCoordinator(int id)
        {
            throw new NotImplementedException();
        }
    }
}
