using DataSYNC.BLL;
using DataSYNC.Model;
using DataSYNC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace DataSYNC.Controllers
{
    public class SYNCController : Controller
    {
        //
        // GET: /SYNC/

        public ActionResult Index()
        {
            //TestObj tb = new TestObj() { Time = DateTime.Now };
            //string json1 = JsonConvert.SerializeObject(tb);
            //JavaScriptSerializer jss = new JavaScriptSerializer();
            //string json2 = jss.Serialize(tb);
            CustomerSearch cs = new CustomerSearch();
            cs.Gid = Guid.NewGuid();
            cs.CustomerName = "事务更新";
            Student student = new Student();
            student.Name = "新事务更新事务更新事务更新事务更新事务更新事务更新";
            //using (DbConnection conn = CustomerSearchBLL.db.CreateConnection())
            //{
            //    conn.Open();
            //    DbTransaction trans = conn.BeginTransaction();
            //    try
            //    {
            //        bool b = CustomerSearchBLL.Insert(cs,trans);
            //        bool b2 = StudentDAL.Insert(student);
            //        trans.Commit();
            //    }
            //    catch (Exception)
            //    {
            //        trans.Rollback();
            //    }
            //}
           //using(TransactionScope scope=new TransactionScope())
           //{
           //    try
           //    {
           //        bool b1 = CustomerSearchBLL.Insert(cs);
           //        bool b2 = StudentDAL.Insert(student);
           //        scope.Complete();
           //    }
           //    catch (Exception ex)
           //    {
           //        scope.Dispose();
           //        ExceptionContext ec = new ExceptionContext(this.ControllerContext, ex);
           //        ErrorHandler.ErrorForLog(ec);
           //    }

           //}
            return View();
        }
        /// <summary>
        /// 获取单个表数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="lastUpdateTime"></param>
        /// <param name="branchId"></param>
        /// <param name="schoolId"></param>
        /// <returns></returns>
        public string GetTableData(string tableName, DateTime lastUpdateTime,int branchId,int schoolId)
        {
            DateTime date = new DateTime(1990, 1, 1);
            if (lastUpdateTime < date)
            {
                lastUpdateTime = date;
            }
            string result = "";
            switch (tableName)
            {
                case "CustomerSearch":
                    {
                        List<CustomerSearch> list = CustomerSearchBLL.Search("select * from [CloudCustomer].[dbo].[CustomerSearch] where XDSchoolID=@XDSchoolID and BranchID=@BranchID and LeftAssetValue>@LeftAssetValue and LastUpdateTime>@LastUpdateTime",
                            new SqlParameter("BranchID", branchId),
                            new SqlParameter("XDSchoolID", schoolId),
                            new SqlParameter("LeftAssetValue", (object)0),
                            new SqlParameter("LastUpdateTime", lastUpdateTime));
                        result = JsonConvert.SerializeObject(list);
                    }
                    break;
                case "StudentAssignCourse":
                    {
                        List<StudentAssignCourse> list = StudentAssignCourseBLL.Search("select * from [CloudCourse].[dbo].[StudentAssignCourse] where CompanyID=@CompanyID and TeachingSchoolID=@TeachingSchoolID and LastUpdateTime>@LastUpdateTime",
                           new SqlParameter("CompanyID", branchId),
                           new SqlParameter("TeachingSchoolID", schoolId),
                           new SqlParameter("LastUpdateTime", lastUpdateTime));
                        result = JsonConvert.SerializeObject(list);
                    }
                    break;
                case "AssignCourse":
                    {
                        List<AssignCourse> list = AssignCourseBLL.Search("select *  from AssignCourse where CompanyID=@CompanyID and SchoolID=@SchoolID and LastUpdateTime>@LastUpdateTime and LastUpdateTime<@LastUpdateTime2",
                           new SqlParameter("CompanyID", branchId),
                           new SqlParameter("SchoolID", schoolId),
                           new SqlParameter("LastUpdateTime", lastUpdateTime),
                           new SqlParameter("LastUpdateTime2",lastUpdateTime.AddMonths(1)));
                        result = JsonConvert.SerializeObject(list);
                    }
                    break;
                case "Asset":
                    {
                        List<Asset> list = AssetBLL.Search(@"select a.* from [CloudAsset].[dbo].[Asset] a join
 (select *  FROM [CloudCustomer].[dbo].[CustomerSearch] ss where ss.XDSchoolID=@XDSchoolID and ss.BranchID=@BranchID
  AND (SS.TotalCourseAmount>0 OR SS.CommonCourseAmount>0 OR SS.SpecialCourseAmount>0)) b  on a.OwnerID=b.customerid and a.LastUpdateTime>@LastUpdateTime",
                           new SqlParameter("BranchID", branchId),
                           new SqlParameter("XDSchoolID", schoolId),
                           new SqlParameter("LastUpdateTime", lastUpdateTime));
                        result = JsonConvert.SerializeObject(list);
                    }
                    break;
                case "Period":
                    {
                        List<Period> list = PeriodBLL.Search(@"select p.* from [CloudAsset].[dbo].[Period] p join  ( select a.* from [CloudAsset].[dbo].[Asset] a join
 (select *  FROM [CloudCustomer].[dbo].[CustomerSearch] ss where ss.XDSchoolID=18 and ss.BranchID=8
  AND (SS.TotalCourseAmount>0 OR SS.CommonCourseAmount>0 OR SS.SpecialCourseAmount>0)) b  on a.OwnerID=b.customerid)c on p.AssetID=c.AssetID and p.LastUpdateTime>@LastUpdateTime",
                           new SqlParameter("BranchID", branchId),
                           new SqlParameter("XDSchoolID", schoolId),
                           new SqlParameter("LastUpdateTime", lastUpdateTime));
                        result = JsonConvert.SerializeObject(list);
                    }
                    break;
                case "ProductAssign":
                    {
                        List<ProductAssign> list = ProductAssignBLL.Search(@"select a.* from [CloudAsset].[dbo].[ProductAssign] a join
 (select *  FROM [CloudCustomer].[dbo].[CustomerSearch] ss where ss.XDSchoolID=18 and ss.BranchID=8
  AND (SS.TotalCourseAmount>0 OR SS.CommonCourseAmount>0 OR SS.SpecialCourseAmount>0)) b  on a.studentid=b.customerid and a.LastUpdateTime>@LastUpdateTime",
                           new SqlParameter("BranchID", branchId),
                           new SqlParameter("XDSchoolID", schoolId),
                           new SqlParameter("LastUpdateTime", lastUpdateTime));
                        result = JsonConvert.SerializeObject(list);
                    }
                    break;
                case "TableVersion":
                    {
                        List<TableVersion> listTable = TableVersionBLL.Search("select * from TableVersion");
                        result = JsonConvert.SerializeObject(listTable);
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
        /// <summary>
        /// 批量获取表数据
        /// </summary>
        /// <param name="tables"></param>
        /// <returns></returns>
        [LogsFilterAttribute]
        public ActionResult GetDataInOne(string tables)
        {
            List<UpdateObject> list = new List<UpdateObject>();

            List<TableObject> tb = JsonConvert.DeserializeObject<List<TableObject>>(tables);
            foreach (TableObject t in tb)
            {
                DateTime date = new DateTime(1990, 1, 1);
                DateTime.TryParse(t.LastUpdateTime, out date);
                string data = GetTableData(t.TableName, date,t.BranchID,t.SchoolID);
                UpdateObject uo = new UpdateObject();
                uo.TableName = t.TableName;
                uo.Data = data;
                list.Add(uo);
            }
            string result = JsonConvert.SerializeObject(list);
            return Content(result, "application/json");
            //return Json(list, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 批量更新表数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [LogsFilterAttribute]
        public JsonResult UpdateInOne(string data)
        {
            string status = "Failed";

            try
            {
                List<UpdateObject> list = JsonConvert.DeserializeObject<List<UpdateObject>>(data);
                foreach (UpdateObject obj in list)
                {
                    DealUpdateData(obj.TableName, obj.Data);
                }
                status = "Success";
            }
            catch (Exception ex)
            {
                status = "Failed";
                ExceptionContext ec = new ExceptionContext(this.ControllerContext, ex);
                ErrorHandler.ErrorForLog(ec);
            }
            string Versions = GetTableData("TableVersion", new DateTime(1990, 1, 1), 0, 0);
            return Json(new
            {
                IsUpdated = status,
                TableVersions = Versions
            }, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 批量更新表数据(带分布式事务)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [LogsFilterAttribute]
        public JsonResult UpdateInOneWithTrans(string data)
        {
            string status = "Failed";
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    List<UpdateObject> list = JsonConvert.DeserializeObject<List<UpdateObject>>(data);
                    foreach (UpdateObject obj in list)
                    {
                        DealUpdateData(obj.TableName, obj.Data);
                    }
                    scope.Complete();
                    status = "Success";
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    status = "Failed";
                    ExceptionContext ec=new ExceptionContext(this.ControllerContext,ex);
                    ErrorHandler.ErrorForLog(ec);
                }
            }
            string Versions = GetTableData("TableVersion", new DateTime(1990, 1, 1), 0, 0);
            return Json(new
            {
                IsUpdated = status,
                TableVersions = Versions
            }, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 更新表数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="data"></param>
        public void DealUpdateData(string tableName, string data)
        {
            switch (tableName)
            {
                case "CustomerSearch":
                    {
                        List<CustomerSearch> list = JsonConvert.DeserializeObject<List<CustomerSearch>>(data);
                        foreach (CustomerSearch item in list)
                        {
                            CustomerSearchBLL.Save(item);
                        };
                        UpdateTableVersion("[CloudCustomer].[dbo]." + tableName);
                    }
                    break;
                case "StudentAssignCourse":
                    {
                        List<StudentAssignCourse> list = JsonConvert.DeserializeObject<List<StudentAssignCourse>>(data);
                        foreach (StudentAssignCourse item in list)
                        {
                            StudentAssignCourseBLL.Save(item);
                        };
                        UpdateTableVersion("[CloudCourse].[dbo]." + tableName);
                    }
                    break;
                case "AssignCourse":
                    {
                        List<AssignCourse> list = JsonConvert.DeserializeObject<List<AssignCourse>>(data);
                        foreach (AssignCourse item in list)
                        {
                            AssignCourseBLL.Save(item);
                        };
                        UpdateTableVersion("[CloudCourse].[dbo]." + tableName);
                    }
                    break;
                case "Asset":
                    {
                        List<Asset> list = JsonConvert.DeserializeObject<List<Asset>>(data);
                        foreach (Asset item in list)
                        {
                            AssetBLL.Save(item);
                        };
                        UpdateTableVersion("[CloudAsset].[dbo]." + tableName);
                    }
                    break;
                case "Period":
                    {
                        List<Period> list = JsonConvert.DeserializeObject<List<Period>>(data);
                        foreach (Period item in list)
                        {
                            PeriodBLL.Save(item);
                        };
                        UpdateTableVersion("[CloudAsset].[dbo]." + tableName);
                    }
                    break;
                case "ProductAssign":
                    {
                        List<ProductAssign> list = JsonConvert.DeserializeObject<List<ProductAssign>>(data);
                        foreach (ProductAssign item in list)
                        {
                            ProductAssignBLL.Save(item);
                        };
                        UpdateTableVersion("[CloudAsset].[dbo]." + tableName);
                    }
                    break;
                default:
                    break;
            }


        }
        /// <summary>
        /// 更新大表版本
        /// </summary>
        /// <param name="tableName">表名</param>
        public void UpdateTableVersion(string tableName)
        {
            string[] tables = tableName.Split(',');
            string name = tables[tables.Length - 1];
            string[] names = name.Split('.');
            string tname = names[names.Length - 1];
            string sql = "update TableVersion set LastUpdateTime=(select max(LastUpdateTime) from " + tableName + ") where TableName=@TableName";
            SqlHelper.ExecuteNonQuery(sql,
                new SqlParameter("TableName", tname));
        }
        [LogsFilter]
        /// <summary>
        /// 更新单个表数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public JsonResult UpdateTable(string tableName,string data)
        {
            string isSuccess = "Failed";
            try
            {
                DealUpdateData(tableName, data);
                isSuccess = "Success";
            }
            catch (Exception ex)
            {
                isSuccess = "Failed";
                ExceptionContext ec = new ExceptionContext(this.ControllerContext, ex);
                ErrorHandler.ErrorForLog(ec);
            }
            string Versions = GetTableData("TableVersion", new DateTime(1990, 1, 1), 0, 0);
            return Json(new
            {
                IsUpdated = isSuccess,
                TableVersions = Versions
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
