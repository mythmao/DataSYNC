using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSYNC.Model
{
    public partial class Organization
    {
        #region 属性
        /// <summary>
        /// 
        /// </summary>
        public System.Guid Gid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 RecordStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 OrgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ParentOrgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String Path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OrgCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OrgName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OrgCommName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String FullPinyin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String SimplePinyin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OtherName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ShortName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 OrgType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 OrgProvince { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OrgProvinceName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 OrgCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OrgCityName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String LeagleOwner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OfficeAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String LinkPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OrderNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 OrgLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 BusiLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 IsDel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 FromSysID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String FromSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ParentShortName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 HostID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 IsEntity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 BranchID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SchoolID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int16 IsOnline { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime OnlineTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 sortval { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 Schooltype { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int16 IsSubjectGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal SchoolArea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime OpenTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 OfficeType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String HriCon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String HriConID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal NetArea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 Station { get; set; }
        #endregion
        public Organization() { }
        public Organization(DataRow dr)
        {
            if (dr.Table.Columns.Contains("Gid"))
            {
                if (dr["Gid"] != DBNull.Value)
                {
                    this.Gid = (System.Guid)dr["Gid"];
                }
            }
            if (dr.Table.Columns.Contains("LastUpdateTime"))
            {
                if (dr["LastUpdateTime"] != DBNull.Value)
                {
                    this.LastUpdateTime = (System.DateTime)dr["LastUpdateTime"];
                }
            }
            if (dr.Table.Columns.Contains("RecordStatus"))
            {
                if (dr["RecordStatus"] != DBNull.Value)
                {
                    this.RecordStatus = (System.Int32)dr["RecordStatus"];
                }
            }
            if (dr.Table.Columns.Contains("OrgID"))
            {
                if (dr["OrgID"] != DBNull.Value)
                {
                    this.OrgID = (System.Int64)dr["OrgID"];
                }
            }
            if (dr.Table.Columns.Contains("ParentOrgID"))
            {
                if (dr["ParentOrgID"] != DBNull.Value)
                {
                    this.ParentOrgID = (System.Int64)dr["ParentOrgID"];
                }
            }
            if (dr.Table.Columns.Contains("Path"))
            {
                if (dr["Path"] != DBNull.Value)
                {
                    this.Path = (System.String)dr["Path"];
                }
            }
            if (dr.Table.Columns.Contains("OrgCode"))
            {
                if (dr["OrgCode"] != DBNull.Value)
                {
                    this.OrgCode = (System.String)dr["OrgCode"];
                }
            }
            if (dr.Table.Columns.Contains("OrgName"))
            {
                if (dr["OrgName"] != DBNull.Value)
                {
                    this.OrgName = (System.String)dr["OrgName"];
                }
            }
            if (dr.Table.Columns.Contains("OrgCommName"))
            {
                if (dr["OrgCommName"] != DBNull.Value)
                {
                    this.OrgCommName = (System.String)dr["OrgCommName"];
                }
            }
            if (dr.Table.Columns.Contains("FullPinyin"))
            {
                if (dr["FullPinyin"] != DBNull.Value)
                {
                    this.FullPinyin = (System.String)dr["FullPinyin"];
                }
            }
            if (dr.Table.Columns.Contains("SimplePinyin"))
            {
                if (dr["SimplePinyin"] != DBNull.Value)
                {
                    this.SimplePinyin = (System.String)dr["SimplePinyin"];
                }
            }
            if (dr.Table.Columns.Contains("OtherName"))
            {
                if (dr["OtherName"] != DBNull.Value)
                {
                    this.OtherName = (System.String)dr["OtherName"];
                }
            }
            if (dr.Table.Columns.Contains("ShortName"))
            {
                if (dr["ShortName"] != DBNull.Value)
                {
                    this.ShortName = (System.String)dr["ShortName"];
                }
            }
            if (dr.Table.Columns.Contains("OrgType"))
            {
                if (dr["OrgType"] != DBNull.Value)
                {
                    this.OrgType = (System.Int64)dr["OrgType"];
                }
            }
            if (dr.Table.Columns.Contains("Status"))
            {
                if (dr["Status"] != DBNull.Value)
                {
                    this.Status = (System.Int32)dr["Status"];
                }
            }
            if (dr.Table.Columns.Contains("OrgProvince"))
            {
                if (dr["OrgProvince"] != DBNull.Value)
                {
                    this.OrgProvince = (System.Int64)dr["OrgProvince"];
                }
            }
            if (dr.Table.Columns.Contains("OrgProvinceName"))
            {
                if (dr["OrgProvinceName"] != DBNull.Value)
                {
                    this.OrgProvinceName = (System.String)dr["OrgProvinceName"];
                }
            }
            if (dr.Table.Columns.Contains("OrgCity"))
            {
                if (dr["OrgCity"] != DBNull.Value)
                {
                    this.OrgCity = (System.Int64)dr["OrgCity"];
                }
            }
            if (dr.Table.Columns.Contains("OrgCityName"))
            {
                if (dr["OrgCityName"] != DBNull.Value)
                {
                    this.OrgCityName = (System.String)dr["OrgCityName"];
                }
            }
            if (dr.Table.Columns.Contains("LeagleOwner"))
            {
                if (dr["LeagleOwner"] != DBNull.Value)
                {
                    this.LeagleOwner = (System.String)dr["LeagleOwner"];
                }
            }
            if (dr.Table.Columns.Contains("OfficeAddress"))
            {
                if (dr["OfficeAddress"] != DBNull.Value)
                {
                    this.OfficeAddress = (System.String)dr["OfficeAddress"];
                }
            }
            if (dr.Table.Columns.Contains("LinkPhone"))
            {
                if (dr["LinkPhone"] != DBNull.Value)
                {
                    this.LinkPhone = (System.String)dr["LinkPhone"];
                }
            }
            if (dr.Table.Columns.Contains("CreateTime"))
            {
                if (dr["CreateTime"] != DBNull.Value)
                {
                    this.CreateTime = (System.DateTime)dr["CreateTime"];
                }
            }
            if (dr.Table.Columns.Contains("OrderNumber"))
            {
                if (dr["OrderNumber"] != DBNull.Value)
                {
                    this.OrderNumber = (System.String)dr["OrderNumber"];
                }
            }
            if (dr.Table.Columns.Contains("OrgLevel"))
            {
                if (dr["OrgLevel"] != DBNull.Value)
                {
                    this.OrgLevel = (System.Int32)dr["OrgLevel"];
                }
            }
            if (dr.Table.Columns.Contains("BusiLevel"))
            {
                if (dr["BusiLevel"] != DBNull.Value)
                {
                    this.BusiLevel = (System.Int32)dr["BusiLevel"];
                }
            }
            if (dr.Table.Columns.Contains("IsDel"))
            {
                if (dr["IsDel"] != DBNull.Value)
                {
                    this.IsDel = (System.Int32)dr["IsDel"];
                }
            }
            if (dr.Table.Columns.Contains("FromSysID"))
            {
                if (dr["FromSysID"] != DBNull.Value)
                {
                    this.FromSysID = (System.Int64)dr["FromSysID"];
                }
            }
            if (dr.Table.Columns.Contains("FromSys"))
            {
                if (dr["FromSys"] != DBNull.Value)
                {
                    this.FromSys = (System.String)dr["FromSys"];
                }
            }
            if (dr.Table.Columns.Contains("ParentShortName"))
            {
                if (dr["ParentShortName"] != DBNull.Value)
                {
                    this.ParentShortName = (System.String)dr["ParentShortName"];
                }
            }
            if (dr.Table.Columns.Contains("HostID"))
            {
                if (dr["HostID"] != DBNull.Value)
                {
                    this.HostID = (System.Int64)dr["HostID"];
                }
            }
            if (dr.Table.Columns.Contains("IsEntity"))
            {
                if (dr["IsEntity"] != DBNull.Value)
                {
                    this.IsEntity = (System.Int32)dr["IsEntity"];
                }
            }
            if (dr.Table.Columns.Contains("BranchID"))
            {
                if (dr["BranchID"] != DBNull.Value)
                {
                    this.BranchID = (System.Int64)dr["BranchID"];
                }
            }
            if (dr.Table.Columns.Contains("SchoolID"))
            {
                if (dr["SchoolID"] != DBNull.Value)
                {
                    this.SchoolID = (System.Int64)dr["SchoolID"];
                }
            }
            if (dr.Table.Columns.Contains("IsOnline"))
            {
                if (dr["IsOnline"] != DBNull.Value)
                {
                    this.IsOnline = (System.Int16)dr["IsOnline"];
                }
            }
            if (dr.Table.Columns.Contains("OnlineTime"))
            {
                if (dr["OnlineTime"] != DBNull.Value)
                {
                    this.OnlineTime = (System.DateTime)dr["OnlineTime"];
                }
            }
            if (dr.Table.Columns.Contains("sortval"))
            {
                if (dr["sortval"] != DBNull.Value)
                {
                    this.sortval = (System.Int32)dr["sortval"];
                }
            }
            if (dr.Table.Columns.Contains("Schooltype"))
            {
                if (dr["Schooltype"] != DBNull.Value)
                {
                    this.Schooltype = (System.Int32)dr["Schooltype"];
                }
            }
            if (dr.Table.Columns.Contains("IsSubjectGroup"))
            {
                if (dr["IsSubjectGroup"] != DBNull.Value)
                {
                    this.IsSubjectGroup = (System.Int16)dr["IsSubjectGroup"];
                }
            }
            if (dr.Table.Columns.Contains("SchoolArea"))
            {
                if (dr["SchoolArea"] != DBNull.Value)
                {
                    this.SchoolArea = (System.Decimal)dr["SchoolArea"];
                }
            }
            if (dr.Table.Columns.Contains("OpenTime"))
            {
                if (dr["OpenTime"] != DBNull.Value)
                {
                    this.OpenTime = (System.DateTime)dr["OpenTime"];
                }
            }
            if (dr.Table.Columns.Contains("OfficeType"))
            {
                if (dr["OfficeType"] != DBNull.Value)
                {
                    this.OfficeType = (System.Int32)dr["OfficeType"];
                }
            }
            if (dr.Table.Columns.Contains("HriCon"))
            {
                if (dr["HriCon"] != DBNull.Value)
                {
                    this.HriCon = (System.String)dr["HriCon"];
                }
            }
            if (dr.Table.Columns.Contains("HriConID"))
            {
                if (dr["HriConID"] != DBNull.Value)
                {
                    this.HriConID = (System.String)dr["HriConID"];
                }
            }
            if (dr.Table.Columns.Contains("NetArea"))
            {
                if (dr["NetArea"] != DBNull.Value)
                {
                    this.NetArea = (System.Decimal)dr["NetArea"];
                }
            }
            if (dr.Table.Columns.Contains("Station"))
            {
                if (dr["Station"] != DBNull.Value)
                {
                    this.Station = (System.Int32)dr["Station"];
                }
            }
        }
    }
}