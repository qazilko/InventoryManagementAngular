using InventoryManagementAngular.Models;
using InventoryManagementAngular.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryManagementAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }


        // GET: api/<SupplierController>
        [HttpGet]
        public IEnumerable<Supplier> Get()
        {
            return _supplierRepository.GetSupplier();
        }

        [HttpGet("GetSupplierByName/{Name}")]
        public IEnumerable<Supplier> GetSupplierByName(String Name)
        {
            return _supplierRepository.GetSupplierByName(Name);
        }

        // GET api/<SupplierController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // GET api/<SupplierController>/5
       
        // POST api/<SupplierController>
        [HttpPost]
        public string Post([FromBody] Supplier data)
        {
            try
            {
                return _supplierRepository.InsertSupplier(data);
               
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
            
        }

        // PUT api/<SupplierController>/5
        [HttpPut("{id}")]
        public String  Put(int id,[FromBody] Supplier data)
        {
            try
            {
                return _supplierRepository.UpdateSupplier(id,data);

            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }

        // DELETE api/<SupplierController>/5
        [HttpDelete("{id}")]
        public String DeleteSupplier(int id)
        {

            try
            {
                return _supplierRepository.DeleteSupplier(id);

            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
    }
}
