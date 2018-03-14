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
        private readonly IAttendeeRepository _attendeeRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly ICoordinatorRepository _coordinatorRepository;


        public UserService(IAttendeeRepository attendeeRepository, ICompanyRepository companyRepository, ICoordinatorRepository coordinatorRepository)
        {
            _attendeeRepository = attendeeRepository;
            _companyRepository = companyRepository;
            _coordinatorRepository = coordinatorRepository;
            
        }

        public string GetUserType(string id)
        {
            bool isAttendee = _attendeeRepository.isAttendee(id);
            bool isCompany = _companyRepository.isCompany(id);
            bool isCoordinator = _coordinatorRepository.isCoordinator(id);

            return isAttendee ? "Attendee" : (isCoordinator ? "Coordinator" : (isCompany ? "Company" : null));
        }
    }
}
