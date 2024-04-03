using BlazorApi.Data;
using BlazorApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApi.Services
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
           var games = await _context.Games.ToListAsync();

            return games;
         }
    }
}
