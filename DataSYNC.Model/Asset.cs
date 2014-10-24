using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSYNC.Model
{
    public partial class Asset
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
        public System.Int64 AssetID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte OwnerType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 OwnerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 OwnerPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ExchangeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SubCompanyID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SchoolID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ContractID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ContractCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte AssetType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime AssetCreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime StartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal AssetCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal RemainCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal LockCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte AssetState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte FreezeType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte AssetSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 HostID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal WaitRMCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ChangeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte[] LastModified { get; set; }
        #endregion
        public Asset() { }
        public Asset(DataRow dr)
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
            if (dr.Table.Columns.Contains("AssetID"))
            {
                if (dr["AssetID"] != DBNull.Value)
                {
                    this.AssetID = (System.Int64)dr["AssetID"];
                }
            }
            if (dr.Table.Columns.Contains("OwnerType"))
            {
                if (dr["OwnerType"] != DBNull.Value)
                {
                    this.OwnerType = (System.Byte)dr["OwnerType"];
                }
            }
            if (dr.Table.Columns.Contains("OwnerID"))
            {
                if (dr["OwnerID"] != DBNull.Value)
                {
                    this.OwnerID = (System.Int64)dr["OwnerID"];
                }
            }
            if (dr.Table.Columns.Contains("OwnerPassportID"))
            {
                if (dr["OwnerPassportID"] != DBNull.Value)
                {
                    this.OwnerPassportID = (System.Int64)dr["OwnerPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("ExchangeID"))
            {
                if (dr["ExchangeID"] != DBNull.Value)
                {
                    this.ExchangeID = (System.Int64)dr["ExchangeID"];
                }
            }
            if (dr.Table.Columns.Contains("SubCompanyID"))
            {
                if (dr["SubCompanyID"] != DBNull.Value)
                {
                    this.SubCompanyID = (System.Int64)dr["SubCompanyID"];
                }
            }
            if (dr.Table.Columns.Contains("SchoolID"))
            {
                if (dr["SchoolID"] != DBNull.Value)
                {
                    this.SchoolID = (System.Int64)dr["SchoolID"];
                }
            }
            if (dr.Table.Columns.Contains("ContractID"))
            {
                if (dr["ContractID"] != DBNull.Value)
                {
                    this.ContractID = (System.Int64)dr["ContractID"];
                }
            }
            if (dr.Table.Columns.Contains("ContractCode"))
            {
                if (dr["ContractCode"] != DBNull.Value)
                {
                    this.ContractCode = (System.String)dr["ContractCode"];
                }
            }
            if (dr.Table.Columns.Contains("AssetType"))
            {
                if (dr["AssetType"] != DBNull.Value)
                {
                    this.AssetType = (System.Byte)dr["AssetType"];
                }
            }
            if (dr.Table.Columns.Contains("AssetCreateDate"))
            {
                if (dr["AssetCreateDate"] != DBNull.Value)
                {
                    this.AssetCreateDate = (System.DateTime)dr["AssetCreateDate"];
                }
            }
            if (dr.Table.Columns.Contains("StartTime"))
            {
                if (dr["StartTime"] != DBNull.Value)
                {
                    this.StartTime = (System.DateTime)dr["StartTime"];
                }
            }
            if (dr.Table.Columns.Contains("EndTime"))
            {
                if (dr["EndTime"] != DBNull.Value)
                {
                    this.EndTime = (System.DateTime)dr["EndTime"];
                }
            }
            if (dr.Table.Columns.Contains("AssetCount"))
            {
                if (dr["AssetCount"] != DBNull.Value)
                {
                    this.AssetCount = (System.Decimal)dr["AssetCount"];
                }
            }
            if (dr.Table.Columns.Contains("RemainCount"))
            {
                if (dr["RemainCount"] != DBNull.Value)
                {
                    this.RemainCount = (System.Decimal)dr["RemainCount"];
                }
            }
            if (dr.Table.Columns.Contains("LockCount"))
            {
                if (dr["LockCount"] != DBNull.Value)
                {
                    this.LockCount = (System.Decimal)dr["LockCount"];
                }
            }
            if (dr.Table.Columns.Contains("AssetState"))
            {
                if (dr["AssetState"] != DBNull.Value)
                {
                    this.AssetState = (System.Byte)dr["AssetState"];
                }
            }
            if (dr.Table.Columns.Contains("FreezeType"))
            {
                if (dr["FreezeType"] != DBNull.Value)
                {
                    this.FreezeType = (System.Byte)dr["FreezeType"];
                }
            }
            if (dr.Table.Columns.Contains("AssetSource"))
            {
                if (dr["AssetSource"] != DBNull.Value)
                {
                    this.AssetSource = (System.Byte)dr["AssetSource"];
                }
            }
            if (dr.Table.Columns.Contains("HostID"))
            {
                if (dr["HostID"] != DBNull.Value)
                {
                    this.HostID = (System.Int64)dr["HostID"];
                }
            }
            if (dr.Table.Columns.Contains("WaitRMCount"))
            {
                if (dr["WaitRMCount"] != DBNull.Value)
                {
                    this.WaitRMCount = (System.Decimal)dr["WaitRMCount"];
                }
            }
            if (dr.Table.Columns.Contains("ChangeID"))
            {
                if (dr["ChangeID"] != DBNull.Value)
                {
                    this.ChangeID = (System.Int64)dr["ChangeID"];
                }
            }
            if (dr.Table.Columns.Contains("LastModified"))
            {
                if (dr["LastModified"] != DBNull.Value)
                {
                    this.LastModified = (System.Byte[])dr["LastModified"];
                }
            }
        }
    }
}