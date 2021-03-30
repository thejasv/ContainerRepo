using dockertraining.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dockertraining.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesRepository repository;
        public MoviesController(MoviesRepository repo)
        {
            repository = repo;
        }
        // GET: api/<MoviesController>
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            var movies= repository.GetItems();
            if (movies.Count() == 0)
                return BadRequest("No movies found");
            else
                return Ok(movies);

        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var movie = repository.GetItemById(id);
            if (movie == null)
                return BadRequest("movie with id" + id + "is not found");
            else
                return Ok(movie);
        }

        // POST api/<MoviesController>
        [HttpPost]
        public ActionResult<Movie> Post([FromBody] Movie movie)
        {
            if(movie!=null)
            {
                repository.AddItem(movie);
                return Ok(movie);
            }
            else
            {
                return BadRequest("movie cannot be added");
            }
        }

        // PUT api/<MoviesController>/5
        
    }
}
