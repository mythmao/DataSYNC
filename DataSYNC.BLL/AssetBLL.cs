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
    public static partial class AssetBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudAsset");


        public static List<Asset> Search(string sqlStr, params SqlParameter[] parameters)
        {
            List<Asset> list = new List<Asset>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        Asset model = new Asset(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(Asset model)
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



            if (model.OwnerType != null)
            {
                fileds.Add("[OwnerType]");
                pFileds.Add("@OwnerType");
                pms.Add(new SqlParameter("OwnerType", model.OwnerType));
            }


            if (model.OwnerID != null)
            {
                fileds.Add("[OwnerID]");
                pFileds.Add("@OwnerID");
                pms.Add(new SqlParameter("OwnerID", model.OwnerID));
            }


            if (model.OwnerPassportID != null)
            {
                fileds.Add("[OwnerPassportID]");
                pFileds.Add("@OwnerPassportID");
                pms.Add(new SqlParameter("OwnerPassportID", model.OwnerPassportID));
            }


            if (model.ExchangeID != null)
            {
                fileds.Add("[ExchangeID]");
                pFileds.Add("@ExchangeID");
                pms.Add(new SqlParameter("ExchangeID", model.ExchangeID));
            }


            if (model.SubCompanyID != null)
            {
                fileds.Add("[SubCompanyID]");
                pFileds.Add("@SubCompanyID");
                pms.Add(new SqlParameter("SubCompanyID", model.SubCompanyID));
            }


            if (model.SchoolID != null)
            {
                fileds.Add("[SchoolID]");
                pFileds.Add("@SchoolID");
                pms.Add(new SqlParameter("SchoolID", model.SchoolID));
            }


            if (model.ContractID != null)
            {
                fileds.Add("[ContractID]");
                pFileds.Add("@ContractID");
                pms.Add(new SqlParameter("ContractID", model.ContractID));
            }


            if (model.ContractCode != null)
            {
                fileds.Add("[ContractCode]");
                pFileds.Add("@ContractCode");
                pms.Add(new SqlParameter("ContractCode", model.ContractCode));
            }


            if (model.AssetType != null)
            {
                fileds.Add("[AssetType]");
                pFileds.Add("@AssetType");
                pms.Add(new SqlParameter("AssetType", model.AssetType));
            }


            if (model.AssetCreateDate != null && model.AssetCreateDate != new DateTime())
            {
                fileds.Add("[AssetCreateDate]");
                pFileds.Add("@AssetCreateDate");
                pms.Add(new SqlParameter("AssetCreateDate", model.AssetCreateDate));
            }


            if (model.StartTime != null && model.StartTime != new DateTime())
            {
                fileds.Add("[StartTime]");
                pFileds.Add("@StartTime");
                pms.Add(new SqlParameter("StartTime", model.StartTime));
            }


            if (model.EndTime != null && model.EndTime != new DateTime())
            {
                fileds.Add("[EndTime]");
                pFileds.Add("@EndTime");
                pms.Add(new SqlParameter("EndTime", model.EndTime));
            }


            if (model.AssetCount != null)
            {
                fileds.Add("[AssetCount]");
                pFileds.Add("@AssetCount");
                pms.Add(new SqlParameter("AssetCount", model.AssetCount));
            }


            if (model.RemainCount != null)
            {
                fileds.Add("[RemainCount]");
                pFileds.Add("@RemainCount");
                pms.Add(new SqlParameter("RemainCount", model.RemainCount));
            }


            if (model.LockCount != null)
            {
                fileds.Add("[LockCount]");
                pFileds.Add("@LockCount");
                pms.Add(new SqlParameter("LockCount", model.LockCount));
            }


            if (model.AssetState != null)
            {
                fileds.Add("[AssetState]");
                pFileds.Add("@AssetState");
                pms.Add(new SqlParameter("AssetState", model.AssetState));
            }


            if (model.FreezeType != null)
            {
                fileds.Add("[FreezeType]");
                pFileds.Add("@FreezeType");
                pms.Add(new SqlParameter("FreezeType", model.FreezeType));
            }


            if (model.AssetSource != null)
            {
                fileds.Add("[AssetSource]");
                pFileds.Add("@AssetSource");
                pms.Add(new SqlParameter("AssetSource", model.AssetSource));
            }


            if (model.HostID != null)
            {
                fileds.Add("[HostID]");
                pFileds.Add("@HostID");
                pms.Add(new SqlParameter("HostID", model.HostID));
            }


            if (model.WaitRMCount != null)
            {
                fileds.Add("[WaitRMCount]");
                pFileds.Add("@WaitRMCount");
                pms.Add(new SqlParameter("WaitRMCount", model.WaitRMCount));
            }


            if (model.ChangeID != null)
            {
                fileds.Add("[ChangeID]");
                pFileds.Add("@ChangeID");
                pms.Add(new SqlParameter("ChangeID", model.ChangeID));
            }


            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Asset (");
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

        public static bool Update(Asset model)
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
            pFileds.Add("[AssetID]=@AssetID");
            pms.Add(new SqlParameter("AssetID", model.AssetID));

            if (model.OwnerType != null)
            {
                fileds.Add("[OwnerType]=@OwnerType");
                pms.Add(new SqlParameter("OwnerType", model.OwnerType));
            }

            if (model.OwnerID != null)
            {
                fileds.Add("[OwnerID]=@OwnerID");
                pms.Add(new SqlParameter("OwnerID", model.OwnerID));
            }

            if (model.OwnerPassportID != null)
            {
                fileds.Add("[OwnerPassportID]=@OwnerPassportID");
                pms.Add(new SqlParameter("OwnerPassportID", model.OwnerPassportID));
            }

            if (model.ExchangeID != null)
            {
                fileds.Add("[ExchangeID]=@ExchangeID");
                pms.Add(new SqlParameter("ExchangeID", model.ExchangeID));
            }

            if (model.SubCompanyID != null)
            {
                fileds.Add("[SubCompanyID]=@SubCompanyID");
                pms.Add(new SqlParameter("SubCompanyID", model.SubCompanyID));
            }

            if (model.SchoolID != null)
            {
                fileds.Add("[SchoolID]=@SchoolID");
                pms.Add(new SqlParameter("SchoolID", model.SchoolID));
            }

            if (model.ContractID != null)
            {
                fileds.Add("[ContractID]=@ContractID");
                pms.Add(new SqlParameter("ContractID", model.ContractID));
            }

            if (model.ContractCode != null)
            {
                fileds.Add("[ContractCode]=@ContractCode");
                pms.Add(new SqlParameter("ContractCode", model.ContractCode));
            }

            if (model.AssetType != null)
            {
                fileds.Add("[AssetType]=@AssetType");
                pms.Add(new SqlParameter("AssetType", model.AssetType));
            }

            if (model.AssetCreateDate != null && model.AssetCreateDate != new DateTime())
            {
                fileds.Add("[AssetCreateDate]=@AssetCreateDate");
                pms.Add(new SqlParameter("AssetCreateDate", model.AssetCreateDate));
            }

            if (model.StartTime != null && model.StartTime != new DateTime())
            {
                fileds.Add("[StartTime]=@StartTime");
                pms.Add(new SqlParameter("StartTime", model.StartTime));
            }

            if (model.EndTime != null && model.EndTime != new DateTime())
            {
                fileds.Add("[EndTime]=@EndTime");
                pms.Add(new SqlParameter("EndTime", model.EndTime));
            }

            if (model.AssetCount != null)
            {
                fileds.Add("[AssetCount]=@AssetCount");
                pms.Add(new SqlParameter("AssetCount", model.AssetCount));
            }

            if (model.RemainCount != null)
            {
                fileds.Add("[RemainCount]=@RemainCount");
                pms.Add(new SqlParameter("RemainCount", model.RemainCount));
            }

            if (model.LockCount != null)
            {
                fileds.Add("[LockCount]=@LockCount");
                pms.Add(new SqlParameter("LockCount", model.LockCount));
            }

            if (model.AssetState != null)
            {
                fileds.Add("[AssetState]=@AssetState");
                pms.Add(new SqlParameter("AssetState", model.AssetState));
            }

            if (model.FreezeType != null)
            {
                fileds.Add("[FreezeType]=@FreezeType");
                pms.Add(new SqlParameter("FreezeType", model.FreezeType));
            }

            if (model.AssetSource != null)
            {
                fileds.Add("[AssetSource]=@AssetSource");
                pms.Add(new SqlParameter("AssetSource", model.AssetSource));
            }

            if (model.HostID != null)
            {
                fileds.Add("[HostID]=@HostID");
                pms.Add(new SqlParameter("HostID", model.HostID));
            }

            if (model.WaitRMCount != null)
            {
                fileds.Add("[WaitRMCount]=@WaitRMCount");
                pms.Add(new SqlParameter("WaitRMCount", model.WaitRMCount));
            }

            if (model.ChangeID != null)
            {
                fileds.Add("[ChangeID]=@ChangeID");
                pms.Add(new SqlParameter("ChangeID", model.ChangeID));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update Asset set ");
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

        public static bool Save(Asset model)
        {
            object obj = db.ExecuteScalar(CommandType.Text, "select count(1) from Asset where Gid='" + model.Gid + "'");
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