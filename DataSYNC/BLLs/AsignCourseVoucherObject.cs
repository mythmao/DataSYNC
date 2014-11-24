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
    public class AsignCourseVoucherObject : ITableObject
    {
        public string GetTableData(string tableName, DateTime lastUpdateTime, int branchId, int schoolId)
        {
            string result = "";
            List<AsignCourseVoucher> list = AsignCourseVoucherBLL.Search("select * from AsignCourseVoucher where LastUpdateTime>@LastUpdateTime",
                            new SqlParameter("LastUpdateTime", lastUpdateTime));
            result = JsonConvert.SerializeObject(list);
            return result;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<AsignCourseVoucher> list = JsonConvert.DeserializeObject<List<AsignCourseVoucher>>(data);
            foreach (AsignCourseVoucher item in list)
            {
                AsignCourseVoucherBLL.Save(item);
            };
            Common.UpdateTableVersion("CloudCourse.dbo.AsignCourseVoucher");
        }
    }
}