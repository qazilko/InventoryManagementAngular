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
    public class transactionrepository : ItransactionRepository
    {
        private readonly IDapperService _service;

        public transactionrepository(IDapperService dapperService)
        {
            _service = dapperService;
        }

       

        public IEnumerable<transaction> Gettransactions()
        {
            return _service.GetAll<transaction>($"select Id, Date, Credit, Debit, BankCharges, RegId from [transaction]", null, commandType: System.Data.CommandType.Text);
            //return attendance;
        }
        public List<transaction> GetTransactionById(int Id)
        {
            List<transaction> obj = new List<transaction>();
            obj=_service.GetAll<transaction>($"select RegId, Date, Credit, Debit, BankCharges, (isnull(sum(Credit),0)-(isnull(sum(Debit),0)+ isnull(sum(BankCharges),0))) as BalAmount from [transaction] Where RegId= "+ Id + " group by RegId,Date,Credit,Debit,BankCharges", null, commandType: System.Data.CommandType.Text).ToList();
            return obj;
        }
        public string InsertTransaction(transaction data)
        {
            DynamicParameters parms = new DynamicParameters();
            parms.Add("@date", data.Date);
            parms.Add("@Credit", data.Credit);
            parms.Add("@Debit", data.Debit);
            parms.Add("BankCharges", data.BankCharges);
            parms.Add("@RegId", data.RegId);

            return _service.Insert<string>($"InsertTransaction", parms, commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}
