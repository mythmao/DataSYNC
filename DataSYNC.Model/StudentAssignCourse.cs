using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSYNC.Model
{
    public partial class StudentAssignCourse
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
        public System.Int64 AsignCourseID { get; set; }
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
        public System.Int32 SubjectID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 StudyTarget { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 NumberOfWeek { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime FirstCourseTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 HostID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String SubjectName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String RemediationIntentName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ProductName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ProductCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TeacherUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TeacherPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeacherName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String GradeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 GradeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String StudentName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 TeacherLevel { get; set; }
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
        public System.String TeacherStaffCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime LastModifyDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeacherLevelName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TOrgPath { get; set; }
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
        public System.String StudentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 MJobID { get; set; }
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
        public System.Int32 Enable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SubjectGroupID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String SubjectGroupName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 StudentSchoolID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SubjectGroupSchoolID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 CompanyID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TeachingSchoolID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeachingSchoolName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 MUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 MUserPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String MUserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ContractID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ContractCode { get; set; }
        #endregion
        public StudentAssignCourse() { }
        public StudentAssignCourse(DataRow dr)
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
            if (dr.Table.Columns.Contains("AsignCourseID"))
            {
                if (dr["AsignCourseID"] != DBNull.Value)
                {
                    this.AsignCourseID = (System.Int64)dr["AsignCourseID"];
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
            if (dr.Table.Columns.Contains("SubjectID"))
            {
                if (dr["SubjectID"] != DBNull.Value)
                {
                    this.SubjectID = (System.Int32)dr["SubjectID"];
                }
            }
            if (dr.Table.Columns.Contains("StudyTarget"))
            {
                if (dr["StudyTarget"] != DBNull.Value)
                {
                    this.StudyTarget = (System.Int32)dr["StudyTarget"];
                }
            }
            if (dr.Table.Columns.Contains("NumberOfWeek"))
            {
                if (dr["NumberOfWeek"] != DBNull.Value)
                {
                    this.NumberOfWeek = (System.Int32)dr["NumberOfWeek"];
                }
            }
            if (dr.Table.Columns.Contains("FirstCourseTime"))
            {
                if (dr["FirstCourseTime"] != DBNull.Value)
                {
                    this.FirstCourseTime = (System.DateTime)dr["FirstCourseTime"];
                }
            }
            if (dr.Table.Columns.Contains("CreateDate"))
            {
                if (dr["CreateDate"] != DBNull.Value)
                {
                    this.CreateDate = (System.DateTime)dr["CreateDate"];
                }
            }
            if (dr.Table.Columns.Contains("HostID"))
            {
                if (dr["HostID"] != DBNull.Value)
                {
                    this.HostID = (System.Int64)dr["HostID"];
                }
            }
            if (dr.Table.Columns.Contains("SubjectName"))
            {
                if (dr["SubjectName"] != DBNull.Value)
                {
                    this.SubjectName = (System.String)dr["SubjectName"];
                }
            }
            if (dr.Table.Columns.Contains("RemediationIntentName"))
            {
                if (dr["RemediationIntentName"] != DBNull.Value)
                {
                    this.RemediationIntentName = (System.String)dr["RemediationIntentName"];
                }
            }
            if (dr.Table.Columns.Contains("ProductName"))
            {
                if (dr["ProductName"] != DBNull.Value)
                {
                    this.ProductName = (System.String)dr["ProductName"];
                }
            }
            if (dr.Table.Columns.Contains("ProductCode"))
            {
                if (dr["ProductCode"] != DBNull.Value)
                {
                    this.ProductCode = (System.String)dr["ProductCode"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherUserID"))
            {
                if (dr["TeacherUserID"] != DBNull.Value)
                {
                    this.TeacherUserID = (System.Int64)dr["TeacherUserID"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherPassportID"))
            {
                if (dr["TeacherPassportID"] != DBNull.Value)
                {
                    this.TeacherPassportID = (System.Int64)dr["TeacherPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherName"))
            {
                if (dr["TeacherName"] != DBNull.Value)
                {
                    this.TeacherName = (System.String)dr["TeacherName"];
                }
            }
            if (dr.Table.Columns.Contains("GradeName"))
            {
                if (dr["GradeName"] != DBNull.Value)
                {
                    this.GradeName = (System.String)dr["GradeName"];
                }
            }
            if (dr.Table.Columns.Contains("GradeCode"))
            {
                if (dr["GradeCode"] != DBNull.Value)
                {
                    this.GradeCode = (System.Int32)dr["GradeCode"];
                }
            }
            if (dr.Table.Columns.Contains("StudentName"))
            {
                if (dr["StudentName"] != DBNull.Value)
                {
                    this.StudentName = (System.String)dr["StudentName"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherLevel"))
            {
                if (dr["TeacherLevel"] != DBNull.Value)
                {
                    this.TeacherLevel = (System.Int32)dr["TeacherLevel"];
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
            if (dr.Table.Columns.Contains("TeacherStaffCode"))
            {
                if (dr["TeacherStaffCode"] != DBNull.Value)
                {
                    this.TeacherStaffCode = (System.String)dr["TeacherStaffCode"];
                }
            }
            if (dr.Table.Columns.Contains("LastModifyDate"))
            {
                if (dr["LastModifyDate"] != DBNull.Value)
                {
                    this.LastModifyDate = (System.DateTime)dr["LastModifyDate"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherLevelName"))
            {
                if (dr["TeacherLevelName"] != DBNull.Value)
                {
                    this.TeacherLevelName = (System.String)dr["TeacherLevelName"];
                }
            }
            if (dr.Table.Columns.Contains("TOrgPath"))
            {
                if (dr["TOrgPath"] != DBNull.Value)
                {
                    this.TOrgPath = (System.String)dr["TOrgPath"];
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
            if (dr.Table.Columns.Contains("StudentCode"))
            {
                if (dr["StudentCode"] != DBNull.Value)
                {
                    this.StudentCode = (System.String)dr["StudentCode"];
                }
            }
            if (dr.Table.Columns.Contains("MJobID"))
            {
                if (dr["MJobID"] != DBNull.Value)
                {
                    this.MJobID = (System.Int64)dr["MJobID"];
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
            if (dr.Table.Columns.Contains("Enable"))
            {
                if (dr["Enable"] != DBNull.Value)
                {
                    this.Enable = (System.Int32)dr["Enable"];
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
            if (dr.Table.Columns.Contains("StudentSchoolID"))
            {
                if (dr["StudentSchoolID"] != DBNull.Value)
                {
                    this.StudentSchoolID = (System.Int64)dr["StudentSchoolID"];
                }
            }
            if (dr.Table.Columns.Contains("SubjectGroupSchoolID"))
            {
                if (dr["SubjectGroupSchoolID"] != DBNull.Value)
                {
                    this.SubjectGroupSchoolID = (System.Int64)dr["SubjectGroupSchoolID"];
                }
            }
            if (dr.Table.Columns.Contains("CompanyID"))
            {
                if (dr["CompanyID"] != DBNull.Value)
                {
                    this.CompanyID = (System.Int64)dr["CompanyID"];
                }
            }
            if (dr.Table.Columns.Contains("TeachingSchoolID"))
            {
                if (dr["TeachingSchoolID"] != DBNull.Value)
                {
                    this.TeachingSchoolID = (System.Int64)dr["TeachingSchoolID"];
                }
            }
            if (dr.Table.Columns.Contains("TeachingSchoolName"))
            {
                if (dr["TeachingSchoolName"] != DBNull.Value)
                {
                    this.TeachingSchoolName = (System.String)dr["TeachingSchoolName"];
                }
            }
            if (dr.Table.Columns.Contains("MUserID"))
            {
                if (dr["MUserID"] != DBNull.Value)
                {
                    this.MUserID = (System.Int64)dr["MUserID"];
                }
            }
            if (dr.Table.Columns.Contains("MUserPassportID"))
            {
                if (dr["MUserPassportID"] != DBNull.Value)
                {
                    this.MUserPassportID = (System.Int64)dr["MUserPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("MUserName"))
            {
                if (dr["MUserName"] != DBNull.Value)
                {
                    this.MUserName = (System.String)dr["MUserName"];
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
        }
    }
}