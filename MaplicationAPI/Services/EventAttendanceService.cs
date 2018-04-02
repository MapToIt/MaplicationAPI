using MaplicationAPI.EntityFramework;
using MaplicationAPI.Models;
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
        private readonly IAttendeeRepository _attendeeRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly ICoordinatorRepository _coordinatorRepository;
        private readonly UserService _userService;

        public EventAttendanceService(IEventAttendanceRepository eventAttendanceRepository, IAttendeeRepository attendeeRepository,
                            ICompanyRepository companyRepository, ICoordinatorRepository coordinatorRepository)
        {
            _eventAttendanceRepository = eventAttendanceRepository;
            _attendeeRepository = attendeeRepository;
            _companyRepository = companyRepository;
            _coordinatorRepository = coordinatorRepository;

            _userService = new UserService(_attendeeRepository, _companyRepository, _coordinatorRepository);
        }

        public List<EventAttendance> GetEventAttendanceByAttendee(int id)
        {
            return _eventAttendanceRepository.GetEventAttendanceByAttendee(id);
        }

        public List<EventAttendance> GetEventAttendanceByCompany(int id)
        {
            return _eventAttendanceRepository.GetEventAttendanceByCompany(id);
        }

        public List<EventAttendance> GetEventAttendanceByEvent(int id)
        {
            List<EventAttendance> eventAttendance = new List<EventAttendance>();
            List<EventAttendance> companyAttendance = new List<EventAttendance>();
            List<EventAttendance> attendeeAttendance = new List<EventAttendance>();

            companyAttendance = _eventAttendanceRepository.GetEventAttendanceByAttendee(id);
            attendeeAttendance = _eventAttendanceRepository.GetEventAttendanceByCompany(id);

            foreach(EventAttendance attend in companyAttendance)
            {
                eventAttendance.Add(attend);                
            }

            foreach (EventAttendance attend in attendeeAttendance)
            {
                eventAttendance.Add(attend);
            }

            return eventAttendance;
        }

        public List<EventAttendance> GetEventAttendanceByUser(string id)
        {
            return _eventAttendanceRepository.GetEventAttendanceByUser(id);
        }

        public EventAttendance InsertEventAttendance(RSVP rsvp)
        {
            rsvp.UserType = _userService.GetUserType(rsvp.UserId);
            return _eventAttendanceRepository.InsertEventAttendance(rsvp);
        }
    }
}
