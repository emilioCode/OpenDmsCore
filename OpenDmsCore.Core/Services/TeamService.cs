using OpenDmsCore.Core.Entities;
using OpenDmsCore.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenDmsCore.Core.Services
{
    public class TeamService : ITeamService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TeamService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Team>> GetTeams()
        {
            return await _unitOfWork.TeamRepository.GetAll();
        }

        public Task<Team> GetTeamById(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTeam(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Team>> GetTeamsByCompanyId(int id)
        {
            var teams = await _unitOfWork.TeamRepository.GetAll();
            teams = teams.ToList().Where(x => x.EntityId == id);
            return teams;
        }
    }
}
