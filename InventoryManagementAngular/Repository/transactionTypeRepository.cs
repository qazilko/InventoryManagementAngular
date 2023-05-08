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
    public class transactionTyperepository : ItransactionTypeRepository 
    {
        private readonly IDapperService _service;

        public transactionTyperepository(IDapperService dapperService)
        {
            _service = dapperService;
        }

       

        public IEnumerable<transactionType> GettransactionTypes()
        {
            return _service.GetAll<transactionType>($"select Id, Type from transactionType", null, commandType: System.Data.CommandType.Text);
            //return attendance;
        }
    }
}
