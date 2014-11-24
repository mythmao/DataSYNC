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
    public partial class OrganizationBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudOrganization");


        public static List<Organization> Search(string sqlStr, params SqlParameter[] parameters)
        {
            List<Organization> list = new List<Organization>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        Organization model = new Organization(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(Organization model)
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



            if (model.ParentOrgID != null)
            {
                fileds.Add("[ParentOrgID]");
                pFileds.Add("@ParentOrgID");
                pms.Add(new SqlParameter("ParentOrgID", model.ParentOrgID));
            }


            if (model.Path != null)
            {
                fileds.Add("[Path]");
                pFileds.Add("@Path");
                pms.Add(new SqlParameter("Path", model.Path));
            }


            if (model.OrgCode != null)
            {
                fileds.Add("[OrgCode]");
                pFileds.Add("@OrgCode");
                pms.Add(new SqlParameter("OrgCode", model.OrgCode));
            }


            if (model.OrgName != null)
            {
                fileds.Add("[OrgName]");
                pFileds.Add("@OrgName");
                pms.Add(new SqlParameter("OrgName", model.OrgName));
            }


            if (model.OrgCommName != null)
            {
                fileds.Add("[OrgCommName]");
                pFileds.Add("@OrgCommName");
                pms.Add(new SqlParameter("OrgCommName", model.OrgCommName));
            }


            if (model.FullPinyin != null)
            {
                fileds.Add("[FullPinyin]");
                pFileds.Add("@FullPinyin");
                pms.Add(new SqlParameter("FullPinyin", model.FullPinyin));
            }


            if (model.SimplePinyin != null)
            {
                fileds.Add("[SimplePinyin]");
                pFileds.Add("@SimplePinyin");
                pms.Add(new SqlParameter("SimplePinyin", model.SimplePinyin));
            }


            if (model.OtherName != null)
            {
                fileds.Add("[OtherName]");
                pFileds.Add("@OtherName");
                pms.Add(new SqlParameter("OtherName", model.OtherName));
            }


            if (model.ShortName != null)
            {
                fileds.Add("[ShortName]");
                pFileds.Add("@ShortName");
                pms.Add(new SqlParameter("ShortName", model.ShortName));
            }


            if (model.OrgType != null)
            {
                fileds.Add("[OrgType]");
                pFileds.Add("@OrgType");
                pms.Add(new SqlParameter("OrgType", model.OrgType));
            }


            if (model.Status != null)
            {
                fileds.Add("[Status]");
                pFileds.Add("@Status");
                pms.Add(new SqlParameter("Status", model.Status));
            }


            if (model.OrgProvince != null)
            {
                fileds.Add("[OrgProvince]");
                pFileds.Add("@OrgProvince");
                pms.Add(new SqlParameter("OrgProvince", model.OrgProvince));
            }


            if (model.OrgProvinceName != null)
            {
                fileds.Add("[OrgProvinceName]");
                pFileds.Add("@OrgProvinceName");
                pms.Add(new SqlParameter("OrgProvinceName", model.OrgProvinceName));
            }


            if (model.OrgCity != null)
            {
                fileds.Add("[OrgCity]");
                pFileds.Add("@OrgCity");
                pms.Add(new SqlParameter("OrgCity", model.OrgCity));
            }


            if (model.OrgCityName != null)
            {
                fileds.Add("[OrgCityName]");
                pFileds.Add("@OrgCityName");
                pms.Add(new SqlParameter("OrgCityName", model.OrgCityName));
            }


            if (model.LeagleOwner != null)
            {
                fileds.Add("[LeagleOwner]");
                pFileds.Add("@LeagleOwner");
                pms.Add(new SqlParameter("LeagleOwner", model.LeagleOwner));
            }


            if (model.OfficeAddress != null)
            {
                fileds.Add("[OfficeAddress]");
                pFileds.Add("@OfficeAddress");
                pms.Add(new SqlParameter("OfficeAddress", model.OfficeAddress));
            }


            if (model.LinkPhone != null)
            {
                fileds.Add("[LinkPhone]");
                pFileds.Add("@LinkPhone");
                pms.Add(new SqlParameter("LinkPhone", model.LinkPhone));
            }


            if (model.CreateTime != null && model.CreateTime != new DateTime())
            {
                fileds.Add("[CreateTime]");
                pFileds.Add("@CreateTime");
                pms.Add(new SqlParameter("CreateTime", model.CreateTime));
            }


            if (model.OrderNumber != null)
            {
                fileds.Add("[OrderNumber]");
                pFileds.Add("@OrderNumber");
                pms.Add(new SqlParameter("OrderNumber", model.OrderNumber));
            }


            if (model.OrgLevel != null)
            {
                fileds.Add("[OrgLevel]");
                pFileds.Add("@OrgLevel");
                pms.Add(new SqlParameter("OrgLevel", model.OrgLevel));
            }


            if (model.BusiLevel != null)
            {
                fileds.Add("[BusiLevel]");
                pFileds.Add("@BusiLevel");
                pms.Add(new SqlParameter("BusiLevel", model.BusiLevel));
            }


            if (model.IsDel != null)
            {
                fileds.Add("[IsDel]");
                pFileds.Add("@IsDel");
                pms.Add(new SqlParameter("IsDel", model.IsDel));
            }


            if (model.FromSysID != null)
            {
                fileds.Add("[FromSysID]");
                pFileds.Add("@FromSysID");
                pms.Add(new SqlParameter("FromSysID", model.FromSysID));
            }


            if (model.FromSys != null)
            {
                fileds.Add("[FromSys]");
                pFileds.Add("@FromSys");
                pms.Add(new SqlParameter("FromSys", model.FromSys));
            }


            if (model.ParentShortName != null)
            {
                fileds.Add("[ParentShortName]");
                pFileds.Add("@ParentShortName");
                pms.Add(new SqlParameter("ParentShortName", model.ParentShortName));
            }


            if (model.HostID != null)
            {
                fileds.Add("[HostID]");
                pFileds.Add("@HostID");
                pms.Add(new SqlParameter("HostID", model.HostID));
            }


            if (model.IsEntity != null)
            {
                fileds.Add("[IsEntity]");
                pFileds.Add("@IsEntity");
                pms.Add(new SqlParameter("IsEntity", model.IsEntity));
            }


            if (model.BranchID != null)
            {
                fileds.Add("[BranchID]");
                pFileds.Add("@BranchID");
                pms.Add(new SqlParameter("BranchID", model.BranchID));
            }


            if (model.SchoolID != null)
            {
                fileds.Add("[SchoolID]");
                pFileds.Add("@SchoolID");
                pms.Add(new SqlParameter("SchoolID", model.SchoolID));
            }


            if (model.IsOnline != null)
            {
                fileds.Add("[IsOnline]");
                pFileds.Add("@IsOnline");
                pms.Add(new SqlParameter("IsOnline", model.IsOnline));
            }


            if (model.OnlineTime != null && model.OnlineTime != new DateTime())
            {
                fileds.Add("[OnlineTime]");
                pFileds.Add("@OnlineTime");
                pms.Add(new SqlParameter("OnlineTime", model.OnlineTime));
            }


            if (model.sortval != null)
            {
                fileds.Add("[sortval]");
                pFileds.Add("@sortval");
                pms.Add(new SqlParameter("sortval", model.sortval));
            }


            if (model.Schooltype != null)
            {
                fileds.Add("[Schooltype]");
                pFileds.Add("@Schooltype");
                pms.Add(new SqlParameter("Schooltype", model.Schooltype));
            }


            if (model.IsSubjectGroup != null)
            {
                fileds.Add("[IsSubjectGroup]");
                pFileds.Add("@IsSubjectGroup");
                pms.Add(new SqlParameter("IsSubjectGroup", model.IsSubjectGroup));
            }


            if (model.SchoolArea != null)
            {
                fileds.Add("[SchoolArea]");
                pFileds.Add("@SchoolArea");
                pms.Add(new SqlParameter("SchoolArea", model.SchoolArea));
            }


            if (model.OpenTime != null && model.OpenTime != new DateTime())
            {
                fileds.Add("[OpenTime]");
                pFileds.Add("@OpenTime");
                pms.Add(new SqlParameter("OpenTime", model.OpenTime));
            }


            if (model.OfficeType != null)
            {
                fileds.Add("[OfficeType]");
                pFileds.Add("@OfficeType");
                pms.Add(new SqlParameter("OfficeType", model.OfficeType));
            }


            if (model.HriCon != null)
            {
                fileds.Add("[HriCon]");
                pFileds.Add("@HriCon");
                pms.Add(new SqlParameter("HriCon", model.HriCon));
            }


            if (model.HriConID != null)
            {
                fileds.Add("[HriConID]");
                pFileds.Add("@HriConID");
                pms.Add(new SqlParameter("HriConID", model.HriConID));
            }


            if (model.NetArea != null)
            {
                fileds.Add("[NetArea]");
                pFileds.Add("@NetArea");
                pms.Add(new SqlParameter("NetArea", model.NetArea));
            }


            if (model.Station != null)
            {
                fileds.Add("[Station]");
                pFileds.Add("@Station");
                pms.Add(new SqlParameter("Station", model.Station));
            }

            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Organization (");
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

        public static bool Update(Organization model)
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
            pFileds.Add("[OrgID]=@OrgID");
            pms.Add(new SqlParameter("OrgID", model.OrgID));

            if (model.ParentOrgID != null)
            {
                fileds.Add("[ParentOrgID]=@ParentOrgID");
                pms.Add(new SqlParameter("ParentOrgID", model.ParentOrgID));
            }

            if (model.Path != null)
            {
                fileds.Add("[Path]=@Path");
                pms.Add(new SqlParameter("Path", model.Path));
            }

            if (model.OrgCode != null)
            {
                fileds.Add("[OrgCode]=@OrgCode");
                pms.Add(new SqlParameter("OrgCode", model.OrgCode));
            }

            if (model.OrgName != null)
            {
                fileds.Add("[OrgName]=@OrgName");
                pms.Add(new SqlParameter("OrgName", model.OrgName));
            }

            if (model.OrgCommName != null)
            {
                fileds.Add("[OrgCommName]=@OrgCommName");
                pms.Add(new SqlParameter("OrgCommName", model.OrgCommName));
            }

            if (model.FullPinyin != null)
            {
                fileds.Add("[FullPinyin]=@FullPinyin");
                pms.Add(new SqlParameter("FullPinyin", model.FullPinyin));
            }

            if (model.SimplePinyin != null)
            {
                fileds.Add("[SimplePinyin]=@SimplePinyin");
                pms.Add(new SqlParameter("SimplePinyin", model.SimplePinyin));
            }

            if (model.OtherName != null)
            {
                fileds.Add("[OtherName]=@OtherName");
                pms.Add(new SqlParameter("OtherName", model.OtherName));
            }

            if (model.ShortName != null)
            {
                fileds.Add("[ShortName]=@ShortName");
                pms.Add(new SqlParameter("ShortName", model.ShortName));
            }

            if (model.OrgType != null)
            {
                fileds.Add("[OrgType]=@OrgType");
                pms.Add(new SqlParameter("OrgType", model.OrgType));
            }

            if (model.Status != null)
            {
                fileds.Add("[Status]=@Status");
                pms.Add(new SqlParameter("Status", model.Status));
            }

            if (model.OrgProvince != null)
            {
                fileds.Add("[OrgProvince]=@OrgProvince");
                pms.Add(new SqlParameter("OrgProvince", model.OrgProvince));
            }

            if (model.OrgProvinceName != null)
            {
                fileds.Add("[OrgProvinceName]=@OrgProvinceName");
                pms.Add(new SqlParameter("OrgProvinceName", model.OrgProvinceName));
            }

            if (model.OrgCity != null)
            {
                fileds.Add("[OrgCity]=@OrgCity");
                pms.Add(new SqlParameter("OrgCity", model.OrgCity));
            }

            if (model.OrgCityName != null)
            {
                fileds.Add("[OrgCityName]=@OrgCityName");
                pms.Add(new SqlParameter("OrgCityName", model.OrgCityName));
            }

            if (model.LeagleOwner != null)
            {
                fileds.Add("[LeagleOwner]=@LeagleOwner");
                pms.Add(new SqlParameter("LeagleOwner", model.LeagleOwner));
            }

            if (model.OfficeAddress != null)
            {
                fileds.Add("[OfficeAddress]=@OfficeAddress");
                pms.Add(new SqlParameter("OfficeAddress", model.OfficeAddress));
            }

            if (model.LinkPhone != null)
            {
                fileds.Add("[LinkPhone]=@LinkPhone");
                pms.Add(new SqlParameter("LinkPhone", model.LinkPhone));
            }

            if (model.CreateTime != null && model.CreateTime != new DateTime())
            {
                fileds.Add("[CreateTime]=@CreateTime");
                pms.Add(new SqlParameter("CreateTime", model.CreateTime));
            }

            if (model.OrderNumber != null)
            {
                fileds.Add("[OrderNumber]=@OrderNumber");
                pms.Add(new SqlParameter("OrderNumber", model.OrderNumber));
            }

            if (model.OrgLevel != null)
            {
                fileds.Add("[OrgLevel]=@OrgLevel");
                pms.Add(new SqlParameter("OrgLevel", model.OrgLevel));
            }

            if (model.BusiLevel != null)
            {
                fileds.Add("[BusiLevel]=@BusiLevel");
                pms.Add(new SqlParameter("BusiLevel", model.BusiLevel));
            }

            if (model.IsDel != null)
            {
                fileds.Add("[IsDel]=@IsDel");
                pms.Add(new SqlParameter("IsDel", model.IsDel));
            }

            if (model.FromSysID != null)
            {
                fileds.Add("[FromSysID]=@FromSysID");
                pms.Add(new SqlParameter("FromSysID", model.FromSysID));
            }

            if (model.FromSys != null)
            {
                fileds.Add("[FromSys]=@FromSys");
                pms.Add(new SqlParameter("FromSys", model.FromSys));
            }

            if (model.ParentShortName != null)
            {
                fileds.Add("[ParentShortName]=@ParentShortName");
                pms.Add(new SqlParameter("ParentShortName", model.ParentShortName));
            }

            if (model.HostID != null)
            {
                fileds.Add("[HostID]=@HostID");
                pms.Add(new SqlParameter("HostID", model.HostID));
            }

            if (model.IsEntity != null)
            {
                fileds.Add("[IsEntity]=@IsEntity");
                pms.Add(new SqlParameter("IsEntity", model.IsEntity));
            }

            if (model.BranchID != null)
            {
                fileds.Add("[BranchID]=@BranchID");
                pms.Add(new SqlParameter("BranchID", model.BranchID));
            }

            if (model.SchoolID != null)
            {
                fileds.Add("[SchoolID]=@SchoolID");
                pms.Add(new SqlParameter("SchoolID", model.SchoolID));
            }

            if (model.IsOnline != null)
            {
                fileds.Add("[IsOnline]=@IsOnline");
                pms.Add(new SqlParameter("IsOnline", model.IsOnline));
            }

            if (model.OnlineTime != null && model.OnlineTime != new DateTime())
            {
                fileds.Add("[OnlineTime]=@OnlineTime");
                pms.Add(new SqlParameter("OnlineTime", model.OnlineTime));
            }

            if (model.sortval != null)
            {
                fileds.Add("[sortval]=@sortval");
                pms.Add(new SqlParameter("sortval", model.sortval));
            }

            if (model.Schooltype != null)
            {
                fileds.Add("[Schooltype]=@Schooltype");
                pms.Add(new SqlParameter("Schooltype", model.Schooltype));
            }

            if (model.IsSubjectGroup != null)
            {
                fileds.Add("[IsSubjectGroup]=@IsSubjectGroup");
                pms.Add(new SqlParameter("IsSubjectGroup", model.IsSubjectGroup));
            }

            if (model.SchoolArea != null)
            {
                fileds.Add("[SchoolArea]=@SchoolArea");
                pms.Add(new SqlParameter("SchoolArea", model.SchoolArea));
            }

            if (model.OpenTime != null && model.OpenTime != new DateTime())
            {
                fileds.Add("[OpenTime]=@OpenTime");
                pms.Add(new SqlParameter("OpenTime", model.OpenTime));
            }

            if (model.OfficeType != null)
            {
                fileds.Add("[OfficeType]=@OfficeType");
                pms.Add(new SqlParameter("OfficeType", model.OfficeType));
            }

            if (model.HriCon != null)
            {
                fileds.Add("[HriCon]=@HriCon");
                pms.Add(new SqlParameter("HriCon", model.HriCon));
            }

            if (model.HriConID != null)
            {
                fileds.Add("[HriConID]=@HriConID");
                pms.Add(new SqlParameter("HriConID", model.HriConID));
            }

            if (model.NetArea != null)
            {
                fileds.Add("[NetArea]=@NetArea");
                pms.Add(new SqlParameter("NetArea", model.NetArea));
            }

            if (model.Station != null)
            {
                fileds.Add("[Station]=@Station");
                pms.Add(new SqlParameter("Station", model.Station));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update Organization set ");
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

        public static bool Save(Organization model)
        {
            object obj = db.ExecuteScalar(CommandType.Text, "select count(1) from Organization where Gid='" + model.Gid + "'");
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