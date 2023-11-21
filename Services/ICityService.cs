using APIBookMyShowD.Entities;
namespace APIBookMyShowD.Services
{
    public interface ICityService
    {
        void AddCity(City city);
        void UpdateCity(City city);
        void DeleteCity(string cityId);
        List<City> GetAllCities();
        City GetByCityID(string cityID);
    }
}
