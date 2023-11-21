using APIBookMyShowD.Entities;
namespace APIBookMyShowD.Services
{
    public interface IMultiplexServices
    {
        void create(Multiplex multiplex);
        void update(Multiplex multiplex);
        void delete(Multiplex multiplex);
        List<Multiplex>    GetAllByCity(City Cityid);
        List<Multiplex> GetAllByMovie(Movie MovieName);

    }
}
