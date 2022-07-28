using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OpenDmsCore.Api.Responses;
using OpenDmsCore.Core.DTOs;
using OpenDmsCore.Core.Entities;
using OpenDmsCore.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDmsCore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamService;
        private readonly IMapper _mapper;
        public TeamsController(ITeamService teamService, IMapper mapper)
        {
            _teamService = teamService;
            _mapper = mapper;
        }

        [HttpGet("{companyId}")]
        public async Task<ActionResult> Get(int companyId)
        {
            var teams = await _teamService.GetTeamsByCompanyId(companyId);
            var teamsDto = _mapper.Map<IEnumerable<TeamDto>>(teams);
            var response = new ApiResponse
            {
                Data = teamsDto,
                Success = true
            };
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(TeamDto teamDto)
        {
            var team = _mapper.Map<Team>(teamDto);
            await _teamService.InsertTeam(team);
            teamDto = _mapper.Map<TeamDto>(team);
            var response = new ApiResponse
            {
                Code = "200",
                Data = teamDto,
                Success = true
            };
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, TeamDto teamDto)
        {
            var team = _mapper.Map<Team>(teamDto);
            team.Id = id;
            team.Disabled = true;
            var result = await _teamService.UpdateTeam(team);
            var response = new ApiResponse
            {
                Success = result
            };
            return Ok(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _teamService.DeleteTeam(id);
            var response = new ApiResponse
            {
                Success = result
            };
            return Ok(response);
        }
    }
}
