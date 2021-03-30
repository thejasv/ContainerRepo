using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dockertraining.Models
{
    public class MoviesRepository:IRepository<Movie>
    {
        public List<Movie> movies;
       
        
        public MoviesRepository()
        {
            movies = new List<Movie>();
            movies.Add(
                new Movie
                {
                    Id = 101,
                    Name = "xmen",
                    Duration = 2.05f
                }
                );

        }
        public void AddItem(Movie movie)
        {
            this.movies.Add(movie);
        }
        public IEnumerable<Movie> GetItems()
        {
            return this.movies;
        }
        public Movie GetItemById(int id)
        {
            return this.movies.Find(m => m.Id == id);

        }

       
    }
}
