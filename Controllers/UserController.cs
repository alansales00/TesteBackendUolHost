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

        public UserController(IAvengersService avengersService, IJusticeLeagueService justiceLeagueService)
        {
            _avengersService = avengersService;
            _justiceLeagueService = justiceLeagueService;
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
    }
}
