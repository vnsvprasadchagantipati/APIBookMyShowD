using APIBookMyShowD.Database;
using APIBookMyShowD.Entities;
using APIBookMyShowD.Services;

namespace APIBookMyShowD.Repository
{
    public class MovieService : IMovieService
    {
        private readonly MyContext _context;

        public MovieService()
        {

            _context = new MyContext();
        }
        public void CreateMovie(Movie movies)
        {
            try
            {
                _context.Movies.Add(movies);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        public void DeleteMovie(string MovieId)
        {
            try
            {
                Movie movie = _context.Movies.FirstOrDefault(m => m.MovieId == MovieId);
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Movie> GetAllMovies()
        {
            try
            {
                return _context.Movies.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        public void UpdateMovie()
        {
        }

        List<Movie> IMovieService.GetMoviesByMultiplkex(string multiplexId)
        {
          return  _context.Movies.Where(m=>m.MultiplexID==multiplexId).ToList();
        }
    }
}
