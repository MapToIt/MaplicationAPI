using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
	public class CoordEventService 
	{
        private readonly ICoordEventRepository _CoordEventRepository;

        public CoordEventService (ICoordEventRepository CoordEventRepository)
		{
			_CoordEventRepository = CoordEventRepository;
		}

        public List<Event> GetCoordEvent()
        {
            return _CoordEventRepository.BrowseCoordEvent();
        }

        public List<Event> GetFutureEvent()
        {
            return _CoordEventRepository.BrowseFutureEvent();
        }

        public List<Event> GetPastEvent()
        {
            return _CoordEventRepository.BrowsePastEvent();
        }
    }
}