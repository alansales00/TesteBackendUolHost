using Microsoft.AspNetCore.Mvc;
using TesteBackendUol.Models;
using TesteBackendUol.Services;


namespace TesteBackendUol.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IAvengersService _avengersService;
        private readonly IJusticeLeagueService _justiceLeagueService;
        private readonly ICommonService _commonService;

        public UserController(IAvengersService avengersService, IJusticeLeagueService justiceLeagueService, ICommonService commonService)
        {
            _avengersService = avengersService;
            _justiceLeagueService = justiceLeagueService;
            _commonService = commonService;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            if (user.Grupo == "vingadores")
            {
                var response = await _avengersService.RegisterUser(user);
                return Ok(response);
            }
            if (user.Grupo == "liga da justica")
            {
                var response = await _justiceLeagueService.RegisterUser(user);
                return Ok(response);
            }

            return BadRequest();

        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var response = await _commonService.GetAllUsers();
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, User user)
        {
            var response = await _commonService.UpdateUser(id, user);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var response = await _commonService.DeleteUser(id);
            return Ok(response);
        }
    }
}
