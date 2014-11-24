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
    public class CSRelationObject : ITableObject
    {
        public string GetTableData(string tableName, DateTime lastUpdateTime, int branchId, int schoolId)
        {
            string result = "";
            List<CSRelation> list = CSRelationBLL.Search("select * from CSRelation where LastUpdateTime>@LastUpdateTime",
                            new SqlParameter("LastUpdateTime", lastUpdateTime));
            result = JsonConvert.SerializeObject(list);
            return result;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<CSRelation> list = JsonConvert.DeserializeObject<List<CSRelation>>(data);
            foreach (CSRelation item in list)
            {
                CSRelationBLL.Save(item);
            };
            Common.UpdateTableVersion("CloudCustomer.dbo.CSRelation");
        }
    }
}