using CityInfo.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {

            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id) 
        { 
            var returnCity = CitiesDataStore.Current.Cities
                .FirstOrDefault(x => x.Id == id);

            if (returnCity == null)
            {
                return NotFound();
            }

            return Ok(returnCity);
        }
    }
}
