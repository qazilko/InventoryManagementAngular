using InventoryManagementAngular.Models;
using InventoryManagementAngular.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryManagementAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _Loginrepository;

        public LoginController(ILoginRepository LoginRepository)
        {
            _Loginrepository = LoginRepository;
        }

        [HttpGet("LoginByEmail/{email},{password}")]
        public string LoginByEmail(string email, string password)
        {
            return "value";
        }

    }
}
