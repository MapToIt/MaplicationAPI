using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace MaplicationAPI.Repositories
{
    public class CoordinatorRepository : ICoordinatorRepository
    {
        private readonly EntityFramework.MaplicationContext _context;

        public CoordinatorRepository(MaplicationContext context)
        {
            _context = context;
        }

        public List<Coordinator> BrowseCoords()
        {
            return _context.Coordinator.AsNoTracking().ToList();
        }

        public Coordinator BrowseCoordById(string id)
        {
            return _context.Coordinator.Where(c => c.UserId == id).FirstOrDefault();
        }

        public bool IsCoordinator(string id)
        {
            return _context.Coordinator.Any(a => a.UserId == id);
        }

        public Coordinator AddCoord(Coordinator coordinator)
        {
            if(coordinator != null) {
                _context.Coordinator.Add(coordinator);
                _context.SaveChanges();
            }

            return coordinator;
        }

        public Coordinator UpdateCoord(Coordinator coordinator)
        {
            if(coordinator != null)
            {
                var existingCoord = _context.Coordinator.Where(c => c.CoordinatorId == coordinator.CoordinatorId).FirstOrDefault();
                
                if (existingCoord != null)
                {
                    existingCoord.FirstName = coordinator.FirstName;
                    existingCoord.LastName = coordinator.LastName;
                    existingCoord.Email = coordinator.Email;
                    existingCoord.PhoneNumber = coordinator.PhoneNumber;

                    _context.SaveChanges();

                    return existingCoord;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

    }
}
