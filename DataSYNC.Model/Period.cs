using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSYNC.Model
{
    public partial class Period
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
        public System.Int64 AutoID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 AssetID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 AssortedProductID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 BaseProductID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 CounterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 PurchaseItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 PurchaseItemDetailID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal PurchasePrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte StartTimeType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 StartDelayLength { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte EndTimeType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 EndDelayLength { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime RealStartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime RealEndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal ReturnCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal ReturnMoney { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime ReturnTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte[] LastModified { get; set; }
        #endregion
        public Period() { }
        public Period(DataRow dr)
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
            if (dr.Table.Columns.Contains("AutoID"))
            {
                if (dr["AutoID"] != DBNull.Value)
                {
                    this.AutoID = (System.Int64)dr["AutoID"];
                }
            }
            if (dr.Table.Columns.Contains("AssetID"))
            {
                if (dr["AssetID"] != DBNull.Value)
                {
                    this.AssetID = (System.Int64)dr["AssetID"];
                }
            }
            if (dr.Table.Columns.Contains("AssortedProductID"))
            {
                if (dr["AssortedProductID"] != DBNull.Value)
                {
                    this.AssortedProductID = (System.Int64)dr["AssortedProductID"];
                }
            }
            if (dr.Table.Columns.Contains("BaseProductID"))
            {
                if (dr["BaseProductID"] != DBNull.Value)
                {
                    this.BaseProductID = (System.Int64)dr["BaseProductID"];
                }
            }
            if (dr.Table.Columns.Contains("CounterID"))
            {
                if (dr["CounterID"] != DBNull.Value)
                {
                    this.CounterID = (System.Int64)dr["CounterID"];
                }
            }
            if (dr.Table.Columns.Contains("PurchaseItemID"))
            {
                if (dr["PurchaseItemID"] != DBNull.Value)
                {
                    this.PurchaseItemID = (System.Int64)dr["PurchaseItemID"];
                }
            }
            if (dr.Table.Columns.Contains("PurchaseItemDetailID"))
            {
                if (dr["PurchaseItemDetailID"] != DBNull.Value)
                {
                    this.PurchaseItemDetailID = (System.Int64)dr["PurchaseItemDetailID"];
                }
            }
            if (dr.Table.Columns.Contains("PurchasePrice"))
            {
                if (dr["PurchasePrice"] != DBNull.Value)
                {
                    this.PurchasePrice = (System.Decimal)dr["PurchasePrice"];
                }
            }
            if (dr.Table.Columns.Contains("StartTimeType"))
            {
                if (dr["StartTimeType"] != DBNull.Value)
                {
                    this.StartTimeType = (System.Byte)dr["StartTimeType"];
                }
            }
            if (dr.Table.Columns.Contains("StartDelayLength"))
            {
                if (dr["StartDelayLength"] != DBNull.Value)
                {
                    this.StartDelayLength = (System.Int32)dr["StartDelayLength"];
                }
            }
            if (dr.Table.Columns.Contains("EndTimeType"))
            {
                if (dr["EndTimeType"] != DBNull.Value)
                {
                    this.EndTimeType = (System.Byte)dr["EndTimeType"];
                }
            }
            if (dr.Table.Columns.Contains("EndDelayLength"))
            {
                if (dr["EndDelayLength"] != DBNull.Value)
                {
                    this.EndDelayLength = (System.Int32)dr["EndDelayLength"];
                }
            }
            if (dr.Table.Columns.Contains("RealStartTime"))
            {
                if (dr["RealStartTime"] != DBNull.Value)
                {
                    this.RealStartTime = (System.DateTime)dr["RealStartTime"];
                }
            }
            if (dr.Table.Columns.Contains("RealEndTime"))
            {
                if (dr["RealEndTime"] != DBNull.Value)
                {
                    this.RealEndTime = (System.DateTime)dr["RealEndTime"];
                }
            }
            if (dr.Table.Columns.Contains("ReturnCount"))
            {
                if (dr["ReturnCount"] != DBNull.Value)
                {
                    this.ReturnCount = (System.Decimal)dr["ReturnCount"];
                }
            }
            if (dr.Table.Columns.Contains("ReturnMoney"))
            {
                if (dr["ReturnMoney"] != DBNull.Value)
                {
                    this.ReturnMoney = (System.Decimal)dr["ReturnMoney"];
                }
            }
            if (dr.Table.Columns.Contains("ReturnTime"))
            {
                if (dr["ReturnTime"] != DBNull.Value)
                {
                    this.ReturnTime = (System.DateTime)dr["ReturnTime"];
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