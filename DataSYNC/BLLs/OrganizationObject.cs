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
    public class OrganizationObject : ITableObject
    {
        public string GetTableData(string tableName, DateTime lastUpdateTime, int branchId, int schoolId)
        {
            string result = "";
            List<Organization> list = OrganizationBLL.Search("select * from Organization where BranchId=@BranchId and SchoolId=@SchoolId and  LastUpdateTime>@LastUpdateTime",
                            new SqlParameter("LastUpdateTime", lastUpdateTime),
                            new SqlParameter("BranchId", branchId),
                            new SqlParameter("schoolId", schoolId));
            result = JsonConvert.SerializeObject(list);
            return result;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<Organization> list = JsonConvert.DeserializeObject<List<Organization>>(data);
            foreach (Organization item in list)
            {
                OrganizationBLL.Save(item);
            };
            Common.UpdateTableVersion("CloudOrganization.dbo.Organization");
        }
    }
}