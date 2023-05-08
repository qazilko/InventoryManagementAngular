using InventoryManagementAngular.Models;
using InventoryManagementAngular.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryManagementAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class transactionController : ControllerBase
    {
        private readonly ItransactionRepository _transactionrepository;

        public transactionController(ItransactionRepository transactionRepository )
        {
            _transactionrepository = transactionRepository;
        }
        // GET: api/<transactionController>
        [HttpGet]
        public IEnumerable<transaction> Get()
        {
            return _transactionrepository.Gettransactions();
        }
        [HttpGet("GetTransactionBalById/{Id}")]
        public IEnumerable<transaction> GetTransactionById(int Id)
        {
            return _transactionrepository.GetTransactionById(Id);
        }

        // GET api/<transactionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<transactionController>
        [HttpPost]
        public string Post([FromBody] transaction data)
        {
            try
            {
                return _transactionrepository.InsertTransaction(data);

            }
            catch (Exception ex)
            {

                return ex.ToString();
            }

        }

        // DELETE api/<transactionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
