using InventoryManagementAngular.Models;
using InventoryManagementAngular.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryManagementAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class registrationController : ControllerBase
    {
        private readonly IregistrationRepository _registrationrepository;

        public registrationController(IregistrationRepository registrationRepository )
        {
            _registrationrepository = registrationRepository;
        }
        // GET: api/<registrationController>
        [HttpGet]
        public IEnumerable<registration> Get()
        {
            return _registrationrepository.Getregistrations();
        }
        [HttpGet("GetregistrationById/{Id}")]
        public IEnumerable<registration> GetregistrationById(int Id)
        {
            return _registrationrepository.GetRegistrationById(Id);
        }

        // GET api/<registrationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // GET api/<registrationController>/5

        // POST api/<registrationController>
        [HttpPost]
        public string Post(int id, [FromBody] registration data)
        {
            try
            {
                return _registrationrepository.InsertUpdateRegistration(id, data);

            }
            catch (Exception ex)
            {

                return ex.ToString();
            }

        }

        // PUT api/<registrationController>/5
        [HttpPut("{id}")]
        public String Put(int id, [FromBody] registration data)
        {
            try
            {
                return _registrationrepository.InsertUpdateRegistration(id, data);

            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }

        // DELETE api/<registrationController>/5
        [HttpDelete("{id}")]
        public String Deleteregistration(int id)
        {

            try
            {
                return _registrationrepository.DeleteRegistration(id);

            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
    }
}
