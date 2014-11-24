using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSYNC.Model
{
    public partial class AsignCourseVoucher
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
        public System.Int64 VoucherID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 AsignCourseID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte VoucherType { get; set; }
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
        public System.Int64 TeacherID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TeacherPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime SubmitTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime CreatTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime AuditTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 VoucherState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String Reason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeacherName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String Submiter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TeacherJobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TeacherJobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TOrgPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeacherStaffCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 MJobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 MJobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String POrgPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 TeacherType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeacherTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SubjectGroupID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String SubjectGroupName { get; set; }
        #endregion
        public AsignCourseVoucher() { }
        public AsignCourseVoucher(DataRow dr)
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
            if (dr.Table.Columns.Contains("VoucherID"))
            {
                if (dr["VoucherID"] != DBNull.Value)
                {
                    this.VoucherID = (System.Int64)dr["VoucherID"];
                }
            }
            if (dr.Table.Columns.Contains("AsignCourseID"))
            {
                if (dr["AsignCourseID"] != DBNull.Value)
                {
                    this.AsignCourseID = (System.Int64)dr["AsignCourseID"];
                }
            }
            if (dr.Table.Columns.Contains("VoucherType"))
            {
                if (dr["VoucherType"] != DBNull.Value)
                {
                    this.VoucherType = (System.Byte)dr["VoucherType"];
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
            if (dr.Table.Columns.Contains("TeacherID"))
            {
                if (dr["TeacherID"] != DBNull.Value)
                {
                    this.TeacherID = (System.Int64)dr["TeacherID"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherPassportID"))
            {
                if (dr["TeacherPassportID"] != DBNull.Value)
                {
                    this.TeacherPassportID = (System.Int64)dr["TeacherPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("SubmitTime"))
            {
                if (dr["SubmitTime"] != DBNull.Value)
                {
                    this.SubmitTime = (System.DateTime)dr["SubmitTime"];
                }
            }
            if (dr.Table.Columns.Contains("CreatTime"))
            {
                if (dr["CreatTime"] != DBNull.Value)
                {
                    this.CreatTime = (System.DateTime)dr["CreatTime"];
                }
            }
            if (dr.Table.Columns.Contains("AuditTime"))
            {
                if (dr["AuditTime"] != DBNull.Value)
                {
                    this.AuditTime = (System.DateTime)dr["AuditTime"];
                }
            }
            if (dr.Table.Columns.Contains("VoucherState"))
            {
                if (dr["VoucherState"] != DBNull.Value)
                {
                    this.VoucherState = (System.Int64)dr["VoucherState"];
                }
            }
            if (dr.Table.Columns.Contains("Reason"))
            {
                if (dr["Reason"] != DBNull.Value)
                {
                    this.Reason = (System.String)dr["Reason"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherName"))
            {
                if (dr["TeacherName"] != DBNull.Value)
                {
                    this.TeacherName = (System.String)dr["TeacherName"];
                }
            }
            if (dr.Table.Columns.Contains("Submiter"))
            {
                if (dr["Submiter"] != DBNull.Value)
                {
                    this.Submiter = (System.String)dr["Submiter"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherJobID"))
            {
                if (dr["TeacherJobID"] != DBNull.Value)
                {
                    this.TeacherJobID = (System.Int64)dr["TeacherJobID"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherJobPassportID"))
            {
                if (dr["TeacherJobPassportID"] != DBNull.Value)
                {
                    this.TeacherJobPassportID = (System.Int64)dr["TeacherJobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("TOrgPath"))
            {
                if (dr["TOrgPath"] != DBNull.Value)
                {
                    this.TOrgPath = (System.String)dr["TOrgPath"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherStaffCode"))
            {
                if (dr["TeacherStaffCode"] != DBNull.Value)
                {
                    this.TeacherStaffCode = (System.String)dr["TeacherStaffCode"];
                }
            }
            if (dr.Table.Columns.Contains("MJobID"))
            {
                if (dr["MJobID"] != DBNull.Value)
                {
                    this.MJobID = (System.Int64)dr["MJobID"];
                }
            }
            if (dr.Table.Columns.Contains("MJobPassportID"))
            {
                if (dr["MJobPassportID"] != DBNull.Value)
                {
                    this.MJobPassportID = (System.Int64)dr["MJobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("POrgPath"))
            {
                if (dr["POrgPath"] != DBNull.Value)
                {
                    this.POrgPath = (System.String)dr["POrgPath"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherType"))
            {
                if (dr["TeacherType"] != DBNull.Value)
                {
                    this.TeacherType = (System.Int32)dr["TeacherType"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherTypeName"))
            {
                if (dr["TeacherTypeName"] != DBNull.Value)
                {
                    this.TeacherTypeName = (System.String)dr["TeacherTypeName"];
                }
            }
            if (dr.Table.Columns.Contains("SubjectGroupID"))
            {
                if (dr["SubjectGroupID"] != DBNull.Value)
                {
                    this.SubjectGroupID = (System.Int64)dr["SubjectGroupID"];
                }
            }
            if (dr.Table.Columns.Contains("SubjectGroupName"))
            {
                if (dr["SubjectGroupName"] != DBNull.Value)
                {
                    this.SubjectGroupName = (System.String)dr["SubjectGroupName"];
                }
            }
        }
    }
}