using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class ChipsService
    {
        private readonly IChipsRepository _ChipsRepository;

        public ChipsService(IChipsRepository ChipsRepository)
        {
            _ChipsRepository = ChipsRepository;
        }

        public List<Tags> GetChips()
        {
            return _ChipsRepository.BrowseChips();
        }

    }
}
