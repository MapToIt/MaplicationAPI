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
        private readonly MapService _mapService;

        public EventAttendanceService(IEventAttendanceRepository eventAttendanceRepository, IAttendeeRepository attendeeRepository,
                            ICompanyRepository companyRepository, ICoordinatorRepository coordinatorRepository, IMapRepository _mapRepository)
        {
            _eventAttendanceRepository = eventAttendanceRepository;
            _attendeeRepository = attendeeRepository;
            _companyRepository = companyRepository;
            _coordinatorRepository = coordinatorRepository;

            _mapService = new MapService(_mapRepository);
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
            if(rsvp.UserType.ToLower() == "attendee")
            {
                rsvp.UserType = _userService.GetUserType(rsvp.UserId);
            }
            else if (rsvp.UserType.ToLower() == "company")
            {
                Tables table = _mapService.GetEmptyTable(rsvp.Event);
                if(table != null)
                {
                    rsvp.UserType = _userService.GetUserType(rsvp.UserId);
                    Company company = _companyRepository.GetCompany(rsvp.UserId);
                    table.CompanyId = company.CompanyId;
                    table.Company = company;
                    _mapService.UpdateTable(table);
                }
                else
                {
                    return null;
                }
                
            }
            else
            {
                return null;
            }

            return _eventAttendanceRepository.InsertEventAttendance(rsvp);
        }
    }
}
