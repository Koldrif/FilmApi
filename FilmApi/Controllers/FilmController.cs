using FilmApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmApi.Controllers
{
    public class FilmController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddFilm([FromBody] Film film)
        {
            // Check and add film to Data Base via film service or film repos
            return Ok(film);
        }

        [HttpGet]
        public IActionResult GetFilm(int? id = null, string name = null)
        {
            // Fill field or you can make in return
            return Ok(new Film()
            {
                // Fill fields 
            });
        }

        [HttpPut]
        public IActionResult AlterFilm([FromBody] Film film)
        {
            // Add new changes to film ...
            return Ok(); // If operation was successful
        }

        [HttpDelete]
        public IActionResult DeleteFilm(int id)
        {
            // Delete film via id ...
            return Ok(); // If deleting was successful
        }
    }
}
