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
    public partial class CSRelationBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudCustomer");


        public static List<CSRelation> Search(string sqlStr, params SqlParameter[] parameters)
        {
            List<CSRelation> list = new List<CSRelation>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        CSRelation model = new CSRelation(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(CSRelation model)
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



            if (model.CustomerID != null)
            {
                fileds.Add("[CustomerID]");
                pFileds.Add("@CustomerID");
                pms.Add(new SqlParameter("CustomerID", model.CustomerID));
            }


            if (model.JobPassportID != null)
            {
                fileds.Add("[JobPassportID]");
                pFileds.Add("@JobPassportID");
                pms.Add(new SqlParameter("JobPassportID", model.JobPassportID));
            }


            if (model.OrganizationID != null)
            {
                fileds.Add("[OrganizationID]");
                pFileds.Add("@OrganizationID");
                pms.Add(new SqlParameter("OrganizationID", model.OrganizationID));
            }


            if (model.StaffUserID != null)
            {
                fileds.Add("[StaffUserID]");
                pFileds.Add("@StaffUserID");
                pms.Add(new SqlParameter("StaffUserID", model.StaffUserID));
            }


            if (model.StaffPassportID != null)
            {
                fileds.Add("[StaffPassportID]");
                pFileds.Add("@StaffPassportID");
                pms.Add(new SqlParameter("StaffPassportID", model.StaffPassportID));
            }


            if (model.Status != null)
            {
                fileds.Add("[Status]");
                pFileds.Add("@Status");
                pms.Add(new SqlParameter("Status", model.Status));
            }


            if (model.RelationType != null)
            {
                fileds.Add("[RelationType]");
                pFileds.Add("@RelationType");
                pms.Add(new SqlParameter("RelationType", model.RelationType));
            }


            if (model.InsertTime != null && model.InsertTime != new DateTime())
            {
                fileds.Add("[InsertTime]");
                pFileds.Add("@InsertTime");
                pms.Add(new SqlParameter("InsertTime", model.InsertTime));
            }


            if (model.UpdateTime != null && model.UpdateTime != new DateTime())
            {
                fileds.Add("[UpdateTime]");
                pFileds.Add("@UpdateTime");
                pms.Add(new SqlParameter("UpdateTime", model.UpdateTime));
            }


            if (model.PreRelationID != null)
            {
                fileds.Add("[PreRelationID]");
                pFileds.Add("@PreRelationID");
                pms.Add(new SqlParameter("PreRelationID", model.PreRelationID));
            }


            if (model.Rank != null)
            {
                fileds.Add("[Rank]");
                pFileds.Add("@Rank");
                pms.Add(new SqlParameter("Rank", model.Rank));
            }


            if (model.HostID != null)
            {
                fileds.Add("[HostID]");
                pFileds.Add("@HostID");
                pms.Add(new SqlParameter("HostID", model.HostID));
            }


            if (model.EndTime != null && model.EndTime != new DateTime())
            {
                fileds.Add("[EndTime]");
                pFileds.Add("@EndTime");
                pms.Add(new SqlParameter("EndTime", model.EndTime));
            }


            if (model.JobID != null)
            {
                fileds.Add("[JobID]");
                pFileds.Add("@JobID");
                pms.Add(new SqlParameter("JobID", model.JobID));
            }


            if (model.CustomerPassportID != null)
            {
                fileds.Add("[CustomerPassportID]");
                pFileds.Add("@CustomerPassportID");
                pms.Add(new SqlParameter("CustomerPassportID", model.CustomerPassportID));
            }


            if (model.CustomerUserID != null)
            {
                fileds.Add("[CustomerUserID]");
                pFileds.Add("@CustomerUserID");
                pms.Add(new SqlParameter("CustomerUserID", model.CustomerUserID));
            }


            if (model.ProductID != null)
            {
                fileds.Add("[ProductID]");
                pFileds.Add("@ProductID");
                pms.Add(new SqlParameter("ProductID", model.ProductID));
            }


            if (model.ProductName != null)
            {
                fileds.Add("[ProductName]");
                pFileds.Add("@ProductName");
                pms.Add(new SqlParameter("ProductName", model.ProductName));
            }


            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO CSRelation (");
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

        public static bool Update(CSRelation model)
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
            pFileds.Add("[ID]=@ID");
            pms.Add(new SqlParameter("ID", model.ID));

            if (model.CustomerID != null)
            {
                fileds.Add("[CustomerID]=@CustomerID");
                pms.Add(new SqlParameter("CustomerID", model.CustomerID));
            }

            if (model.JobPassportID != null)
            {
                fileds.Add("[JobPassportID]=@JobPassportID");
                pms.Add(new SqlParameter("JobPassportID", model.JobPassportID));
            }

            if (model.OrganizationID != null)
            {
                fileds.Add("[OrganizationID]=@OrganizationID");
                pms.Add(new SqlParameter("OrganizationID", model.OrganizationID));
            }

            if (model.StaffUserID != null)
            {
                fileds.Add("[StaffUserID]=@StaffUserID");
                pms.Add(new SqlParameter("StaffUserID", model.StaffUserID));
            }

            if (model.StaffPassportID != null)
            {
                fileds.Add("[StaffPassportID]=@StaffPassportID");
                pms.Add(new SqlParameter("StaffPassportID", model.StaffPassportID));
            }

            if (model.Status != null)
            {
                fileds.Add("[Status]=@Status");
                pms.Add(new SqlParameter("Status", model.Status));
            }

            if (model.RelationType != null)
            {
                fileds.Add("[RelationType]=@RelationType");
                pms.Add(new SqlParameter("RelationType", model.RelationType));
            }

            if (model.InsertTime != null && model.InsertTime != new DateTime())
            {
                fileds.Add("[InsertTime]=@InsertTime");
                pms.Add(new SqlParameter("InsertTime", model.InsertTime));
            }

            if (model.UpdateTime != null && model.UpdateTime != new DateTime())
            {
                fileds.Add("[UpdateTime]=@UpdateTime");
                pms.Add(new SqlParameter("UpdateTime", model.UpdateTime));
            }

            if (model.PreRelationID != null)
            {
                fileds.Add("[PreRelationID]=@PreRelationID");
                pms.Add(new SqlParameter("PreRelationID", model.PreRelationID));
            }

            if (model.Rank != null)
            {
                fileds.Add("[Rank]=@Rank");
                pms.Add(new SqlParameter("Rank", model.Rank));
            }

            if (model.HostID != null)
            {
                fileds.Add("[HostID]=@HostID");
                pms.Add(new SqlParameter("HostID", model.HostID));
            }

            if (model.EndTime != null && model.EndTime != new DateTime())
            {
                fileds.Add("[EndTime]=@EndTime");
                pms.Add(new SqlParameter("EndTime", model.EndTime));
            }

            if (model.JobID != null)
            {
                fileds.Add("[JobID]=@JobID");
                pms.Add(new SqlParameter("JobID", model.JobID));
            }

            if (model.CustomerPassportID != null)
            {
                fileds.Add("[CustomerPassportID]=@CustomerPassportID");
                pms.Add(new SqlParameter("CustomerPassportID", model.CustomerPassportID));
            }

            if (model.CustomerUserID != null)
            {
                fileds.Add("[CustomerUserID]=@CustomerUserID");
                pms.Add(new SqlParameter("CustomerUserID", model.CustomerUserID));
            }

            if (model.ProductID != null)
            {
                fileds.Add("[ProductID]=@ProductID");
                pms.Add(new SqlParameter("ProductID", model.ProductID));
            }

            if (model.ProductName != null)
            {
                fileds.Add("[ProductName]=@ProductName");
                pms.Add(new SqlParameter("ProductName", model.ProductName));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update CSRelation set ");
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

        public static bool Save(CSRelation model)
        {
            object obj = db.ExecuteScalar(CommandType.Text, "select count(1) from CSRelation where Gid='" + model.Gid + "'");
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