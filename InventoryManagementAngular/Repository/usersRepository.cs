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
    public class usersrepository : IusersRepository
    {
        private readonly IDapperService _service;

        public usersrepository(IDapperService dapperService)
        {
            _service = dapperService;
        }   

        //public IEnumerable<city> Getcitys()
        //{
        //    return _service.GetAll<city>($"select Id, cityname, state from city", null, commandType: System.Data.CommandType.Text);
        //    //return attendance;
        //}
        public users usersByEmail(string email, string password)
        {
            return _service.GetAll<users>($"select id, name, fname, email, password, role from registration Where email ='" + email + "' and password='" + password + "'", null, commandType: System.Data.CommandType.Text).FirstOrDefault();
            //return attendance;
        }       
    }
}
