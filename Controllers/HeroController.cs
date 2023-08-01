using Microsoft.AspNetCore.Mvc;
using netapi.Repository;
using netapi.Interface;
using netapi.Models;
using System.Net;
using System.Net.Http.Headers;

namespace netapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : Controller
    {
        private IHeroes heroes = new HeroRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Hero>> GetAllHero()
        {
            return heroes.GetAllHero();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Hero> GetHeroById(int id)
        {
            return heroes.GetHeroById(id);
        }

        [HttpGet("{name:alpha}")]
        public ActionResult<Hero> GetHeroByName(string name)
        {
            return heroes.GetHeroByName(name);
        }

        [HttpGet("GetImage")]
        public IActionResult Get(string filename)
        {

            string filePath = "/images/";
            string fullPath = System.IO.Directory.GetCurrentDirectory() + filePath + filename +".png";

            Byte[] b;

            b = System.IO.File.ReadAllBytes(fullPath);

            return File(b, "image/jpeg");
        }
    }
}
