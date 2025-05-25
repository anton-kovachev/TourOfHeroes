using TourOfHeroes.Models;

namespace TourOfHeroes.Services
{
    public interface IHeroesService
    {
        Task<List<Hero>> GetHeroes();
    }
}
