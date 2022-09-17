using Database.Chess;
using Database.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamesAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChessController : ControllerBase
    {

        [HttpGet(Name = "Standard Leaderboard")]
        public IEnumerable<Leaderboard> Standard_Leaderboard()
        {
            return Standard.getLeaderboard();
        }
    }
}
