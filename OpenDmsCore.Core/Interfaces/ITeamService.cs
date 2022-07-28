using OpenDmsCore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenDmsCore.Core.Interfaces
{
    public interface ITeamService
    {
        Task<IEnumerable<Team>> GetTeams();
        Task<Team> GetTeamById(int id);
        Task<IEnumerable<Team>> GetTeamsByCompanyId(int id);
        Task InsertTeam(Team team);
        Task<bool> UpdateTeam(Team team);
        Task<bool> DeleteTeam(int id);
    }
}
