using netapi.Models;
using netapi.Interface;
using System.Collections.Generic;
using System.Linq;
namespace netapi.Repository
{
    public class HeroRepo : IHeroes
    {
        List<Hero> listHero = new List<Hero>
        {
            new Hero{id=1, name="Abadon", type="Universal", description="Vadodara" },
            new Hero{id=2, name="Alchemist", type="Universal", description="Vadodara" },
            new Hero{id=3, name="Acneint Apparition", type="Universal", description="Vadodara" },
            new Hero{id=4, name="Anti-Mage", type="Universal", description="Vadodara" },
            new Hero{id=5, name="Batrider", type="Universal", description="Vadodara" },
        };
        public List<Hero> GetAllHero()
        {
            return listHero;
        }
        public Hero GetHeroById(int id)
        {
            return listHero.FirstOrDefault(x => x.id == id);
        }

        public Hero GetHeroByName(string name)
        {
            return listHero.FirstOrDefault(x => x.name.ToLower() == name.ToLower());
        }

    }
}
