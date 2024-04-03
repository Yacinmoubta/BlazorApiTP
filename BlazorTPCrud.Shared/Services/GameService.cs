using BlazorApi.Shared.Data;
using BlazorApi.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApi.Shared.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _context;

        public GameService(DataContext context)
        {
            _context = context;
        }

        public async Task<Game> AddGames(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();
            return game;
        }

       
        public async Task<List<Game>> GetAllGames()
        {
            await Task.Delay(1000);
           var games = await _context.Games.ToListAsync();

            return games;
         }
    }
}
