using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OpenDmsCore.Core.Entities;
using OpenDmsCore.Core.Interfaces;
using OpenDmsCore.Infrastructure.Data;

namespace OpenDmsCore.Infrastructure.Repositories
{
    public class TeamRepository : BaseRepository<Team>, ITeamRepository
	{
		public TeamRepository(OPEN_DMSContext context) : base(context)
		{
		}

        public async Task<IEnumerable<Team>> GetTeamsByCompanyId(int id)
        {
            var teams =  await _entities.ToListAsync();
            return teams.Where(x => x.EntityId == id);
        }
    }
}

