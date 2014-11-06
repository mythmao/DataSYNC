using DataSYNC.BLL;
using DataSYNC.Model;
using DataSYNC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataSYNC.BLLs
{
    public class CustomerAssetObject : ITableObject
    {
        public string GetTableData(string tableName, DateTime lastUpdateTime, int branchId, int schoolId)
        {
            string result = "";
            List<CustomerAsset> list = CustomerAssetBLL.Search("select * from CustomerAsset where LastUpdateTime>@LastUpdateTime",
                            new SqlParameter("LastUpdateTime", lastUpdateTime));
            result = JsonConvert.SerializeObject(list);
            return result;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<CustomerAsset> list = JsonConvert.DeserializeObject<List<CustomerAsset>>(data);
            foreach (CustomerAsset item in list)
            {
                CustomerAssetBLL.Save(item);
            };
            Common.UpdateTableVersion("CloudCustomer.dbo.CustomerAsset");
        }
    }
}