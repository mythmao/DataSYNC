using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataSYNC.Models
{
    public static partial class LogsDAL
    {
        public static List<Logs> Search(string sqlStr, List<SqlParameter> pms)
        {
            List<Logs> list = new List<Logs>();
            DataTable table = SqlHelper.ExecuteDataTable(sqlStr, pms.ToArray());
            foreach (DataRow dr in table.Rows)
            {
                Logs model = new Logs(dr);
                list.Add(model);
            }
            return list;
        }
        public static bool Insert(Logs model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段



            if (model.Controller != null)
            {
                fileds.Add("[Controller]");
                pFileds.Add("@Controller");
                pms.Add(new SqlParameter("Controller", model.Controller));
            }



            if (model.Action != null)
            {
                fileds.Add("[Action]");
                pFileds.Add("@Action");
                pms.Add(new SqlParameter("Action", model.Action));
            }



            if (model.ActionParameter != null)
            {
                fileds.Add("[ActionParameter]");
                pFileds.Add("@ActionParameter");
                pms.Add(new SqlParameter("ActionParameter", model.ActionParameter));
            }



            if (model.InsertDate != null && model.InsertDate != new DateTime())
            {
                fileds.Add("[InsertDate]");
                pFileds.Add("@InsertDate");
                pms.Add(new SqlParameter("InsertDate", model.InsertDate));
            }



            if (model.Error != null)
            {
                fileds.Add("[Error]");
                pFileds.Add("@Error");
                pms.Add(new SqlParameter("Error", model.Error));
            }

            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Logs (");
            sb.Append(string.Join(",", fileds.ToArray()));
            sb.Append(") values (");
            sb.Append(string.Join(",", pFileds.ToArray()));
            sb.Append(")");
            sqlStr = sb.ToString();
            int i = SqlHelper.ExecuteNonQuery(sqlStr, pms.ToArray());
            return i > 0;
        }

        public static bool Update(Logs model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段

            pFileds.Add("[Id]=@Id");
            pms.Add(new SqlParameter("Id", model.Id));


            if (model.Controller != null)
            {
                fileds.Add("[Controller]=@Controller");
                pms.Add(new SqlParameter("Controller", model.Controller));
            }


            if (model.Action != null)
            {
                fileds.Add("[Action]=@Action");
                pms.Add(new SqlParameter("Action", model.Action));
            }


            if (model.ActionParameter != null)
            {
                fileds.Add("[ActionParameter]=@ActionParameter");
                pms.Add(new SqlParameter("ActionParameter", model.ActionParameter));
            }


            if (model.InsertDate != null && model.InsertDate != new DateTime())
            {
                fileds.Add("[InsertDate]=@InsertDate");
                pms.Add(new SqlParameter("InsertDate", model.InsertDate));
            }


            if (model.Error != null)
            {
                fileds.Add("[Error]=@Error");
                pms.Add(new SqlParameter("Error", model.Error));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update Logs set ");
            sb.Append(string.Join(",", fileds.ToArray()));
            sb.Append(" where ");
            sb.Append(string.Join(" and ", pFileds.ToArray()));
            sqlStr = sb.ToString();
            int i = SqlHelper.ExecuteNonQuery(sqlStr, pms.ToArray());
            return i > 0;
        }
    }
}