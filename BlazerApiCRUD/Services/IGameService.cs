using BlazorApi.Entities;

namespace BlazorApi.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
        Task<Game> AddGames(Game game);
    }
}
