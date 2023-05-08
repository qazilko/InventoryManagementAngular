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
    public class userrepository : IuserRepository 
    {
        private readonly IDapperService _service;

        public userrepository(IDapperService dapperService)
        {
            _service = dapperService;
        }

       

        public IEnumerable<user> Getusers()
        {
            return _service.GetAll<user>($"select Id, username, state from user", null, commandType: System.Data.CommandType.Text);
            //return attendance;
        }
        public user GetuserById(int Id)
        {
            return _service.GetAll<user>($"select Id, username, state from user Where Id =" + Id, null, commandType: System.Data.CommandType.Text).FirstOrDefault();
            //return attendance;
        }
        //public string Insertuser(user data)
        //{
        //    DynamicParameters parms = new DynamicParameters();
        //    parms.Add("@Id", data.Id);
        //    parms.Add("@username", data.username);
        //    parms.Add("@state", data.state);

        //    return _service.Insert<string>($"InsertUpdateuser", parms, commandType: System.Data.CommandType.StoredProcedure);

        //}

        public string InsertUpdateuser(int id, user data)
        {
            DynamicParameters parms = new DynamicParameters();
            parms.Add("@Id", data.Id);
            parms.Add("@username", data.username);
            parms.Add("@state", data.state);

            return _service.Update<string>($"InsertUpdateuser", parms, commandType: System.Data.CommandType.StoredProcedure);
        }
        public string Deleteuser(int id)
        {
            DynamicParameters parms = new DynamicParameters();
            parms.Add("@Id", id);
            return _service.Delete<string>($"Deleteuser", parms, commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}
