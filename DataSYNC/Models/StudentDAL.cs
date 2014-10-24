using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DataSYNC.Models
{
    public static partial class StudentDAL
    {
        public static string connStr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        public static List<Student> Search(string sqlStr, List<SqlParameter> pms)
        {
            List<Student> list = new List<Student>();
            DataTable table = SqlHelper.ExecuteDataTable(connStr, sqlStr, pms.ToArray());
            foreach (DataRow dr in table.Rows)
            {
                Student model = new Student(dr);
                list.Add(model);
            }
            return list;
        }
        public static bool Insert(Student model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段


            if (model.Id != null)
            {
                fileds.Add("[Id]");
                pFileds.Add("@Id");
                pms.Add(new SqlParameter("Id", model.Id));
            }



            if (model.Name != null)
            {
                fileds.Add("[Name]");
                pFileds.Add("@Name");
                pms.Add(new SqlParameter("Name", model.Name));
            }



            if (model.Age != null)
            {
                fileds.Add("[Age]");
                pFileds.Add("@Age");
                pms.Add(new SqlParameter("Age", model.Age));
            }



            if (model.Gender != null)
            {
                fileds.Add("[Gender]");
                pFileds.Add("@Gender");
                pms.Add(new SqlParameter("Gender", model.Gender));
            }



            if (model.InsertDate != null && model.InsertDate != new DateTime())
            {
                fileds.Add("[InsertDate]");
                pFileds.Add("@InsertDate");
                pms.Add(new SqlParameter("InsertDate", DateTime.Now));
            }



            if (model.UpdateDate != null && model.UpdateDate != new DateTime())
            {
                fileds.Add("[UpdateDate]");
                pFileds.Add("@UpdateDate");
                pms.Add(new SqlParameter("UpdateDate", DateTime.Now));
            }



            if (model.Status != null)
            {
                fileds.Add("[Status]");
                pFileds.Add("@Status");
                pms.Add(new SqlParameter("Status", model.Status));
            }

            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Student (");
            sb.Append(string.Join(",", fileds.ToArray()));
            sb.Append(") values (");
            sb.Append(string.Join(",", pFileds.ToArray()));
            sb.Append(")");
            sqlStr = sb.ToString();
            int i = SqlHelper.ExecuteNonQuery(connStr, sqlStr, pms.ToArray());
            return i > 0;
        }

        public static bool Update(Student model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段

            pFileds.Add("[Id]=@Id");
            pms.Add(new SqlParameter("Id", model.Id));


            if (model.Name != null)
            {
                fileds.Add("[Name]=@Name");
                pms.Add(new SqlParameter("Name", model.Name));
            }


            if (model.Age != null)
            {
                fileds.Add("[Age]=@Age");
                pms.Add(new SqlParameter("Age", model.Age));
            }


            if (model.Gender != null)
            {
                fileds.Add("[Gender]=@Gender");
                pms.Add(new SqlParameter("Gender", model.Gender));
            }


            if (model.InsertDate != null && model.InsertDate != new DateTime())
            {
                fileds.Add("[InsertDate]=@InsertDate");
                pms.Add(new SqlParameter("InsertDate", model.InsertDate));
            }


            if (model.UpdateDate != null && model.UpdateDate != new DateTime())
            {
                fileds.Add("[UpdateDate]=@UpdateDate");
                pms.Add(new SqlParameter("UpdateDate", model.UpdateDate));
            }


            if (model.Status != null)
            {
                fileds.Add("[Status]=@Status");
                pms.Add(new SqlParameter("Status", model.Status));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update Student set ");
            sb.Append(string.Join(",", fileds.ToArray()));
            sb.Append(" where ");
            sb.Append(string.Join(" and ", pFileds.ToArray()));
            sqlStr = sb.ToString();
            int i = SqlHelper.ExecuteNonQuery(connStr, sqlStr, pms.ToArray());
            return i > 0;
        }

        public static bool Save(Student model)
        {
            object obj = SqlHelper.ExecuteScalar("select count(1) from Student where Id=@Id", new SqlParameter("Id", model.Id));
            int i = Convert.ToInt32(obj);
            if (i > 0)
            {
                return Update(model);
            }
            else
            {
                return Insert(model);
            }
        }
    }
}