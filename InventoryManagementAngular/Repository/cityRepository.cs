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
    public class cityrepository : IcityRepository 
    {
        private readonly IDapperService _service;

        public cityrepository(IDapperService dapperService)
        {
            _service = dapperService;
        }

       

        public IEnumerable<city> Getcitys()
        {
            return _service.GetAll<city>($"select Id, cityname, state from city", null, commandType: System.Data.CommandType.Text);
            //return attendance;
        }
        public city GetcityById(int Id)
        {
            return _service.GetAll<city>($"select Id, cityname, state from city Where Id =" + Id, null, commandType: System.Data.CommandType.Text).FirstOrDefault();
            //return attendance;
        }
        //public string InsertCity(city data)
        //{
        //    DynamicParameters parms = new DynamicParameters();
        //    parms.Add("@Id", data.Id);
        //    parms.Add("@cityname", data.cityname);
        //    parms.Add("@state", data.state);

        //    return _service.Insert<string>($"InsertUpdateCity", parms, commandType: System.Data.CommandType.StoredProcedure);

        //}

        public string InsertUpdateCity(int id, city data)
        {
            DynamicParameters parms = new DynamicParameters();
            parms.Add("@Id", data.Id);
            parms.Add("@cityname", data.cityname);
            parms.Add("@state", data.state);

            return _service.Update<string>($"InsertUpdateCity", parms, commandType: System.Data.CommandType.StoredProcedure);
        }
        public string DeleteCity(int id)
        {
            DynamicParameters parms = new DynamicParameters();
            parms.Add("@Id", id);
            return _service.Delete<string>($"DeleteCity", parms, commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}
