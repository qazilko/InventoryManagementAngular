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
    public class CheckBalrepository : ICheckBalRepository 
    {
        private readonly IDapperService _service;

        public CheckBalrepository(IDapperService dapperService)
        {
            _service = dapperService;
        }    

        
        public CheckBal GetCheckBalById(int Id)
        {
            return _service.GetAll<CheckBal>($"select RegId, (isnull(sum(Credit),0)-(isnull(sum(Debit),0)+ isnull(sum(BankCharges),0))) as BalAmount from [transaction] Where RegId=" + Id +" group by RegId", null, commandType: System.Data.CommandType.Text).FirstOrDefault();
            //return attendance;
        }
       
    }
}
