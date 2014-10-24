using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataSYNC.Models
{
    public static partial class TeacherDAL
    {
        public static List<Teacher> Search(string sqlStr, List<SqlParameter> pms)
        {
            List<Teacher> list = new List<Teacher>();
            DataTable table = SqlHelper.ExecuteDataTable(sqlStr, pms.ToArray());
            foreach (DataRow dr in table.Rows)
            {
                Teacher model = new Teacher(dr);
                list.Add(model);
            }
            return list;
        }
        public static bool Insert(Teacher model)
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



            if (model.Gender != null)
            {
                fileds.Add("[Gender]");
                pFileds.Add("@Gender");
                pms.Add(new SqlParameter("Gender", model.Gender));
            }



            if (model.Age != null)
            {
                fileds.Add("[Age]");
                pFileds.Add("@Age");
                pms.Add(new SqlParameter("Age", model.Age));
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
            sb.Append("INSERT INTO Teacher (");
            sb.Append(string.Join(",", fileds.ToArray()));
            sb.Append(") values (");
            sb.Append(string.Join(",", pFileds.ToArray()));
            sb.Append(")");
            sqlStr = sb.ToString();
            int i = SqlHelper.ExecuteNonQuery(sqlStr, pms.ToArray());
            return i > 0;
        }

        public static bool Update(Teacher model)
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


            if (model.Gender != null)
            {
                fileds.Add("[Gender]=@Gender");
                pms.Add(new SqlParameter("Gender", model.Gender));
            }


            if (model.Age != null)
            {
                fileds.Add("[Age]=@Age");
                pms.Add(new SqlParameter("Age", model.Age));
            }


            if (model.InsertDate != null && model.InsertDate != new DateTime())
            {
                fileds.Add("[InsertDate]=@InsertDate");
                pms.Add(new SqlParameter("InsertDate", model.InsertDate));
            }


            if (model.UpdateDate != null && model.UpdateDate != new DateTime())
            {
                fileds.Add("[UpdateDate]=@UpdateDate");
                pms.Add(new SqlParameter("UpdateDate", DateTime.Now));
            }


            if (model.Status != null)
            {
                fileds.Add("[Status]=@Status");
                pms.Add(new SqlParameter("Status", model.Status));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update Teacher set ");
            sb.Append(string.Join(",", fileds.ToArray()));
            sb.Append(" where ");
            sb.Append(string.Join(" and ", pFileds.ToArray()));
            sqlStr = sb.ToString();
            int i = SqlHelper.ExecuteNonQuery(sqlStr, pms.ToArray());
            return i > 0;
        }
    }
}