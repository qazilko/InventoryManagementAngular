using InventoryManagementAngular.Models;
using InventoryManagementAngular.Repository;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckBalController : ControllerBase
    {
        private readonly ICheckBalRepository _CheckBalrepository;
        public CheckBalController(ICheckBalRepository CheckBalRepository)
        {
            _CheckBalrepository = CheckBalRepository;
        }

        [HttpGet("GetCheckBalById/{Id}")]
        public CheckBal GetCheckBalById(int Id)
        {
            return _CheckBalrepository.GetCheckBalById(Id);
        }

        // GET api/<CheckBalController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
    }
}
