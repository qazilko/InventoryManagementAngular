using Dapper;
using InventoryManagementAngular.Models;
using InventoryManagementAngular.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Versioning;
using System.Xml.Linq;

namespace InventoryManagementAngular.Repository
{
    public class registrationrepository : IregistrationRepository
    {
        private readonly IDapperService _service;

        public registrationrepository(IDapperService dapperService)
        {
            _service = dapperService;
        }     

        public IEnumerable<registration> Getregistrations()
        {
            return _service.GetAll<registration>($"select ID, filename, filepath, name, fname, dob, email, mobileno, qualification, address, city, state, zipcode from registration", null, commandType: System.Data.CommandType.Text);
            //return attendance;
        }
        public IEnumerable<registration> GetRegistrationById(int Id)
        {
            return _service.GetAll<registration>($"select Id, filename, filepath, name, fname, dob, email, mobileno, qualification, address, city, state, zipcode from registration Where Id =" + Id, null, commandType: System.Data.CommandType.Text);
            //return attendance;
        }
        //public string InsertRegistration(registration data)
        //{
        //    DynamicParameters parms = new DynamicParameters();
        //    parms.Add("@name", data.name);
        //    parms.Add("@fname", data.fname);
        //    parms.Add("@dob", data.dob);
        //    parms.Add("@email", data.email);
        //    parms.Add("@mobileno", data.mobileno);
        //    parms.Add("@qualification", data.qualification);
        //    parms.Add("@address", data.address);
        //    parms.Add("@city", data.city);
        //    parms.Add("@state", data.state);
        //    parms.Add("@zipcode", data.zipcode);          
        //    return _service.Insert<string>($"InsertRegistration", parms, commandType: System.Data.CommandType.StoredProcedure);

        //}
        public string InsertUpdateRegistration(int id, registration data)
        {
            DynamicParameters parms = new DynamicParameters();
            parms.Add("@Id", id);
            parms.Add("@name", data.name);
            parms.Add("@fname", data.fname);
            parms.Add("@dob", data.dob);
            parms.Add("@email", data.email);
            //parms.Add("@password", "12345678");//data.password
            //parms.Add("@role", "User");
            parms.Add("@mobileno", data.mobileno);
            parms.Add("@qualification", data.qualification);
            parms.Add("@address", data.address);
            parms.Add("@city", data.city);
            parms.Add("@state", data.state);
            parms.Add("@zipcode", data.zipcode);
            return _service.Update<string>($"InsertUpdateRegistration", parms, commandType: System.Data.CommandType.StoredProcedure);
        }
        public string DeleteRegistration(int id)
        {
            DynamicParameters parms = new DynamicParameters();
            parms.Add("@Id", id);
            return _service.Delete<string>($"DeleteRegistration", parms, commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}

