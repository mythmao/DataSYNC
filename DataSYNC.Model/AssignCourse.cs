using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSYNC.Model
{
    public partial class AssignCourse
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
        public System.Int64 AssignID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 AsignCourseID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 EventID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 StudentUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 StudentPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String StudentName { get; set; }
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
        public System.Int64 TeacherJobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TeacherJobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeacherName { get; set; }
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
        public System.DateTime StartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal AssignCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte AsignType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte AsignStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime LastModifiedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 SubjectID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 GradeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 TeacherPatternID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 PUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 PUserPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ManagerUserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SchoolID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String SchoolName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 CompanyID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String CompanyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String SubjectName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String GradeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte HasAnalyse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime AnalyseTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 HostID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String StuendtCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeacherCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TOrgPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ManagerJobPassPortID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String POrgPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeacherPatternName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 PJobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String PUserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TeacherSchoolID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OAUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 OldSchoolID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal TeachHours { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ConsultatorName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ConsultatorUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ConsultatorPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ConsultatorPassportJobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TeacherType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeacherTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 CourseSourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ManagerUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ManagerUserPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ConsultatorNames { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 CourseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 MasterProductID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String MasterProductName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 CustomerType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ParentAssignID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte AssignConsumeStatus { get; set; }
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
        public System.Int64 TeacherSubjectGroupID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeacherSubjectGroupName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal CourseTimeLong { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal ConsumeCountHours { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime FinancialTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime CourseConfirmTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte CancelType { get; set; }
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
        public System.String ContractCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 AbnormalReasonType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 TeachingVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String CoursePlanCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String AllCourseCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String CourseTask { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String InstructionalObjectives { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeachingFocus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeachingDifficulties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 PlanStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 PlanUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 PlanUserPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String PlanUserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 PlanJobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime PlanCreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeacherActivity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String StudentActivity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 ConformStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ClassTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 ConfirmPersonStyle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 ConfirmSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte[] LastModified { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime LastModifyDate { get; set; }
        #endregion
        public AssignCourse() { }
        public AssignCourse(DataRow dr)
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
            if (dr.Table.Columns.Contains("AssignID"))
            {
                if (dr["AssignID"] != DBNull.Value)
                {
                    this.AssignID = (System.Int64)dr["AssignID"];
                }
            }
            if (dr.Table.Columns.Contains("AsignCourseID"))
            {
                if (dr["AsignCourseID"] != DBNull.Value)
                {
                    this.AsignCourseID = (System.Int64)dr["AsignCourseID"];
                }
            }
            if (dr.Table.Columns.Contains("EventID"))
            {
                if (dr["EventID"] != DBNull.Value)
                {
                    this.EventID = (System.Int64)dr["EventID"];
                }
            }
            if (dr.Table.Columns.Contains("StudentUserID"))
            {
                if (dr["StudentUserID"] != DBNull.Value)
                {
                    this.StudentUserID = (System.Int64)dr["StudentUserID"];
                }
            }
            if (dr.Table.Columns.Contains("StudentPassportID"))
            {
                if (dr["StudentPassportID"] != DBNull.Value)
                {
                    this.StudentPassportID = (System.Int64)dr["StudentPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("StudentName"))
            {
                if (dr["StudentName"] != DBNull.Value)
                {
                    this.StudentName = (System.String)dr["StudentName"];
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
            if (dr.Table.Columns.Contains("TeacherName"))
            {
                if (dr["TeacherName"] != DBNull.Value)
                {
                    this.TeacherName = (System.String)dr["TeacherName"];
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
            if (dr.Table.Columns.Contains("Price"))
            {
                if (dr["Price"] != DBNull.Value)
                {
                    this.Price = (System.Decimal)dr["Price"];
                }
            }
            if (dr.Table.Columns.Contains("AssignCount"))
            {
                if (dr["AssignCount"] != DBNull.Value)
                {
                    this.AssignCount = (System.Decimal)dr["AssignCount"];
                }
            }
            if (dr.Table.Columns.Contains("AsignType"))
            {
                if (dr["AsignType"] != DBNull.Value)
                {
                    this.AsignType = (System.Byte)dr["AsignType"];
                }
            }
            if (dr.Table.Columns.Contains("AsignStatus"))
            {
                if (dr["AsignStatus"] != DBNull.Value)
                {
                    this.AsignStatus = (System.Byte)dr["AsignStatus"];
                }
            }
            if (dr.Table.Columns.Contains("LastModifiedDate"))
            {
                if (dr["LastModifiedDate"] != DBNull.Value)
                {
                    this.LastModifiedDate = (System.DateTime)dr["LastModifiedDate"];
                }
            }
            if (dr.Table.Columns.Contains("SubjectID"))
            {
                if (dr["SubjectID"] != DBNull.Value)
                {
                    this.SubjectID = (System.Int32)dr["SubjectID"];
                }
            }
            if (dr.Table.Columns.Contains("GradeID"))
            {
                if (dr["GradeID"] != DBNull.Value)
                {
                    this.GradeID = (System.Int32)dr["GradeID"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherPatternID"))
            {
                if (dr["TeacherPatternID"] != DBNull.Value)
                {
                    this.TeacherPatternID = (System.Int32)dr["TeacherPatternID"];
                }
            }
            if (dr.Table.Columns.Contains("PUserID"))
            {
                if (dr["PUserID"] != DBNull.Value)
                {
                    this.PUserID = (System.Int64)dr["PUserID"];
                }
            }
            if (dr.Table.Columns.Contains("PUserPassportID"))
            {
                if (dr["PUserPassportID"] != DBNull.Value)
                {
                    this.PUserPassportID = (System.Int64)dr["PUserPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("ManagerUserName"))
            {
                if (dr["ManagerUserName"] != DBNull.Value)
                {
                    this.ManagerUserName = (System.String)dr["ManagerUserName"];
                }
            }
            if (dr.Table.Columns.Contains("SchoolID"))
            {
                if (dr["SchoolID"] != DBNull.Value)
                {
                    this.SchoolID = (System.Int64)dr["SchoolID"];
                }
            }
            if (dr.Table.Columns.Contains("SchoolName"))
            {
                if (dr["SchoolName"] != DBNull.Value)
                {
                    this.SchoolName = (System.String)dr["SchoolName"];
                }
            }
            if (dr.Table.Columns.Contains("CompanyID"))
            {
                if (dr["CompanyID"] != DBNull.Value)
                {
                    this.CompanyID = (System.Int64)dr["CompanyID"];
                }
            }
            if (dr.Table.Columns.Contains("CompanyName"))
            {
                if (dr["CompanyName"] != DBNull.Value)
                {
                    this.CompanyName = (System.String)dr["CompanyName"];
                }
            }
            if (dr.Table.Columns.Contains("SubjectName"))
            {
                if (dr["SubjectName"] != DBNull.Value)
                {
                    this.SubjectName = (System.String)dr["SubjectName"];
                }
            }
            if (dr.Table.Columns.Contains("GradeName"))
            {
                if (dr["GradeName"] != DBNull.Value)
                {
                    this.GradeName = (System.String)dr["GradeName"];
                }
            }
            if (dr.Table.Columns.Contains("HasAnalyse"))
            {
                if (dr["HasAnalyse"] != DBNull.Value)
                {
                    this.HasAnalyse = (System.Byte)dr["HasAnalyse"];
                }
            }
            if (dr.Table.Columns.Contains("AnalyseTime"))
            {
                if (dr["AnalyseTime"] != DBNull.Value)
                {
                    this.AnalyseTime = (System.DateTime)dr["AnalyseTime"];
                }
            }
            if (dr.Table.Columns.Contains("HostID"))
            {
                if (dr["HostID"] != DBNull.Value)
                {
                    this.HostID = (System.Int64)dr["HostID"];
                }
            }
            if (dr.Table.Columns.Contains("StuendtCode"))
            {
                if (dr["StuendtCode"] != DBNull.Value)
                {
                    this.StuendtCode = (System.String)dr["StuendtCode"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherCode"))
            {
                if (dr["TeacherCode"] != DBNull.Value)
                {
                    this.TeacherCode = (System.String)dr["TeacherCode"];
                }
            }
            if (dr.Table.Columns.Contains("TOrgPath"))
            {
                if (dr["TOrgPath"] != DBNull.Value)
                {
                    this.TOrgPath = (System.String)dr["TOrgPath"];
                }
            }
            if (dr.Table.Columns.Contains("ManagerJobPassPortID"))
            {
                if (dr["ManagerJobPassPortID"] != DBNull.Value)
                {
                    this.ManagerJobPassPortID = (System.Int64)dr["ManagerJobPassPortID"];
                }
            }
            if (dr.Table.Columns.Contains("POrgPath"))
            {
                if (dr["POrgPath"] != DBNull.Value)
                {
                    this.POrgPath = (System.String)dr["POrgPath"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherPatternName"))
            {
                if (dr["TeacherPatternName"] != DBNull.Value)
                {
                    this.TeacherPatternName = (System.String)dr["TeacherPatternName"];
                }
            }
            if (dr.Table.Columns.Contains("PJobPassportID"))
            {
                if (dr["PJobPassportID"] != DBNull.Value)
                {
                    this.PJobPassportID = (System.Int64)dr["PJobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("PUserName"))
            {
                if (dr["PUserName"] != DBNull.Value)
                {
                    this.PUserName = (System.String)dr["PUserName"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherSchoolID"))
            {
                if (dr["TeacherSchoolID"] != DBNull.Value)
                {
                    this.TeacherSchoolID = (System.Int64)dr["TeacherSchoolID"];
                }
            }
            if (dr.Table.Columns.Contains("OAUserID"))
            {
                if (dr["OAUserID"] != DBNull.Value)
                {
                    this.OAUserID = (System.String)dr["OAUserID"];
                }
            }
            if (dr.Table.Columns.Contains("OldSchoolID"))
            {
                if (dr["OldSchoolID"] != DBNull.Value)
                {
                    this.OldSchoolID = (System.Int64)dr["OldSchoolID"];
                }
            }
            if (dr.Table.Columns.Contains("CreateDate"))
            {
                if (dr["CreateDate"] != DBNull.Value)
                {
                    this.CreateDate = (System.DateTime)dr["CreateDate"];
                }
            }
            if (dr.Table.Columns.Contains("TeachHours"))
            {
                if (dr["TeachHours"] != DBNull.Value)
                {
                    this.TeachHours = (System.Decimal)dr["TeachHours"];
                }
            }
            if (dr.Table.Columns.Contains("ConsultatorName"))
            {
                if (dr["ConsultatorName"] != DBNull.Value)
                {
                    this.ConsultatorName = (System.String)dr["ConsultatorName"];
                }
            }
            if (dr.Table.Columns.Contains("ConsultatorUserID"))
            {
                if (dr["ConsultatorUserID"] != DBNull.Value)
                {
                    this.ConsultatorUserID = (System.Int64)dr["ConsultatorUserID"];
                }
            }
            if (dr.Table.Columns.Contains("ConsultatorPassportID"))
            {
                if (dr["ConsultatorPassportID"] != DBNull.Value)
                {
                    this.ConsultatorPassportID = (System.Int64)dr["ConsultatorPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("ConsultatorPassportJobID"))
            {
                if (dr["ConsultatorPassportJobID"] != DBNull.Value)
                {
                    this.ConsultatorPassportJobID = (System.Int64)dr["ConsultatorPassportJobID"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherType"))
            {
                if (dr["TeacherType"] != DBNull.Value)
                {
                    this.TeacherType = (System.Int64)dr["TeacherType"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherTypeName"))
            {
                if (dr["TeacherTypeName"] != DBNull.Value)
                {
                    this.TeacherTypeName = (System.String)dr["TeacherTypeName"];
                }
            }
            if (dr.Table.Columns.Contains("CourseSourceType"))
            {
                if (dr["CourseSourceType"] != DBNull.Value)
                {
                    this.CourseSourceType = (System.Int64)dr["CourseSourceType"];
                }
            }
            if (dr.Table.Columns.Contains("ManagerUserID"))
            {
                if (dr["ManagerUserID"] != DBNull.Value)
                {
                    this.ManagerUserID = (System.Int64)dr["ManagerUserID"];
                }
            }
            if (dr.Table.Columns.Contains("ManagerUserPassportID"))
            {
                if (dr["ManagerUserPassportID"] != DBNull.Value)
                {
                    this.ManagerUserPassportID = (System.Int64)dr["ManagerUserPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("ConsultatorNames"))
            {
                if (dr["ConsultatorNames"] != DBNull.Value)
                {
                    this.ConsultatorNames = (System.String)dr["ConsultatorNames"];
                }
            }
            if (dr.Table.Columns.Contains("CourseType"))
            {
                if (dr["CourseType"] != DBNull.Value)
                {
                    this.CourseType = (System.Int32)dr["CourseType"];
                }
            }
            if (dr.Table.Columns.Contains("MasterProductID"))
            {
                if (dr["MasterProductID"] != DBNull.Value)
                {
                    this.MasterProductID = (System.Int64)dr["MasterProductID"];
                }
            }
            if (dr.Table.Columns.Contains("MasterProductName"))
            {
                if (dr["MasterProductName"] != DBNull.Value)
                {
                    this.MasterProductName = (System.String)dr["MasterProductName"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerType"))
            {
                if (dr["CustomerType"] != DBNull.Value)
                {
                    this.CustomerType = (System.Int32)dr["CustomerType"];
                }
            }
            if (dr.Table.Columns.Contains("ParentAssignID"))
            {
                if (dr["ParentAssignID"] != DBNull.Value)
                {
                    this.ParentAssignID = (System.Int64)dr["ParentAssignID"];
                }
            }
            if (dr.Table.Columns.Contains("AssignConsumeStatus"))
            {
                if (dr["AssignConsumeStatus"] != DBNull.Value)
                {
                    this.AssignConsumeStatus = (System.Byte)dr["AssignConsumeStatus"];
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
            if (dr.Table.Columns.Contains("TeacherSubjectGroupID"))
            {
                if (dr["TeacherSubjectGroupID"] != DBNull.Value)
                {
                    this.TeacherSubjectGroupID = (System.Int64)dr["TeacherSubjectGroupID"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherSubjectGroupName"))
            {
                if (dr["TeacherSubjectGroupName"] != DBNull.Value)
                {
                    this.TeacherSubjectGroupName = (System.String)dr["TeacherSubjectGroupName"];
                }
            }
            if (dr.Table.Columns.Contains("CourseTimeLong"))
            {
                if (dr["CourseTimeLong"] != DBNull.Value)
                {
                    this.CourseTimeLong = (System.Decimal)dr["CourseTimeLong"];
                }
            }
            if (dr.Table.Columns.Contains("ConsumeCountHours"))
            {
                if (dr["ConsumeCountHours"] != DBNull.Value)
                {
                    this.ConsumeCountHours = (System.Decimal)dr["ConsumeCountHours"];
                }
            }
            if (dr.Table.Columns.Contains("FinancialTime"))
            {
                if (dr["FinancialTime"] != DBNull.Value)
                {
                    this.FinancialTime = (System.DateTime)dr["FinancialTime"];
                }
            }
            if (dr.Table.Columns.Contains("CourseConfirmTime"))
            {
                if (dr["CourseConfirmTime"] != DBNull.Value)
                {
                    this.CourseConfirmTime = (System.DateTime)dr["CourseConfirmTime"];
                }
            }
            if (dr.Table.Columns.Contains("CancelType"))
            {
                if (dr["CancelType"] != DBNull.Value)
                {
                    this.CancelType = (System.Byte)dr["CancelType"];
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
            if (dr.Table.Columns.Contains("ContractCode"))
            {
                if (dr["ContractCode"] != DBNull.Value)
                {
                    this.ContractCode = (System.String)dr["ContractCode"];
                }
            }
            if (dr.Table.Columns.Contains("AbnormalReasonType"))
            {
                if (dr["AbnormalReasonType"] != DBNull.Value)
                {
                    this.AbnormalReasonType = (System.Int32)dr["AbnormalReasonType"];
                }
            }
            if (dr.Table.Columns.Contains("TeachingVersion"))
            {
                if (dr["TeachingVersion"] != DBNull.Value)
                {
                    this.TeachingVersion = (System.Int32)dr["TeachingVersion"];
                }
            }
            if (dr.Table.Columns.Contains("CoursePlanCount"))
            {
                if (dr["CoursePlanCount"] != DBNull.Value)
                {
                    this.CoursePlanCount = (System.String)dr["CoursePlanCount"];
                }
            }
            if (dr.Table.Columns.Contains("AllCourseCount"))
            {
                if (dr["AllCourseCount"] != DBNull.Value)
                {
                    this.AllCourseCount = (System.String)dr["AllCourseCount"];
                }
            }
            if (dr.Table.Columns.Contains("CourseTask"))
            {
                if (dr["CourseTask"] != DBNull.Value)
                {
                    this.CourseTask = (System.String)dr["CourseTask"];
                }
            }
            if (dr.Table.Columns.Contains("InstructionalObjectives"))
            {
                if (dr["InstructionalObjectives"] != DBNull.Value)
                {
                    this.InstructionalObjectives = (System.String)dr["InstructionalObjectives"];
                }
            }
            if (dr.Table.Columns.Contains("TeachingFocus"))
            {
                if (dr["TeachingFocus"] != DBNull.Value)
                {
                    this.TeachingFocus = (System.String)dr["TeachingFocus"];
                }
            }
            if (dr.Table.Columns.Contains("TeachingDifficulties"))
            {
                if (dr["TeachingDifficulties"] != DBNull.Value)
                {
                    this.TeachingDifficulties = (System.String)dr["TeachingDifficulties"];
                }
            }
            if (dr.Table.Columns.Contains("PlanStatus"))
            {
                if (dr["PlanStatus"] != DBNull.Value)
                {
                    this.PlanStatus = (System.Int32)dr["PlanStatus"];
                }
            }
            if (dr.Table.Columns.Contains("PlanUserID"))
            {
                if (dr["PlanUserID"] != DBNull.Value)
                {
                    this.PlanUserID = (System.Int64)dr["PlanUserID"];
                }
            }
            if (dr.Table.Columns.Contains("PlanUserPassportID"))
            {
                if (dr["PlanUserPassportID"] != DBNull.Value)
                {
                    this.PlanUserPassportID = (System.Int64)dr["PlanUserPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("PlanUserName"))
            {
                if (dr["PlanUserName"] != DBNull.Value)
                {
                    this.PlanUserName = (System.String)dr["PlanUserName"];
                }
            }
            if (dr.Table.Columns.Contains("PlanJobPassportID"))
            {
                if (dr["PlanJobPassportID"] != DBNull.Value)
                {
                    this.PlanJobPassportID = (System.Int64)dr["PlanJobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("PlanCreateTime"))
            {
                if (dr["PlanCreateTime"] != DBNull.Value)
                {
                    this.PlanCreateTime = (System.DateTime)dr["PlanCreateTime"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherActivity"))
            {
                if (dr["TeacherActivity"] != DBNull.Value)
                {
                    this.TeacherActivity = (System.String)dr["TeacherActivity"];
                }
            }
            if (dr.Table.Columns.Contains("StudentActivity"))
            {
                if (dr["StudentActivity"] != DBNull.Value)
                {
                    this.StudentActivity = (System.String)dr["StudentActivity"];
                }
            }
            if (dr.Table.Columns.Contains("ConformStatus"))
            {
                if (dr["ConformStatus"] != DBNull.Value)
                {
                    this.ConformStatus = (System.Int32)dr["ConformStatus"];
                }
            }
            if (dr.Table.Columns.Contains("ClassTime"))
            {
                if (dr["ClassTime"] != DBNull.Value)
                {
                    this.ClassTime = (System.Int64)dr["ClassTime"];
                }
            }
            if (dr.Table.Columns.Contains("ConfirmPersonStyle"))
            {
                if (dr["ConfirmPersonStyle"] != DBNull.Value)
                {
                    this.ConfirmPersonStyle = (System.Int32)dr["ConfirmPersonStyle"];
                }
            }
            if (dr.Table.Columns.Contains("ConfirmSource"))
            {
                if (dr["ConfirmSource"] != DBNull.Value)
                {
                    this.ConfirmSource = (System.Int32)dr["ConfirmSource"];
                }
            }
            if (dr.Table.Columns.Contains("LastModified"))
            {
                if (dr["LastModified"] != DBNull.Value)
                {
                    this.LastModified = (System.Byte[])dr["LastModified"];
                }
            }
            if (dr.Table.Columns.Contains("LastModifyDate"))
            {
                if (dr["LastModifyDate"] != DBNull.Value)
                {
                    this.LastModifyDate = (System.DateTime)dr["LastModifyDate"];
                }
            }
        }
    }
}