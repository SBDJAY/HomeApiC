

using Microsoft.AspNetCore.Mvc;
using HomeApi.Models;

namespace HomeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomesController : ControllerBase
    {
        private static List<Home> homes = new()
        {
            new Home
            {
                House = "36 Prosperity Pathway",
                Town = "Toronto",
                Price = 849000,
                Bed = "3+1",
                Bath = 4,
                SaleStatus = "For Sale",
                Distance = "1 hour",
                PosterImageName = "homeMalvern",
                Description = "North American suburban Beige Brick Accents 3 + 1 Bedrooms and 4 Bathrooms."
            },
            new Home
            {
                House = "47 Eight Street ",
                Town = "Toronto",
                Price = 2288000,
                Bed = "3+1",
                Bath = 4,
                SaleStatus = "For Sale",
                Distance = "2 hour",
                PosterImageName = "homeNewToronto",
                Description = "Contemporary Desgined home with lighbrown brick"
            }
        };

        [HttpGet]
        public ActionResult<List<Home>> GetHomes() => Ok(homes);

        [HttpGet("{id}")]
        public ActionResult<Home> GetHome(string id)
        {
            var home = homes.FirstOrDefault(h => h.Id == id);
            if (home == null) return NotFound();
            return Ok(home);
        }

        [HttpPost]
        public IActionResult CreateHome(Home home)
        {
            if (string.IsNullOrEmpty(home.Id))
                home.Id = Guid.NewGuid().ToString();

            homes.Add(home);
            return CreatedAtAction(nameof(GetHome), new { id = home.Id }, home);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateHome(string id, Home updatedHome)
        {
            var home = homes.FirstOrDefault(h => h.Id == id);
            if (home == null) return NotFound();

            home.House = updatedHome.House;
            home.Town = updatedHome.Town;
            home.Price = updatedHome.Price;
            home.Bed = updatedHome.Bed;
            home.Bath = updatedHome.Bath;
            home.SaleStatus = updatedHome.SaleStatus;
            home.Distance = updatedHome.Distance;
            home.PosterImageName = updatedHome.PosterImageName;
            home.Description = updatedHome.Description;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHome(string id)
        {
            var home = homes.FirstOrDefault(h => h.Id == id);
            if (home == null) return NotFound();

            homes.Remove(home);
            return NoContent();
        }
    }
}
