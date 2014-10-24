using DataSYNC.BLL;
using DataSYNC.Model;
using DataSYNC.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace DataSYNC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            int a = 3, b = 5;
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ShowCustomer()
        {
            List<CustomerSearch> list = new List<CustomerSearch>();
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("Test");
            ////事务
            //using(DbConnection conn=db.CreateConnection())
            //{
            //    conn.Open();
            //    DbTransaction trans = conn.BeginTransaction();
            //    try
            //    {
            //        db.ExecuteNonQuery(trans, CommandType.Text, "update Student set Name='mmm' where Id='42572BB4-4A8B-4C29-8934-0B8D7B9881D8'");
            //        db.ExecuteNonQuery(trans, CommandType.Text, "update Teacher set Gender='a' where Id='318AF1E7-21DA-470D-96EA-058C510F68A3'");
            //        trans.Commit();
            //    }
            //    catch (Exception)
            //    {
            //        trans.Rollback();
            //    }
            //}
            DbCommand cmd = db.GetSqlStringCommand("");
            db.AddInParameter(cmd, "BranchID", DbType.Int64, 8);
            
            DataSet ds= db.ExecuteDataSet(CommandType.Text, "select * from CustomerSearch where XDSchoolID=18 and BranchID=8 and [LeftAssetValue]>0");
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                CustomerSearch cs = new CustomerSearch(dr);
                list.Add(cs);
            }
            //List<CustomerSearch> list = CustomerSearchDAL.Search("select * from CustomerSearch where XDSchoolID=18 and BranchID=8 and [LeftAssetValue]>0", new List<SqlParameter>());
            string result = JsonConvert.SerializeObject(list);
            return Content(result);
        }

        public JsonResult GetCustomer()
        {
            List<CustomerSearch> list = CustomerSearchBLL.Search("select top 1 * from CustomerSearch where XDSchoolID=18 and BranchID=8 and [LeftAssetValue]>0 order by LastModified desc");
            
            string result = JsonConvert.SerializeObject(list);
            return Json(new
            {
                TableName = "CustomerSearch",
                Data = result
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CustomerList()
        {
            List<CustomerSearch> list = CustomerSearchBLL.Search("select top 1 * from CustomerSearch where XDSchoolID=18 and BranchID=8 and [LeftAssetValue]>0 order by LastModified desc");
            return View(list);
        }
        public ActionResult UpdateCustomer(string data)
        {
            string  isSuccess = "Failed";
            try
            {
                List<CustomerSearch> list = JsonConvert.DeserializeObject<List<CustomerSearch>>(data);
                foreach(CustomerSearch cs in list)
                {
                    CustomerSearchBLL.Update(cs);
                }
                isSuccess = "Success";
            }
            catch (Exception ex)
            {
                isSuccess = ex.Message;
            }
            return Content(isSuccess);
        }
        
        public JsonResult GetData(string tableName,string updatedate)
        {
            DateTime date = new DateTime(1990,1,1);
            if (!DateTime.TryParse(updatedate, out date))
            {
                date = new DateTime(1990, 1, 1);
            }
            string data = "";
            switch (tableName)
            {
                case "Teacher":
                    List<Teacher> list = new List<Teacher>();
                    DataTable dt = SqlHelper.ExecuteDataTable("select * from Teacher where updatedate>@updatedate", new SqlParameter("updatedate", date));
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Teacher teacher = new Teacher(dr);
                            list.Add(teacher);
                        }

                    }
                    data = JsonConvert.SerializeObject(list);
                    break;
                case "Student":
                    List<Student> listStudent = new List<Student>();
                    DataTable dtStudent = SqlHelper.ExecuteDataTable("select * from Student where updatedate>@updatedate", new SqlParameter("updatedate", date));
                    if (dtStudent != null && dtStudent.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtStudent.Rows)
                        {
                            Student teacher = new Student(dr);
                            listStudent.Add(teacher);
                        }

                    }
                    data = JsonConvert.SerializeObject(listStudent);
                    break;
                case "TableVersion":
                    {
                        List<TableVersion> listTable = new List<TableVersion>();
                        string sql = "select * from "+tableName+" where updatedate>@updatedate";
                        DataTable dtTable = SqlHelper.ExecuteDataTable(sql,
                        new SqlParameter("updatedate", date));
                        if(dtTable!=null&&dtTable.Rows.Count>0)
                        {
                            foreach(DataRow dr in dtTable.Rows)
                            {
                                TableVersion tv = new TableVersion(dr);
                                listTable.Add(tv);
                            }
                        }
                        data = JsonConvert.SerializeObject(listTable);
                    }
                    break;
                default:
                    break;
            }
            
            return Json(new { 
                TableName=tableName,
                Data=data
            },JsonRequestBehavior.AllowGet);
        }
        public void UpdateTableVersion(string tableName)
        {
            string sql = "update TableVersion set UpdateDate=(select max(UpdateDate) from " + tableName + ") where TableName=@TableName";
            SqlHelper.ExecuteNonQuery(sql,
                new SqlParameter("TableName", tableName));
        }

        public string GetVersion(string tableName, string updatedate)
        {
            DateTime date = new DateTime(1990, 1, 1);
            if (!DateTime.TryParse(updatedate, out date))
            {
                date = new DateTime(1990, 1, 1);
            }
            string sql = "select * from " + tableName + " where updatedate>@updatedate";
            string data = "";
            switch (tableName)
            {
                case "Teacher":
                    List<Teacher> list = new List<Teacher>();
                    DataTable dt = SqlHelper.ExecuteDataTable(sql, new SqlParameter("updatedate", date));
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Teacher teacher = new Teacher(dr);
                            list.Add(teacher);
                        }

                    }
                    data = JsonConvert.SerializeObject(list);
                    break;
                case "Student":
                    List<Student> listStudent = new List<Student>();
                    DataTable dtStudent = SqlHelper.ExecuteDataTable(sql, new SqlParameter("updatedate", date));
                    if (dtStudent != null && dtStudent.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtStudent.Rows)
                        {
                            Student teacher = new Student(dr);
                            listStudent.Add(teacher);
                        }

                    }
                    data = JsonConvert.SerializeObject(listStudent);
                    break;
                case "TableVersion":
                    {
                        List<TableVersion> listTable = new List<TableVersion>();
                        DataTable dtTable = SqlHelper.ExecuteDataTable(sql, new SqlParameter("updatedate", date));
                        if (dtTable != null && dtTable.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dtTable.Rows)
                            {
                                TableVersion tv = new TableVersion(dr);
                                listTable.Add(tv);
                            }
                        }
                        data = JsonConvert.SerializeObject(listTable);
                    }
                    break;
                default:
                    break;
            }
            return data;
        }
        
        [LogsFilterAttribute]
        [ErrorFilterAttribute]
        public JsonResult UpdateData(string tableName,string data)
        {
            bool status = false;
            try
            {
                tableName = "Teacher";
                switch(tableName)
                {
                    case "Teacher":
                        List<Teacher> list = JsonConvert.DeserializeObject<List<Teacher>>(data);
                        foreach (Teacher teacher in list)
                        {
                            object obj = SqlHelper.ExecuteScalar("select count(1) from Teacher where Id=@Id", new SqlParameter("Id", teacher.Id));
                            if(Convert.ToInt32(obj)>0)
                            {
                                TeacherDAL.Update(teacher);
                            }
                            else
                            {
                                TeacherDAL.Insert(teacher);
                            }
                            
                        };
                        UpdateTableVersion(tableName);
                        status = true;
                    break;
                    case "Student":
                        List<Student> listStudent = JsonConvert.DeserializeObject<List<Student>>(data);
                        foreach (Student student in listStudent)
                        {
                            object obj = SqlHelper.ExecuteScalar("select count(1) from Student where Id=@Id", new SqlParameter("Id", student.Id));
                            if (Convert.ToInt32(obj) > 0)
                            {
                                StudentDAL.Update(student);
                            }
                            else
                            {
                                StudentDAL.Insert(student);
                            }
                        };
                        UpdateTableVersion(tableName);
                        status = true;
                    break;
                    default:
                    status = false;
                    break;
                }
            }
            catch (Exception e)
            {
                status = false;
            }
            string Versions = GetVersion("TableVersion", null);
            return Json(new { 
                IsUpdated=status,
                TableVersions=Versions
            },JsonRequestBehavior.AllowGet);
        }

        [LogsFilterAttribute]
        
        public JsonResult UpdateInOne(string data)
        {
            bool status = false;
            
            //try
            //{
                List<UpdateObject> list = JsonConvert.DeserializeObject<List<UpdateObject>>(data);
                foreach (UpdateObject obj in list)
                {
                    DealUpdateData(obj.TableName, obj.Data);
                }
                
                status = true;
            //}
            //catch (Exception)
            //{
                
            //}
            string Versions = GetVersion("TableVersion", null);
            return Json(new
            {
                IsUpdated = status,
                TableVersions = Versions
            }, JsonRequestBehavior.AllowGet);
        }
        [LogsFilterAttribute]
        
        public JsonResult GetDataInOne(string tables)
        {
            List<UpdateObject> list = new List<UpdateObject>();

            List<TableObject> tb = JsonConvert.DeserializeObject<List<TableObject>>(tables);
            foreach (TableObject t in tb)
            {
                DateTime date = new DateTime(1990, 1, 1);
                DateTime.TryParse(t.LastUpdateTime, out date);
                string data= GetTableData(t.TableName, date);
                UpdateObject uo = new UpdateObject();
                uo.TableName = t.TableName;
                uo.Data = data;
                list.Add(uo);
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        
        public string GetTableData(string tableName,DateTime updateDate)
        {
            DateTime date = new DateTime(1990, 1, 1);
            if(updateDate<date)
            {
                updateDate = date;
            }
            string result = "";
            switch (tableName)
            {
                case "Teacher":
                    List<Teacher> list = new List<Teacher>();
                    DataTable dt = SqlHelper.ExecuteDataTable("select * from Teacher where updatedate>@updatedate", new SqlParameter("updatedate", updateDate));
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Teacher teacher = new Teacher(dr);
                            list.Add(teacher);
                        }

                    }
                    result = JsonConvert.SerializeObject(list);
                    break;
                case "Student":
                    List<SqlParameter> paramList = new List<SqlParameter>();
                    paramList.Add(new SqlParameter("updatedate", updateDate));
                    List<Student> listStudent = StudentDAL.Search("select * from Student where updatedate>@updatedate", paramList);
                    result = JsonConvert.SerializeObject(listStudent);
                    break;
                case "TableVersion":
                    {
                        List<TableVersion> listTable = new List<TableVersion>();
                        string sql = "select * from " + tableName + " where updatedate>@updatedate";
                        DataTable dtTable = SqlHelper.ExecuteDataTable(sql,
                        new SqlParameter("updatedate", date));
                        if (dtTable != null && dtTable.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dtTable.Rows)
                            {
                                TableVersion tv = new TableVersion(dr);
                                listTable.Add(tv);
                            }
                        }
                        result = JsonConvert.SerializeObject(listTable);
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
        public void DealUpdateData(string tableName, string data)
        {
            switch (tableName)
            {
                case "Teacher":
                    List<Teacher> list = JsonConvert.DeserializeObject<List<Teacher>>(data);
                    foreach (Teacher teacher in list)
                    {
                        object obj = SqlHelper.ExecuteScalar("select count(1) from Teacher where Id=@Id", new SqlParameter("Id", teacher.Id));
                        if (Convert.ToInt32(obj) > 0)
                        {
                            TeacherDAL.Update(teacher);
                        }
                        else
                        {
                            TeacherDAL.Insert(teacher);
                        }

                    };
                    UpdateTableVersion(tableName);
                    break;
                case "Student":
                    List<Student> listStudent = JsonConvert.DeserializeObject<List<Student>>(data);
                    foreach (Student student in listStudent)
                    {
                        object obj = SqlHelper.ExecuteScalar("select count(1) from Student where Id=@Id", new SqlParameter("Id", student.Id));
                        if (Convert.ToInt32(obj) > 0)
                        {
                            StudentDAL.Update(student);
                        }
                        else
                        {
                            StudentDAL.Insert(student);
                        }
                    };
                    UpdateTableVersion(tableName);
                    break;
                default:
                    break;
            }
            
            
        }

        public ActionResult DataEdit()
        {
            Teacher teacher = TeacherDAL.Search("select * from teacher where id=1",new List<SqlParameter>())[0];
            return View(teacher);
        }
    }
}
