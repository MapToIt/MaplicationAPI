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
    }
}
