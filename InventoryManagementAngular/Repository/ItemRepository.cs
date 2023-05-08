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
    public class Itemrepository : IItemRepository 
    {
        private readonly IDapperService _service;

        public Itemrepository(IDapperService dapperService)
        {
            _service = dapperService;
        }

       

        public IEnumerable<Item> GetItems()
        {
            return _service.GetAll<Item>($"select Id, Name from Item", null, commandType: System.Data.CommandType.Text);
            //return attendance;
        }
    }
}
