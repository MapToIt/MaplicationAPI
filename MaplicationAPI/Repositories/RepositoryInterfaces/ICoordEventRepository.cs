using MaplicationAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories.RepositoryInterfaces
{
	public interface ICoordEventRepository 
	{
		List<Event> BrowseCoordEvent(int id);
        List<Event> BrowseFutureEvent(int id);
        List<Event> BrowsePastEvent(int id);

    }
}