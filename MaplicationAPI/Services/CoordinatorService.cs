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

        public List<Coordinator> GetCoordinator()
        {
            return _coordinatorRepository.BrowseCoords();
        }

        public Coordinator GetCoordById(string id)
        {
            return _coordinatorRepository.BrowseCoordById(id);
        }

        public bool IsCoordinator(string id)
        {
            return _coordinatorRepository.IsCoordinator(id);
        }

        public Coordinator AddCoord(Coordinator _coordinator)
        {
            return _coordinatorRepository.AddCoord(_coordinator);
        }

        public Coordinator UpdateCoord(Coordinator _coordinator)
        {
            return _coordinatorRepository.UpdateCoord(_coordinator);
        }

    }
}
