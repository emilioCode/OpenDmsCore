using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OpenDmsCore.Api.Responses;
using OpenDmsCore.Core.DTOs;
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
    }
}
