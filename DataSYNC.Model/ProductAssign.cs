using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSYNC.Model
{
    public partial class ProductAssign
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
        public System.Int64 ProductAssignID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 StudentID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 StudentPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ProductID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal AssignCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 HostID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime UpdateDate { get; set; }
        #endregion
        public ProductAssign() { }
        public ProductAssign(DataRow dr)
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
            if (dr.Table.Columns.Contains("ProductAssignID"))
            {
                if (dr["ProductAssignID"] != DBNull.Value)
                {
                    this.ProductAssignID = (System.Int64)dr["ProductAssignID"];
                }
            }
            if (dr.Table.Columns.Contains("StudentID"))
            {
                if (dr["StudentID"] != DBNull.Value)
                {
                    this.StudentID = (System.Int64)dr["StudentID"];
                }
            }
            if (dr.Table.Columns.Contains("StudentPassportID"))
            {
                if (dr["StudentPassportID"] != DBNull.Value)
                {
                    this.StudentPassportID = (System.Int64)dr["StudentPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("ProductID"))
            {
                if (dr["ProductID"] != DBNull.Value)
                {
                    this.ProductID = (System.Int64)dr["ProductID"];
                }
            }
            if (dr.Table.Columns.Contains("AssignCount"))
            {
                if (dr["AssignCount"] != DBNull.Value)
                {
                    this.AssignCount = (System.Decimal)dr["AssignCount"];
                }
            }
            if (dr.Table.Columns.Contains("HostID"))
            {
                if (dr["HostID"] != DBNull.Value)
                {
                    this.HostID = (System.Int64)dr["HostID"];
                }
            }
            if (dr.Table.Columns.Contains("UpdateDate"))
            {
                if (dr["UpdateDate"] != DBNull.Value)
                {
                    this.UpdateDate = (System.DateTime)dr["UpdateDate"];
                }
            }
        }
    }
}