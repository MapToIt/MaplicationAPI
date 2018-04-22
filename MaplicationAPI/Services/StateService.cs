using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class StateService
    {
        private readonly IStateRepository _StateRepository;

        public StateService(IStateRepository StateRepository)
        {
            _StateRepository = StateRepository;
        }

        public List<State> GetStates()
        {
            return _StateRepository.BrowseStates();
        }
    }
}
