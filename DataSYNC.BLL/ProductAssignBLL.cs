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
    public static partial class ProductAssignBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudAsset");


        public static List<ProductAssign> Search(string sqlStr, params SqlParameter[] parameters)
        {
            List<ProductAssign> list = new List<ProductAssign>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        ProductAssign model = new ProductAssign(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(ProductAssign model)
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


            {
                fileds.Add("[LastUpdateTime]");
                pFileds.Add("@LastUpdateTime");
                pms.Add(new SqlParameter("LastUpdateTime", DateTime.Now));
            }


            if (model.RecordStatus != null)
            {
                fileds.Add("[RecordStatus]");
                pFileds.Add("@RecordStatus");
                pms.Add(new SqlParameter("RecordStatus", model.RecordStatus));
            }



            if (model.StudentID != null)
            {
                fileds.Add("[StudentID]");
                pFileds.Add("@StudentID");
                pms.Add(new SqlParameter("StudentID", model.StudentID));
            }


            if (model.StudentPassportID != null)
            {
                fileds.Add("[StudentPassportID]");
                pFileds.Add("@StudentPassportID");
                pms.Add(new SqlParameter("StudentPassportID", model.StudentPassportID));
            }


            if (model.ProductID != null)
            {
                fileds.Add("[ProductID]");
                pFileds.Add("@ProductID");
                pms.Add(new SqlParameter("ProductID", model.ProductID));
            }


            if (model.AssignCount != null)
            {
                fileds.Add("[AssignCount]");
                pFileds.Add("@AssignCount");
                pms.Add(new SqlParameter("AssignCount", model.AssignCount));
            }


            if (model.HostID != null)
            {
                fileds.Add("[HostID]");
                pFileds.Add("@HostID");
                pms.Add(new SqlParameter("HostID", model.HostID));
            }


            if (model.UpdateDate != null && model.UpdateDate != new DateTime())
            {
                fileds.Add("[UpdateDate]");
                pFileds.Add("@UpdateDate");
                pms.Add(new SqlParameter("UpdateDate", model.UpdateDate));
            }

            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO ProductAssign (");
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

        public static bool Update(ProductAssign model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段

            if (model.Gid != null)
            {
                fileds.Add("[Gid]=@Gid");
                pms.Add(new SqlParameter("Gid", model.Gid));
            }

            if (model.LastUpdateTime != null && model.LastUpdateTime != new DateTime())
            {
                fileds.Add("[LastUpdateTime]=@LastUpdateTime");
                pms.Add(new SqlParameter("LastUpdateTime", DateTime.Now));
            }

            if (model.RecordStatus != null)
            {
                fileds.Add("[RecordStatus]=@RecordStatus");
                pms.Add(new SqlParameter("RecordStatus", model.RecordStatus));
            }
            pFileds.Add("[ProductAssignID]=@ProductAssignID");
            pms.Add(new SqlParameter("ProductAssignID", model.ProductAssignID));

            if (model.StudentID != null)
            {
                fileds.Add("[StudentID]=@StudentID");
                pms.Add(new SqlParameter("StudentID", model.StudentID));
            }

            if (model.StudentPassportID != null)
            {
                fileds.Add("[StudentPassportID]=@StudentPassportID");
                pms.Add(new SqlParameter("StudentPassportID", model.StudentPassportID));
            }

            if (model.ProductID != null)
            {
                fileds.Add("[ProductID]=@ProductID");
                pms.Add(new SqlParameter("ProductID", model.ProductID));
            }

            if (model.AssignCount != null)
            {
                fileds.Add("[AssignCount]=@AssignCount");
                pms.Add(new SqlParameter("AssignCount", model.AssignCount));
            }

            if (model.HostID != null)
            {
                fileds.Add("[HostID]=@HostID");
                pms.Add(new SqlParameter("HostID", model.HostID));
            }

            if (model.UpdateDate != null && model.UpdateDate != new DateTime())
            {
                fileds.Add("[UpdateDate]=@UpdateDate");
                pms.Add(new SqlParameter("UpdateDate", model.UpdateDate));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update ProductAssign set ");
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

        public static bool Save(ProductAssign model)
        {
            object obj = db.ExecuteScalar(CommandType.Text, "select count(1) from ProductAssign where Gid='" + model.Gid + "'");
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