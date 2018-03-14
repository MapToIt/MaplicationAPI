using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class UserService
    {
        AttendeeService _attendeeService;
        CompanyService _companyService;
        CoordinatorService _coordinatorService;


        public UserService()
        {
        }

        public string GetUserType(string id)
        {
            bool isAttendee = _attendeeService.isAttendee(id);
            bool isCompany = _companyService.isCompany(id);
            bool isCoordinator = _coordinatorService.isCoordinator(id);

            return isAttendee ? "Attendee" : (isCoordinator ? "Coordinator" : (isCompany ? "Company" : null));
        }
    }
}
