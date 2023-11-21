using APIBookMyShowD.Entities;

namespace APIBookMyShowD.Services
{
    public interface IMovieService
    {
        void CreateMovie(Movie movies);
        void UpdateMovie();
        void DeleteMovie(string MovieId);
        List< Movie> GetAllMovies();
        List<Movie> GetMoviesByMultiplkex(string multiplexId);




    }
    
}
