using Dapper;
using InventoryManagementAngular.Models;
using InventoryManagementAngular.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace InventoryManagementAngular.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly IDapperService _service;

        public SupplierRepository(IDapperService dapperService)
        {
            _service = dapperService;
        }
        [HttpGet]
        public IEnumerable<Supplier> GetSupplier()
        {   
            return _service.GetAll<Supplier>($"select Id, Name,CreatedBy from Supplier", null, commandType: System.Data.CommandType.Text);
            //return attendance;
        }
        public IEnumerable<Supplier> GetSupplierByName(string SupplierName)
        {  
            return _service.GetAll<Supplier>($"select Id, Name from Supplier Where Name = '" + SupplierName + "'", null, commandType: System.Data.CommandType.Text);
            //return attendance;
        }
        public string InsertSupplier(Supplier data)
        {
            DynamicParameters parms = new DynamicParameters();
            parms.Add("@Name", data.Name);
            parms.Add("@CreatedBy", data.CreatedBy);        

            return _service.Insert<string>($"InsertSupplier", parms, commandType: System.Data.CommandType.StoredProcedure);
            
        }

        public string UpdateSupplier(int id, Supplier data)
        {
            DynamicParameters parms = new DynamicParameters();
            parms.Add("@Id", id);          
            parms.Add("@Name", data.Name);
            parms.Add("@CreatedBy", data.CreatedBy);

            return _service.Update<string>($"UpdateSupplier", parms, commandType: System.Data.CommandType.StoredProcedure);
        }
        public string DeleteSupplier(int id)
        {
            DynamicParameters parms = new DynamicParameters();
            parms.Add("@Id", id);
           return _service.Delete<string>($"DeleteSupplier", parms, commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}
