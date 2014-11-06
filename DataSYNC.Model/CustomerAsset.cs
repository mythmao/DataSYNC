using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSYNC.Model
{
    public partial class CustomerAsset
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
        public System.Int64 StudentID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal CommonCourseAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal SpecialCourseAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime LastCourseTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int16 HasTeacher { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal LeftAssetValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime InsertTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime ChangeTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal TotalCourseAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal TotalOrderedCourseAmount { get; set; }
        #endregion
        public CustomerAsset() { }
        public CustomerAsset(DataRow dr)
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
            if (dr.Table.Columns.Contains("StudentID"))
            {
                if (dr["StudentID"] != DBNull.Value)
                {
                    this.StudentID = (System.Int64)dr["StudentID"];
                }
            }
            if (dr.Table.Columns.Contains("CommonCourseAmount"))
            {
                if (dr["CommonCourseAmount"] != DBNull.Value)
                {
                    this.CommonCourseAmount = (System.Decimal)dr["CommonCourseAmount"];
                }
            }
            if (dr.Table.Columns.Contains("SpecialCourseAmount"))
            {
                if (dr["SpecialCourseAmount"] != DBNull.Value)
                {
                    this.SpecialCourseAmount = (System.Decimal)dr["SpecialCourseAmount"];
                }
            }
            if (dr.Table.Columns.Contains("LastCourseTime"))
            {
                if (dr["LastCourseTime"] != DBNull.Value)
                {
                    this.LastCourseTime = (System.DateTime)dr["LastCourseTime"];
                }
            }
            if (dr.Table.Columns.Contains("HasTeacher"))
            {
                if (dr["HasTeacher"] != DBNull.Value)
                {
                    this.HasTeacher = (System.Int16)dr["HasTeacher"];
                }
            }
            if (dr.Table.Columns.Contains("LeftAssetValue"))
            {
                if (dr["LeftAssetValue"] != DBNull.Value)
                {
                    this.LeftAssetValue = (System.Decimal)dr["LeftAssetValue"];
                }
            }
            if (dr.Table.Columns.Contains("InsertTime"))
            {
                if (dr["InsertTime"] != DBNull.Value)
                {
                    this.InsertTime = (System.DateTime)dr["InsertTime"];
                }
            }
            if (dr.Table.Columns.Contains("ChangeTime"))
            {
                if (dr["ChangeTime"] != DBNull.Value)
                {
                    this.ChangeTime = (System.DateTime)dr["ChangeTime"];
                }
            }
            if (dr.Table.Columns.Contains("TotalCourseAmount"))
            {
                if (dr["TotalCourseAmount"] != DBNull.Value)
                {
                    this.TotalCourseAmount = (System.Decimal)dr["TotalCourseAmount"];
                }
            }
            if (dr.Table.Columns.Contains("TotalOrderedCourseAmount"))
            {
                if (dr["TotalOrderedCourseAmount"] != DBNull.Value)
                {
                    this.TotalOrderedCourseAmount = (System.Decimal)dr["TotalOrderedCourseAmount"];
                }
            }
        }
    }
}