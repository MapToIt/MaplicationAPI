using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class AttendeeService
    {
        private readonly IAttendeeRepository _attendeeRepository;

        public AttendeeService(IAttendeeRepository attendeeRepository)
        {
            _attendeeRepository = attendeeRepository;
        }

        public List<Attendee> GetAttendees()
        {
            return _attendeeRepository.BrowseAttendees();
        }

        public Attendee GetAttendee(string id)
        {
            return _attendeeRepository.GetAttendee(id);
        }

        public Attendee InsertAttendee(Attendee attendee)
        {
            return _attendeeRepository.InsertAttendee(attendee);
        }

        public Attendee UpdateAttendee(Attendee attendee)
        {
            if (_attendeeRepository.isAttendee(attendee.UserId))
                return _attendeeRepository.UpdateAttendee(attendee);
            else
                return null;
        }

        public bool isAttendee(string id)
        {
            return _attendeeRepository.isAttendee(id);
        }

    }
}
