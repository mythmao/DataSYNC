using DataSYNC.BLL;
using DataSYNC.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataSYNC.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            //List<SqlParameter> paraList=new List<SqlParameter>();
            //paraList.Add(new SqlParameter("BranchID",8));
            //paraList.Add(new SqlParameter("XDSchoolID",18));
            //paraList.Add(new SqlParameter("LeftAssetValue", (object)0));
            //string sql="select top 10 * from CustomerSearch where XDSchoolID=@XDSchoolID and BranchID=@BranchID and LeftAssetValue>@LeftAssetValue";
            //List<CustomerSearch> list = CustomerSearchBLL.Search(sql, paraList);
            //return Json(list,JsonRequestBehavior.AllowGet);


            List<StudentAssignCourse> list = new List<StudentAssignCourse>();
            //list = StudentAssignCourseBLL.Search("select top 3 * from StudentAssignCourse");
            list = StudentAssignCourseBLL.Search("select top 3 * from [dbo].[StudentAssignCourse] where SubjectName=@SubjectName and GradeCode=@GradeCode",
                new SqlParameter("SubjectName", "语文"),
                new SqlParameter("GradeCode", 33));

            //CustomerSearch cs = new CustomerSearch();
            //cs.Gid = Guid.NewGuid();
            //cs.LastUpdateTime = DateTime.Now;
            //cs.RecordStatus = 0;
            //bool b= CustomerSearchBLL.Save(cs);
            //return Content(b ? "Success" : "Failed");

            return Json(list, JsonRequestBehavior.AllowGet);
        }

    }
}
