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

        public async Task InsertTeam(Team team)
        {
            await _unitOfWork.TeamRepository.Add(team);
        }

        public async Task<bool> UpdateTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteTeam(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Team>> GetTeamsByCompanyId(int id)
        {
            return await _unitOfWork.TeamRepository.GetTeamsByCompanyId(id);
        }
    }
}
