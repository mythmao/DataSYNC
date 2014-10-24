using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using DataSYNC.Model;

namespace DataSYNC.BLL
{
    public static partial class TableVersionBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("Test");


        public static List<TableVersion> Search(string sqlStr, params SqlParameter[] parameters)
        {
            List<TableVersion> list = new List<TableVersion>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        TableVersion model = new TableVersion(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(TableVersion model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段


            if (model.Gid != null)
            {
                fileds.Add("[Gid]");
                pFileds.Add("@Gid");
                pms.Add(new SqlParameter("Gid", model.Gid));
            }



            if (model.TableName != null)
            {
                fileds.Add("[TableName]");
                pFileds.Add("@TableName");
                pms.Add(new SqlParameter("TableName", model.TableName));
            }



            if (model.LastUpdateTime != null && model.LastUpdateTime != new DateTime())
            {
                fileds.Add("[LastUpdateTime]");
                pFileds.Add("@LastUpdateTime");
                pms.Add(new SqlParameter("LastUpdateTime", DateTime.Now));
            }



            if (model.Status != null)
            {
                fileds.Add("[Status]");
                pFileds.Add("@Status");
                pms.Add(new SqlParameter("Status", model.Status));
            }

            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO TableVersion (");
            sb.Append(string.Join(",", fileds.ToArray()));
            sb.Append(") values (");
            sb.Append(string.Join(",", pFileds.ToArray()));
            sb.Append(")");
            sqlStr = sb.ToString();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(pms.ToArray());
                int i = db.ExecuteNonQuery(cmd);
                return i > 0;
            }
        }

        public static bool Update(TableVersion model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段

            pFileds.Add("[Gid]=@Gid");
            pms.Add(new SqlParameter("Gid", model.Gid));


            if (model.TableName != null)
            {
                fileds.Add("[TableName]=@TableName");
                pms.Add(new SqlParameter("TableName", model.TableName));
            }


            if (model.LastUpdateTime != null && model.LastUpdateTime != new DateTime())
            {
                fileds.Add("[LastUpdateTime]=@LastUpdateTime");
                pms.Add(new SqlParameter("LastUpdateTime", model.LastUpdateTime));
            }


            if (model.Status != null)
            {
                fileds.Add("[Status]=@Status");
                pms.Add(new SqlParameter("Status", model.Status));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update TableVersion set ");
            sb.Append(string.Join(",", fileds.ToArray()));
            sb.Append(" where ");
            sb.Append(string.Join(" and ", pFileds.ToArray()));
            sqlStr = sb.ToString();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(pms.ToArray());
                int i = db.ExecuteNonQuery(cmd);
                return i > 0;
            }
        }

        public static bool Save(TableVersion model)
        {
            object obj = db.ExecuteScalar(CommandType.Text, "select count(1) from TableVersion where Gid='" + model.Gid + "'");
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