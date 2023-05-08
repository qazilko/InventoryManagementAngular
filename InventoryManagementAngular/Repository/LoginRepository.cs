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
    public class Loginrepository : ILoginRepository
    {
        private readonly IDapperService _service;

        public Loginrepository(IDapperService dapperService)
        {
            _service = dapperService;
        }   

        //public IEnumerable<city> Getcitys()
        //{
        //    return _service.GetAll<city>($"select Id, cityname, state from city", null, commandType: System.Data.CommandType.Text);
        //    //return attendance;
        //}
        public Login LoginByEmail(string email, string password)
        {
            return _service.GetAll<Login>($"select email, password from registration Where email ='" + email + "' and password='" + password + "'", null, commandType: System.Data.CommandType.Text).FirstOrDefault();
            //return attendance;
        }       
    }
}
