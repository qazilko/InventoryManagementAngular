using InventoryManagementAngular.Models;
using InventoryManagementAngular.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryManagementAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly IuserRepository _userrepository;

        public userController(IuserRepository userRepository)
        {
            _userrepository = userRepository;
        }


        // GET: api/<userController>
        [HttpGet]
        public IEnumerable<user> Get()
        {
            return _userrepository.Getusers();
        }

        [HttpGet("GetuserById/{Id}")]
        public user GetuserById(int Id)
        {
            return _userrepository.GetuserById(Id);
        }

        // GET api/<userController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // GET api/<userController>/5

        // POST api/<userController>
        [HttpPost]
        public string Post(int id, [FromBody] user data)
        {
            try
            {
                return _userrepository.InsertUpdateuser(id, data);

            }
            catch (Exception ex)
            {

                return ex.ToString();
            }

        }

        // PUT api/<userController>/5
        [HttpPut("{id}")]
        public String Put(int id, [FromBody] user data)
        {
            try
            {
                return _userrepository.InsertUpdateuser(id, data);

            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }

        // DELETE api/<userController>/5
        [HttpDelete("{id}")]
        public String Deleteuser(int id)
        {

            try
            {
                return _userrepository.Deleteuser(id);

            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
    }
}
