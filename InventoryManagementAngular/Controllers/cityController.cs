using InventoryManagementAngular.Models;
using InventoryManagementAngular.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryManagementAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class cityController : ControllerBase
    {
        private readonly IcityRepository _cityrepository;

        public cityController(IcityRepository cityRepository)
        {
            _cityrepository = cityRepository;
        }


        // GET: api/<cityController>
        [HttpGet]
        public IEnumerable<city> Get()
        {
            return _cityrepository.Getcitys();
        }

        [HttpGet("GetcityById/{Id}")]
        public city GetcityById(int Id)
        {
            return _cityrepository.GetcityById(Id);
        }

        // GET api/<cityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // GET api/<cityController>/5

        // POST api/<cityController>
        [HttpPost]
        public string Post(int id, [FromBody] city data)
        {
            try
            {
                return _cityrepository.InsertUpdateCity(id, data);

            }
            catch (Exception ex)
            {

                return ex.ToString();
            }

        }

        // PUT api/<cityController>/5
        [HttpPut("{id}")]
        public String Put(int id, [FromBody] city data)
        {
            try
            {
                return _cityrepository.InsertUpdateCity(id, data);

            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }

        // DELETE api/<cityController>/5
        [HttpDelete("{id}")]
        public String Deletecity(int id)
        {

            try
            {
                return _cityrepository.DeleteCity(id);

            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
    }
}
