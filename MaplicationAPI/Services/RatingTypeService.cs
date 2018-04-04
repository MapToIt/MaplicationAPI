using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class RatingTypeService
    {
        private readonly IRatingTypeRepository _RatingTypeRepository;

        public RatingTypeService(IRatingTypeRepository RatingTypeRepository)
        {
            _RatingTypeRepository = RatingTypeRepository;
        }

        public List<RatingType> GetRatingType()
        {
            return _RatingTypeRepository.BrowseRatingType();
        }

    }
}
