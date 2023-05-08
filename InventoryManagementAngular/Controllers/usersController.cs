using InventoryManagementAngular.Models;
using InventoryManagementAngular.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryManagementAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usersController : ControllerBase
    {
        private readonly IusersRepository _usersrepository;

        public usersController(IusersRepository usersRepository )
        {
            _usersrepository = usersRepository;
        }
        
        [HttpGet()]
        public string usersByEmail(string email, string password)
        {
            return "value";
        }

       
    }
}
