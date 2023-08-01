using netapi.Models;
namespace netapi.Interface
{
    public interface IHeroes
    {
        List<Hero> GetAllHero();
        Hero GetHeroById(int id);

        Hero GetHeroByName(string name);
        //Stream GetImageAsStream();
    }
}
