using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIBookMyShowD.Repository;
using APIBookMyShowD.Services;
using APIBookMyShowD.Entities;

namespace APIBookMyShowD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService cityService;

        public CityController()
        {

            cityService = new CityService();
        }

        [HttpGet,Route("GetAllCities")]
       
        public IActionResult GetAllCities()
        {

            try
            {
                List<City> cities = cityService.GetAllCities();
                return StatusCode(200, cities);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost,Route("AddCity")]
      
        public IActionResult Add([FromBody]City city) 
        {
            try
            {
                cityService.AddCity(city);
                return StatusCode(200, city);
            }
            catch (Exception)
            {

                throw;
            }
        
        }
        //delete /delete City
        [HttpDelete, Route("deleteCity/{CityId}")]
       
        public IActionResult Delete( [FromBody]string cityId)
        {

            try
            {

                cityService.DeleteCity(cityId);
                return StatusCode(200, new JsonResult($"City with Id {cityId} is deleted"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet, Route("GetCityById/{CityId}")]
        

        public IActionResult GetByCityId([FromBody]string cityId)
        {
            try
            {
                City city = cityService.GetByCityID(cityId);
                if (city != null)
                    return StatusCode(200, city);
                else
                    return StatusCode(404, new JsonResult("Invalid CityId"));

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


    }
}
