using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSYNC.Model
{
    public partial class CSRelation
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
        public System.Int64 ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 CustomerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 JobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 OrganizationID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 StaffUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 StaffPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int16 Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 RelationType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime InsertTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime UpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 PreRelationID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 Rank { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 HostID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 JobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 CustomerPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 CustomerUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ProductID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ProductName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte[] LastModified { get; set; }
        #endregion
        public CSRelation() { }
        public CSRelation(DataRow dr)
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
            if (dr.Table.Columns.Contains("ID"))
            {
                if (dr["ID"] != DBNull.Value)
                {
                    this.ID = (System.Int64)dr["ID"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerID"))
            {
                if (dr["CustomerID"] != DBNull.Value)
                {
                    this.CustomerID = (System.Int64)dr["CustomerID"];
                }
            }
            if (dr.Table.Columns.Contains("JobPassportID"))
            {
                if (dr["JobPassportID"] != DBNull.Value)
                {
                    this.JobPassportID = (System.Int64)dr["JobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("OrganizationID"))
            {
                if (dr["OrganizationID"] != DBNull.Value)
                {
                    this.OrganizationID = (System.Int64)dr["OrganizationID"];
                }
            }
            if (dr.Table.Columns.Contains("StaffUserID"))
            {
                if (dr["StaffUserID"] != DBNull.Value)
                {
                    this.StaffUserID = (System.Int64)dr["StaffUserID"];
                }
            }
            if (dr.Table.Columns.Contains("StaffPassportID"))
            {
                if (dr["StaffPassportID"] != DBNull.Value)
                {
                    this.StaffPassportID = (System.Int64)dr["StaffPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("Status"))
            {
                if (dr["Status"] != DBNull.Value)
                {
                    this.Status = (System.Int16)dr["Status"];
                }
            }
            if (dr.Table.Columns.Contains("RelationType"))
            {
                if (dr["RelationType"] != DBNull.Value)
                {
                    this.RelationType = (System.Int64)dr["RelationType"];
                }
            }
            if (dr.Table.Columns.Contains("InsertTime"))
            {
                if (dr["InsertTime"] != DBNull.Value)
                {
                    this.InsertTime = (System.DateTime)dr["InsertTime"];
                }
            }
            if (dr.Table.Columns.Contains("UpdateTime"))
            {
                if (dr["UpdateTime"] != DBNull.Value)
                {
                    this.UpdateTime = (System.DateTime)dr["UpdateTime"];
                }
            }
            if (dr.Table.Columns.Contains("PreRelationID"))
            {
                if (dr["PreRelationID"] != DBNull.Value)
                {
                    this.PreRelationID = (System.Int64)dr["PreRelationID"];
                }
            }
            if (dr.Table.Columns.Contains("Rank"))
            {
                if (dr["Rank"] != DBNull.Value)
                {
                    this.Rank = (System.Int32)dr["Rank"];
                }
            }
            if (dr.Table.Columns.Contains("HostID"))
            {
                if (dr["HostID"] != DBNull.Value)
                {
                    this.HostID = (System.Int64)dr["HostID"];
                }
            }
            if (dr.Table.Columns.Contains("EndTime"))
            {
                if (dr["EndTime"] != DBNull.Value)
                {
                    this.EndTime = (System.DateTime)dr["EndTime"];
                }
            }
            if (dr.Table.Columns.Contains("JobID"))
            {
                if (dr["JobID"] != DBNull.Value)
                {
                    this.JobID = (System.Int64)dr["JobID"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerPassportID"))
            {
                if (dr["CustomerPassportID"] != DBNull.Value)
                {
                    this.CustomerPassportID = (System.Int64)dr["CustomerPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerUserID"))
            {
                if (dr["CustomerUserID"] != DBNull.Value)
                {
                    this.CustomerUserID = (System.Int64)dr["CustomerUserID"];
                }
            }
            if (dr.Table.Columns.Contains("ProductID"))
            {
                if (dr["ProductID"] != DBNull.Value)
                {
                    this.ProductID = (System.Int64)dr["ProductID"];
                }
            }
            if (dr.Table.Columns.Contains("ProductName"))
            {
                if (dr["ProductName"] != DBNull.Value)
                {
                    this.ProductName = (System.String)dr["ProductName"];
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