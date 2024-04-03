using BlazorApi.Shared.Entities;
using BlazorApi.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApi.Controllers
{
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;
        public GameController(IGameService gameService)
        {
            _gameService= gameService;
        }

        [HttpPost]
        public async Task<ActionResult<Game>> AddGame(Game game)
        {
            var addedGame = await _gameService.AddGames(game);
            return Ok(addedGame);
        }
    }
}
