﻿using MaplicationAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories.RepositoryInterfaces
{
    public interface IEventRepository
    {
        List<Event> BrowseEvents();
        Event BrowseEventById(int id);
        List<Event> GetEventsByCoordId(int coordId);
        void AddEvent(Event _event);
        void UpdateEvent(Event _event);
    }
}
