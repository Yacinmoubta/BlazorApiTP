using BlazorApi.Shared.Entities;

namespace BlazorApi.Shared.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
        Task<Game> AddGames(Game game);
    }
}
