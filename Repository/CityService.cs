using APIBookMyShowD.Database;
using APIBookMyShowD.Entities;
using APIBookMyShowD.Services;


namespace APIBookMyShowD.Repository
{
    public class CityService : ICityService
    { 
        private readonly MyContext _context;

        public CityService()
        {
            _context = new MyContext();
        }

        public void AddCity(City city)
        {
            try
            {
                _context.Cities.Add(city);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteCity(string cityId)
        {
            try
            {
                City city = _context.Cities.Find(cityId);
                _context.Cities.Remove(city);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

      

        public City GetByCityID(string cityID)
        {
            try
            {
              //  City city = _context.Cities.Find(cityID);
               City city = _context.Cities.SingleOrDefault(c => c.CityId == cityID);
                return city;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateCity(City city)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAllCities()
        {
            try
            {
                return _context.Cities.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
