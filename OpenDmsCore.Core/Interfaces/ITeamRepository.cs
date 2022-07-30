using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDmsCore.Core.Entities;

namespace OpenDmsCore.Core.Interfaces
{
    public interface ITeamRepository : IRepository<Team>
    {
        Task<IEnumerable<Team>> GetTeamsByCompanyId(int id);
    }
}

