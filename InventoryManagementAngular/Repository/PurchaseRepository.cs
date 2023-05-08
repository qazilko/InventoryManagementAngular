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
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly IDapperService _service;

        public PurchaseRepository(IDapperService dapperService)
        {
            _service = dapperService;
        }
        public string InsertPurchase(InventoryManagement  data)
        {
            DynamicParameters parms = new DynamicParameters();
            parms.Add("@ItemId", data.ItemId);
            parms.Add("@SupplierId", data.SupplierId);
            parms.Add("@ItemQuantity", data.ItemQuantity);
            parms.Add("@ItemDate", data.ItemDate);
            parms.Add("@ItemType", data.ItemType);
            parms.Add("@BrandName", data.BrandName);
            parms.Add("@CostPrice", data.CostPrice);
            parms.Add("@Description", data.Description);

            return _service.Insert<string>($"InsertPurchaseForm", parms, commandType: System.Data.CommandType.StoredProcedure);

        }
    }
}
