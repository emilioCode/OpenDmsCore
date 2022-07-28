using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenDmsCore.Core.Interfaces;
using System.Threading.Tasks;

namespace OpenDmsCore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamService;
        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet("{companyId}")]
        public async Task<ActionResult> Get(int companyId)
        {
            var teams = await _teamService.GetTeamsByCompanyId(companyId);
            return Ok(teams);
        }
    }
}
