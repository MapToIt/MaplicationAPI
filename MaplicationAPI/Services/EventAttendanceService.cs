using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class EventAttendanceService
    {
        private readonly IEventAttendanceRepository _eventAttendanceRepository;

        public EventAttendanceService(IEventAttendanceRepository eventAttendanceRepository)
        {
            _eventAttendanceRepository = eventAttendanceRepository;
        }

        /*public bool IsAttending(Event _Event, string _userId)
        {
            return _eventAttendanceRepository.IsAttendingEvent(_Event, _userId);
        }*/

        public List<EventAttendance> EventsAttending(string _userId)
        {
            return _eventAttendanceRepository.EventsAttending(_userId);
        }

        public void AddAttendance(EventAttendance _eventAttendance)
        {
            _eventAttendanceRepository.AddAttendance(_eventAttendance);
        }

        public void UpdateAttendance(EventAttendance _eventAttendance)
        {
            _eventAttendanceRepository.UpdateAttendance(_eventAttendance);
        }
    }
}
