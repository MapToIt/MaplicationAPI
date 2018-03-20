using MaplicationAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories.RepositoryInterfaces
{
	public interface ICoordEventRepository 
	{
		List<Event> BrowseCoordEvent();
        List<Event> BrowseFutureEvent(string id);
        List<Event> BrowsePastEvent(string id);

    }
}