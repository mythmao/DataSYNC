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
    public static partial class AssignCourseBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudCourse");


        public static List<AssignCourse> Search(string sqlStr, params SqlParameter[] parameters)
        {
            List<AssignCourse> list = new List<AssignCourse>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        AssignCourse model = new AssignCourse(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(AssignCourse model)
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



            if (model.AsignCourseID != null)
            {
                fileds.Add("[AsignCourseID]");
                pFileds.Add("@AsignCourseID");
                pms.Add(new SqlParameter("AsignCourseID", model.AsignCourseID));
            }


            if (model.EventID != null)
            {
                fileds.Add("[EventID]");
                pFileds.Add("@EventID");
                pms.Add(new SqlParameter("EventID", model.EventID));
            }


            if (model.StudentUserID != null)
            {
                fileds.Add("[StudentUserID]");
                pFileds.Add("@StudentUserID");
                pms.Add(new SqlParameter("StudentUserID", model.StudentUserID));
            }


            if (model.StudentPassportID != null)
            {
                fileds.Add("[StudentPassportID]");
                pFileds.Add("@StudentPassportID");
                pms.Add(new SqlParameter("StudentPassportID", model.StudentPassportID));
            }


            if (model.StudentName != null)
            {
                fileds.Add("[StudentName]");
                pFileds.Add("@StudentName");
                pms.Add(new SqlParameter("StudentName", model.StudentName));
            }


            if (model.TeacherUserID != null)
            {
                fileds.Add("[TeacherUserID]");
                pFileds.Add("@TeacherUserID");
                pms.Add(new SqlParameter("TeacherUserID", model.TeacherUserID));
            }


            if (model.TeacherPassportID != null)
            {
                fileds.Add("[TeacherPassportID]");
                pFileds.Add("@TeacherPassportID");
                pms.Add(new SqlParameter("TeacherPassportID", model.TeacherPassportID));
            }


            if (model.TeacherJobID != null)
            {
                fileds.Add("[TeacherJobID]");
                pFileds.Add("@TeacherJobID");
                pms.Add(new SqlParameter("TeacherJobID", model.TeacherJobID));
            }


            if (model.TeacherJobPassportID != null)
            {
                fileds.Add("[TeacherJobPassportID]");
                pFileds.Add("@TeacherJobPassportID");
                pms.Add(new SqlParameter("TeacherJobPassportID", model.TeacherJobPassportID));
            }


            if (model.TeacherName != null)
            {
                fileds.Add("[TeacherName]");
                pFileds.Add("@TeacherName");
                pms.Add(new SqlParameter("TeacherName", model.TeacherName));
            }


            if (model.ProductID != null)
            {
                fileds.Add("[ProductID]");
                pFileds.Add("@ProductID");
                pms.Add(new SqlParameter("ProductID", model.ProductID));
            }


            if (model.ProductName != null)
            {
                fileds.Add("[ProductName]");
                pFileds.Add("@ProductName");
                pms.Add(new SqlParameter("ProductName", model.ProductName));
            }


            if (model.StartTime != null && model.StartTime != new DateTime())
            {
                fileds.Add("[StartTime]");
                pFileds.Add("@StartTime");
                pms.Add(new SqlParameter("StartTime", model.StartTime));
            }


            if (model.EndTime != null && model.EndTime != new DateTime())
            {
                fileds.Add("[EndTime]");
                pFileds.Add("@EndTime");
                pms.Add(new SqlParameter("EndTime", model.EndTime));
            }


            if (model.Price != null)
            {
                fileds.Add("[Price]");
                pFileds.Add("@Price");
                pms.Add(new SqlParameter("Price", model.Price));
            }


            if (model.AssignCount != null)
            {
                fileds.Add("[AssignCount]");
                pFileds.Add("@AssignCount");
                pms.Add(new SqlParameter("AssignCount", model.AssignCount));
            }


            if (model.AsignType != null)
            {
                fileds.Add("[AsignType]");
                pFileds.Add("@AsignType");
                pms.Add(new SqlParameter("AsignType", model.AsignType));
            }


            if (model.AsignStatus != null)
            {
                fileds.Add("[AsignStatus]");
                pFileds.Add("@AsignStatus");
                pms.Add(new SqlParameter("AsignStatus", model.AsignStatus));
            }


            if (model.LastModifiedDate != null && model.LastModifiedDate != new DateTime())
            {
                fileds.Add("[LastModifiedDate]");
                pFileds.Add("@LastModifiedDate");
                pms.Add(new SqlParameter("LastModifiedDate", model.LastModifiedDate));
            }


            if (model.SubjectID != null)
            {
                fileds.Add("[SubjectID]");
                pFileds.Add("@SubjectID");
                pms.Add(new SqlParameter("SubjectID", model.SubjectID));
            }


            if (model.GradeID != null)
            {
                fileds.Add("[GradeID]");
                pFileds.Add("@GradeID");
                pms.Add(new SqlParameter("GradeID", model.GradeID));
            }


            if (model.TeacherPatternID != null)
            {
                fileds.Add("[TeacherPatternID]");
                pFileds.Add("@TeacherPatternID");
                pms.Add(new SqlParameter("TeacherPatternID", model.TeacherPatternID));
            }


            if (model.PUserID != null)
            {
                fileds.Add("[PUserID]");
                pFileds.Add("@PUserID");
                pms.Add(new SqlParameter("PUserID", model.PUserID));
            }


            if (model.PUserPassportID != null)
            {
                fileds.Add("[PUserPassportID]");
                pFileds.Add("@PUserPassportID");
                pms.Add(new SqlParameter("PUserPassportID", model.PUserPassportID));
            }


            if (model.ManagerUserName != null)
            {
                fileds.Add("[ManagerUserName]");
                pFileds.Add("@ManagerUserName");
                pms.Add(new SqlParameter("ManagerUserName", model.ManagerUserName));
            }


            if (model.SchoolID != null)
            {
                fileds.Add("[SchoolID]");
                pFileds.Add("@SchoolID");
                pms.Add(new SqlParameter("SchoolID", model.SchoolID));
            }


            if (model.SchoolName != null)
            {
                fileds.Add("[SchoolName]");
                pFileds.Add("@SchoolName");
                pms.Add(new SqlParameter("SchoolName", model.SchoolName));
            }


            if (model.CompanyID != null)
            {
                fileds.Add("[CompanyID]");
                pFileds.Add("@CompanyID");
                pms.Add(new SqlParameter("CompanyID", model.CompanyID));
            }


            if (model.CompanyName != null)
            {
                fileds.Add("[CompanyName]");
                pFileds.Add("@CompanyName");
                pms.Add(new SqlParameter("CompanyName", model.CompanyName));
            }


            if (model.SubjectName != null)
            {
                fileds.Add("[SubjectName]");
                pFileds.Add("@SubjectName");
                pms.Add(new SqlParameter("SubjectName", model.SubjectName));
            }


            if (model.GradeName != null)
            {
                fileds.Add("[GradeName]");
                pFileds.Add("@GradeName");
                pms.Add(new SqlParameter("GradeName", model.GradeName));
            }


            if (model.HasAnalyse != null)
            {
                fileds.Add("[HasAnalyse]");
                pFileds.Add("@HasAnalyse");
                pms.Add(new SqlParameter("HasAnalyse", model.HasAnalyse));
            }


            if (model.AnalyseTime != null && model.AnalyseTime != new DateTime())
            {
                fileds.Add("[AnalyseTime]");
                pFileds.Add("@AnalyseTime");
                pms.Add(new SqlParameter("AnalyseTime", model.AnalyseTime));
            }


            if (model.HostID != null)
            {
                fileds.Add("[HostID]");
                pFileds.Add("@HostID");
                pms.Add(new SqlParameter("HostID", model.HostID));
            }


            if (model.StuendtCode != null)
            {
                fileds.Add("[StuendtCode]");
                pFileds.Add("@StuendtCode");
                pms.Add(new SqlParameter("StuendtCode", model.StuendtCode));
            }


            if (model.TeacherCode != null)
            {
                fileds.Add("[TeacherCode]");
                pFileds.Add("@TeacherCode");
                pms.Add(new SqlParameter("TeacherCode", model.TeacherCode));
            }


            if (model.TOrgPath != null)
            {
                fileds.Add("[TOrgPath]");
                pFileds.Add("@TOrgPath");
                pms.Add(new SqlParameter("TOrgPath", model.TOrgPath));
            }


            if (model.ManagerJobPassPortID != null)
            {
                fileds.Add("[ManagerJobPassPortID]");
                pFileds.Add("@ManagerJobPassPortID");
                pms.Add(new SqlParameter("ManagerJobPassPortID", model.ManagerJobPassPortID));
            }


            if (model.POrgPath != null)
            {
                fileds.Add("[POrgPath]");
                pFileds.Add("@POrgPath");
                pms.Add(new SqlParameter("POrgPath", model.POrgPath));
            }


            if (model.TeacherPatternName != null)
            {
                fileds.Add("[TeacherPatternName]");
                pFileds.Add("@TeacherPatternName");
                pms.Add(new SqlParameter("TeacherPatternName", model.TeacherPatternName));
            }


            if (model.PJobPassportID != null)
            {
                fileds.Add("[PJobPassportID]");
                pFileds.Add("@PJobPassportID");
                pms.Add(new SqlParameter("PJobPassportID", model.PJobPassportID));
            }


            if (model.PUserName != null)
            {
                fileds.Add("[PUserName]");
                pFileds.Add("@PUserName");
                pms.Add(new SqlParameter("PUserName", model.PUserName));
            }


            if (model.TeacherSchoolID != null)
            {
                fileds.Add("[TeacherSchoolID]");
                pFileds.Add("@TeacherSchoolID");
                pms.Add(new SqlParameter("TeacherSchoolID", model.TeacherSchoolID));
            }


            if (model.OAUserID != null)
            {
                fileds.Add("[OAUserID]");
                pFileds.Add("@OAUserID");
                pms.Add(new SqlParameter("OAUserID", model.OAUserID));
            }


            if (model.OldSchoolID != null)
            {
                fileds.Add("[OldSchoolID]");
                pFileds.Add("@OldSchoolID");
                pms.Add(new SqlParameter("OldSchoolID", model.OldSchoolID));
            }


            if (model.CreateDate != null && model.CreateDate != new DateTime())
            {
                fileds.Add("[CreateDate]");
                pFileds.Add("@CreateDate");
                pms.Add(new SqlParameter("CreateDate", model.CreateDate));
            }


            if (model.TeachHours != null)
            {
                fileds.Add("[TeachHours]");
                pFileds.Add("@TeachHours");
                pms.Add(new SqlParameter("TeachHours", model.TeachHours));
            }


            if (model.ConsultatorName != null)
            {
                fileds.Add("[ConsultatorName]");
                pFileds.Add("@ConsultatorName");
                pms.Add(new SqlParameter("ConsultatorName", model.ConsultatorName));
            }


            if (model.ConsultatorUserID != null)
            {
                fileds.Add("[ConsultatorUserID]");
                pFileds.Add("@ConsultatorUserID");
                pms.Add(new SqlParameter("ConsultatorUserID", model.ConsultatorUserID));
            }


            if (model.ConsultatorPassportID != null)
            {
                fileds.Add("[ConsultatorPassportID]");
                pFileds.Add("@ConsultatorPassportID");
                pms.Add(new SqlParameter("ConsultatorPassportID", model.ConsultatorPassportID));
            }


            if (model.ConsultatorPassportJobID != null)
            {
                fileds.Add("[ConsultatorPassportJobID]");
                pFileds.Add("@ConsultatorPassportJobID");
                pms.Add(new SqlParameter("ConsultatorPassportJobID", model.ConsultatorPassportJobID));
            }


            if (model.TeacherType != null)
            {
                fileds.Add("[TeacherType]");
                pFileds.Add("@TeacherType");
                pms.Add(new SqlParameter("TeacherType", model.TeacherType));
            }


            if (model.TeacherTypeName != null)
            {
                fileds.Add("[TeacherTypeName]");
                pFileds.Add("@TeacherTypeName");
                pms.Add(new SqlParameter("TeacherTypeName", model.TeacherTypeName));
            }


            if (model.CourseSourceType != null)
            {
                fileds.Add("[CourseSourceType]");
                pFileds.Add("@CourseSourceType");
                pms.Add(new SqlParameter("CourseSourceType", model.CourseSourceType));
            }


            if (model.ManagerUserID != null)
            {
                fileds.Add("[ManagerUserID]");
                pFileds.Add("@ManagerUserID");
                pms.Add(new SqlParameter("ManagerUserID", model.ManagerUserID));
            }


            if (model.ManagerUserPassportID != null)
            {
                fileds.Add("[ManagerUserPassportID]");
                pFileds.Add("@ManagerUserPassportID");
                pms.Add(new SqlParameter("ManagerUserPassportID", model.ManagerUserPassportID));
            }


            if (model.ConsultatorNames != null)
            {
                fileds.Add("[ConsultatorNames]");
                pFileds.Add("@ConsultatorNames");
                pms.Add(new SqlParameter("ConsultatorNames", model.ConsultatorNames));
            }


            if (model.CourseType != null)
            {
                fileds.Add("[CourseType]");
                pFileds.Add("@CourseType");
                pms.Add(new SqlParameter("CourseType", model.CourseType));
            }


            if (model.MasterProductID != null)
            {
                fileds.Add("[MasterProductID]");
                pFileds.Add("@MasterProductID");
                pms.Add(new SqlParameter("MasterProductID", model.MasterProductID));
            }


            if (model.MasterProductName != null)
            {
                fileds.Add("[MasterProductName]");
                pFileds.Add("@MasterProductName");
                pms.Add(new SqlParameter("MasterProductName", model.MasterProductName));
            }


            if (model.CustomerType != null)
            {
                fileds.Add("[CustomerType]");
                pFileds.Add("@CustomerType");
                pms.Add(new SqlParameter("CustomerType", model.CustomerType));
            }


            if (model.ParentAssignID != null)
            {
                fileds.Add("[ParentAssignID]");
                pFileds.Add("@ParentAssignID");
                pms.Add(new SqlParameter("ParentAssignID", model.ParentAssignID));
            }


            if (model.AssignConsumeStatus != null)
            {
                fileds.Add("[AssignConsumeStatus]");
                pFileds.Add("@AssignConsumeStatus");
                pms.Add(new SqlParameter("AssignConsumeStatus", model.AssignConsumeStatus));
            }


            if (model.SubjectGroupID != null)
            {
                fileds.Add("[SubjectGroupID]");
                pFileds.Add("@SubjectGroupID");
                pms.Add(new SqlParameter("SubjectGroupID", model.SubjectGroupID));
            }


            if (model.SubjectGroupName != null)
            {
                fileds.Add("[SubjectGroupName]");
                pFileds.Add("@SubjectGroupName");
                pms.Add(new SqlParameter("SubjectGroupName", model.SubjectGroupName));
            }


            if (model.TeacherSubjectGroupID != null)
            {
                fileds.Add("[TeacherSubjectGroupID]");
                pFileds.Add("@TeacherSubjectGroupID");
                pms.Add(new SqlParameter("TeacherSubjectGroupID", model.TeacherSubjectGroupID));
            }


            if (model.TeacherSubjectGroupName != null)
            {
                fileds.Add("[TeacherSubjectGroupName]");
                pFileds.Add("@TeacherSubjectGroupName");
                pms.Add(new SqlParameter("TeacherSubjectGroupName", model.TeacherSubjectGroupName));
            }


            if (model.CourseTimeLong != null)
            {
                fileds.Add("[CourseTimeLong]");
                pFileds.Add("@CourseTimeLong");
                pms.Add(new SqlParameter("CourseTimeLong", model.CourseTimeLong));
            }


            if (model.ConsumeCountHours != null)
            {
                fileds.Add("[ConsumeCountHours]");
                pFileds.Add("@ConsumeCountHours");
                pms.Add(new SqlParameter("ConsumeCountHours", model.ConsumeCountHours));
            }


            if (model.FinancialTime != null && model.FinancialTime != new DateTime())
            {
                fileds.Add("[FinancialTime]");
                pFileds.Add("@FinancialTime");
                pms.Add(new SqlParameter("FinancialTime", model.FinancialTime));
            }


            if (model.CourseConfirmTime != null && model.CourseConfirmTime != new DateTime())
            {
                fileds.Add("[CourseConfirmTime]");
                pFileds.Add("@CourseConfirmTime");
                pms.Add(new SqlParameter("CourseConfirmTime", model.CourseConfirmTime));
            }


            if (model.CancelType != null)
            {
                fileds.Add("[CancelType]");
                pFileds.Add("@CancelType");
                pms.Add(new SqlParameter("CancelType", model.CancelType));
            }


            if (model.TeachingSchoolID != null)
            {
                fileds.Add("[TeachingSchoolID]");
                pFileds.Add("@TeachingSchoolID");
                pms.Add(new SqlParameter("TeachingSchoolID", model.TeachingSchoolID));
            }


            if (model.TeachingSchoolName != null)
            {
                fileds.Add("[TeachingSchoolName]");
                pFileds.Add("@TeachingSchoolName");
                pms.Add(new SqlParameter("TeachingSchoolName", model.TeachingSchoolName));
            }


            if (model.ContractCode != null)
            {
                fileds.Add("[ContractCode]");
                pFileds.Add("@ContractCode");
                pms.Add(new SqlParameter("ContractCode", model.ContractCode));
            }


            if (model.AbnormalReasonType != null)
            {
                fileds.Add("[AbnormalReasonType]");
                pFileds.Add("@AbnormalReasonType");
                pms.Add(new SqlParameter("AbnormalReasonType", model.AbnormalReasonType));
            }


            if (model.TeachingVersion != null)
            {
                fileds.Add("[TeachingVersion]");
                pFileds.Add("@TeachingVersion");
                pms.Add(new SqlParameter("TeachingVersion", model.TeachingVersion));
            }


            if (model.CoursePlanCount != null)
            {
                fileds.Add("[CoursePlanCount]");
                pFileds.Add("@CoursePlanCount");
                pms.Add(new SqlParameter("CoursePlanCount", model.CoursePlanCount));
            }


            if (model.AllCourseCount != null)
            {
                fileds.Add("[AllCourseCount]");
                pFileds.Add("@AllCourseCount");
                pms.Add(new SqlParameter("AllCourseCount", model.AllCourseCount));
            }


            if (model.CourseTask != null)
            {
                fileds.Add("[CourseTask]");
                pFileds.Add("@CourseTask");
                pms.Add(new SqlParameter("CourseTask", model.CourseTask));
            }


            if (model.InstructionalObjectives != null)
            {
                fileds.Add("[InstructionalObjectives]");
                pFileds.Add("@InstructionalObjectives");
                pms.Add(new SqlParameter("InstructionalObjectives", model.InstructionalObjectives));
            }


            if (model.TeachingFocus != null)
            {
                fileds.Add("[TeachingFocus]");
                pFileds.Add("@TeachingFocus");
                pms.Add(new SqlParameter("TeachingFocus", model.TeachingFocus));
            }


            if (model.TeachingDifficulties != null)
            {
                fileds.Add("[TeachingDifficulties]");
                pFileds.Add("@TeachingDifficulties");
                pms.Add(new SqlParameter("TeachingDifficulties", model.TeachingDifficulties));
            }


            if (model.PlanStatus != null)
            {
                fileds.Add("[PlanStatus]");
                pFileds.Add("@PlanStatus");
                pms.Add(new SqlParameter("PlanStatus", model.PlanStatus));
            }


            if (model.PlanUserID != null)
            {
                fileds.Add("[PlanUserID]");
                pFileds.Add("@PlanUserID");
                pms.Add(new SqlParameter("PlanUserID", model.PlanUserID));
            }


            if (model.PlanUserPassportID != null)
            {
                fileds.Add("[PlanUserPassportID]");
                pFileds.Add("@PlanUserPassportID");
                pms.Add(new SqlParameter("PlanUserPassportID", model.PlanUserPassportID));
            }


            if (model.PlanUserName != null)
            {
                fileds.Add("[PlanUserName]");
                pFileds.Add("@PlanUserName");
                pms.Add(new SqlParameter("PlanUserName", model.PlanUserName));
            }


            if (model.PlanJobPassportID != null)
            {
                fileds.Add("[PlanJobPassportID]");
                pFileds.Add("@PlanJobPassportID");
                pms.Add(new SqlParameter("PlanJobPassportID", model.PlanJobPassportID));
            }


            if (model.PlanCreateTime != null && model.PlanCreateTime != new DateTime())
            {
                fileds.Add("[PlanCreateTime]");
                pFileds.Add("@PlanCreateTime");
                pms.Add(new SqlParameter("PlanCreateTime", model.PlanCreateTime));
            }


            if (model.TeacherActivity != null)
            {
                fileds.Add("[TeacherActivity]");
                pFileds.Add("@TeacherActivity");
                pms.Add(new SqlParameter("TeacherActivity", model.TeacherActivity));
            }


            if (model.StudentActivity != null)
            {
                fileds.Add("[StudentActivity]");
                pFileds.Add("@StudentActivity");
                pms.Add(new SqlParameter("StudentActivity", model.StudentActivity));
            }


            if (model.ConformStatus != null)
            {
                fileds.Add("[ConformStatus]");
                pFileds.Add("@ConformStatus");
                pms.Add(new SqlParameter("ConformStatus", model.ConformStatus));
            }


            if (model.ClassTime != null)
            {
                fileds.Add("[ClassTime]");
                pFileds.Add("@ClassTime");
                pms.Add(new SqlParameter("ClassTime", model.ClassTime));
            }


            if (model.ConfirmPersonStyle != null)
            {
                fileds.Add("[ConfirmPersonStyle]");
                pFileds.Add("@ConfirmPersonStyle");
                pms.Add(new SqlParameter("ConfirmPersonStyle", model.ConfirmPersonStyle));
            }


            if (model.ConfirmSource != null)
            {
                fileds.Add("[ConfirmSource]");
                pFileds.Add("@ConfirmSource");
                pms.Add(new SqlParameter("ConfirmSource", model.ConfirmSource));
            }


            if (model.LastModified != null)
            {
                fileds.Add("[LastModified]");
                pFileds.Add("@LastModified");
                pms.Add(new SqlParameter("LastModified", model.LastModified));
            }


            if (model.LastModifyDate != null && model.LastModifyDate != new DateTime())
            {
                fileds.Add("[LastModifyDate]");
                pFileds.Add("@LastModifyDate");
                pms.Add(new SqlParameter("LastModifyDate", model.LastModifyDate));
            }

            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO AssignCourse (");
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

        public static bool Update(AssignCourse model)
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
            pFileds.Add("[AssignID]=@AssignID");
            pms.Add(new SqlParameter("AssignID", model.AssignID));

            if (model.AsignCourseID != null)
            {
                fileds.Add("[AsignCourseID]=@AsignCourseID");
                pms.Add(new SqlParameter("AsignCourseID", model.AsignCourseID));
            }

            if (model.EventID != null)
            {
                fileds.Add("[EventID]=@EventID");
                pms.Add(new SqlParameter("EventID", model.EventID));
            }

            if (model.StudentUserID != null)
            {
                fileds.Add("[StudentUserID]=@StudentUserID");
                pms.Add(new SqlParameter("StudentUserID", model.StudentUserID));
            }

            if (model.StudentPassportID != null)
            {
                fileds.Add("[StudentPassportID]=@StudentPassportID");
                pms.Add(new SqlParameter("StudentPassportID", model.StudentPassportID));
            }

            if (model.StudentName != null)
            {
                fileds.Add("[StudentName]=@StudentName");
                pms.Add(new SqlParameter("StudentName", model.StudentName));
            }

            if (model.TeacherUserID != null)
            {
                fileds.Add("[TeacherUserID]=@TeacherUserID");
                pms.Add(new SqlParameter("TeacherUserID", model.TeacherUserID));
            }

            if (model.TeacherPassportID != null)
            {
                fileds.Add("[TeacherPassportID]=@TeacherPassportID");
                pms.Add(new SqlParameter("TeacherPassportID", model.TeacherPassportID));
            }

            if (model.TeacherJobID != null)
            {
                fileds.Add("[TeacherJobID]=@TeacherJobID");
                pms.Add(new SqlParameter("TeacherJobID", model.TeacherJobID));
            }

            if (model.TeacherJobPassportID != null)
            {
                fileds.Add("[TeacherJobPassportID]=@TeacherJobPassportID");
                pms.Add(new SqlParameter("TeacherJobPassportID", model.TeacherJobPassportID));
            }

            if (model.TeacherName != null)
            {
                fileds.Add("[TeacherName]=@TeacherName");
                pms.Add(new SqlParameter("TeacherName", model.TeacherName));
            }

            if (model.ProductID != null)
            {
                fileds.Add("[ProductID]=@ProductID");
                pms.Add(new SqlParameter("ProductID", model.ProductID));
            }

            if (model.ProductName != null)
            {
                fileds.Add("[ProductName]=@ProductName");
                pms.Add(new SqlParameter("ProductName", model.ProductName));
            }

            if (model.StartTime != null && model.StartTime != new DateTime())
            {
                fileds.Add("[StartTime]=@StartTime");
                pms.Add(new SqlParameter("StartTime", model.StartTime));
            }

            if (model.EndTime != null && model.EndTime != new DateTime())
            {
                fileds.Add("[EndTime]=@EndTime");
                pms.Add(new SqlParameter("EndTime", model.EndTime));
            }

            if (model.Price != null)
            {
                fileds.Add("[Price]=@Price");
                pms.Add(new SqlParameter("Price", model.Price));
            }

            if (model.AssignCount != null)
            {
                fileds.Add("[AssignCount]=@AssignCount");
                pms.Add(new SqlParameter("AssignCount", model.AssignCount));
            }

            if (model.AsignType != null)
            {
                fileds.Add("[AsignType]=@AsignType");
                pms.Add(new SqlParameter("AsignType", model.AsignType));
            }

            if (model.AsignStatus != null)
            {
                fileds.Add("[AsignStatus]=@AsignStatus");
                pms.Add(new SqlParameter("AsignStatus", model.AsignStatus));
            }

            if (model.LastModifiedDate != null && model.LastModifiedDate != new DateTime())
            {
                fileds.Add("[LastModifiedDate]=@LastModifiedDate");
                pms.Add(new SqlParameter("LastModifiedDate", model.LastModifiedDate));
            }

            if (model.SubjectID != null)
            {
                fileds.Add("[SubjectID]=@SubjectID");
                pms.Add(new SqlParameter("SubjectID", model.SubjectID));
            }

            if (model.GradeID != null)
            {
                fileds.Add("[GradeID]=@GradeID");
                pms.Add(new SqlParameter("GradeID", model.GradeID));
            }

            if (model.TeacherPatternID != null)
            {
                fileds.Add("[TeacherPatternID]=@TeacherPatternID");
                pms.Add(new SqlParameter("TeacherPatternID", model.TeacherPatternID));
            }

            if (model.PUserID != null)
            {
                fileds.Add("[PUserID]=@PUserID");
                pms.Add(new SqlParameter("PUserID", model.PUserID));
            }

            if (model.PUserPassportID != null)
            {
                fileds.Add("[PUserPassportID]=@PUserPassportID");
                pms.Add(new SqlParameter("PUserPassportID", model.PUserPassportID));
            }

            if (model.ManagerUserName != null)
            {
                fileds.Add("[ManagerUserName]=@ManagerUserName");
                pms.Add(new SqlParameter("ManagerUserName", model.ManagerUserName));
            }

            if (model.SchoolID != null)
            {
                fileds.Add("[SchoolID]=@SchoolID");
                pms.Add(new SqlParameter("SchoolID", model.SchoolID));
            }

            if (model.SchoolName != null)
            {
                fileds.Add("[SchoolName]=@SchoolName");
                pms.Add(new SqlParameter("SchoolName", model.SchoolName));
            }

            if (model.CompanyID != null)
            {
                fileds.Add("[CompanyID]=@CompanyID");
                pms.Add(new SqlParameter("CompanyID", model.CompanyID));
            }

            if (model.CompanyName != null)
            {
                fileds.Add("[CompanyName]=@CompanyName");
                pms.Add(new SqlParameter("CompanyName", model.CompanyName));
            }

            if (model.SubjectName != null)
            {
                fileds.Add("[SubjectName]=@SubjectName");
                pms.Add(new SqlParameter("SubjectName", model.SubjectName));
            }

            if (model.GradeName != null)
            {
                fileds.Add("[GradeName]=@GradeName");
                pms.Add(new SqlParameter("GradeName", model.GradeName));
            }

            if (model.HasAnalyse != null)
            {
                fileds.Add("[HasAnalyse]=@HasAnalyse");
                pms.Add(new SqlParameter("HasAnalyse", model.HasAnalyse));
            }

            if (model.AnalyseTime != null && model.AnalyseTime != new DateTime())
            {
                fileds.Add("[AnalyseTime]=@AnalyseTime");
                pms.Add(new SqlParameter("AnalyseTime", model.AnalyseTime));
            }

            if (model.HostID != null)
            {
                fileds.Add("[HostID]=@HostID");
                pms.Add(new SqlParameter("HostID", model.HostID));
            }

            if (model.StuendtCode != null)
            {
                fileds.Add("[StuendtCode]=@StuendtCode");
                pms.Add(new SqlParameter("StuendtCode", model.StuendtCode));
            }

            if (model.TeacherCode != null)
            {
                fileds.Add("[TeacherCode]=@TeacherCode");
                pms.Add(new SqlParameter("TeacherCode", model.TeacherCode));
            }

            if (model.TOrgPath != null)
            {
                fileds.Add("[TOrgPath]=@TOrgPath");
                pms.Add(new SqlParameter("TOrgPath", model.TOrgPath));
            }

            if (model.ManagerJobPassPortID != null)
            {
                fileds.Add("[ManagerJobPassPortID]=@ManagerJobPassPortID");
                pms.Add(new SqlParameter("ManagerJobPassPortID", model.ManagerJobPassPortID));
            }

            if (model.POrgPath != null)
            {
                fileds.Add("[POrgPath]=@POrgPath");
                pms.Add(new SqlParameter("POrgPath", model.POrgPath));
            }

            if (model.TeacherPatternName != null)
            {
                fileds.Add("[TeacherPatternName]=@TeacherPatternName");
                pms.Add(new SqlParameter("TeacherPatternName", model.TeacherPatternName));
            }

            if (model.PJobPassportID != null)
            {
                fileds.Add("[PJobPassportID]=@PJobPassportID");
                pms.Add(new SqlParameter("PJobPassportID", model.PJobPassportID));
            }

            if (model.PUserName != null)
            {
                fileds.Add("[PUserName]=@PUserName");
                pms.Add(new SqlParameter("PUserName", model.PUserName));
            }

            if (model.TeacherSchoolID != null)
            {
                fileds.Add("[TeacherSchoolID]=@TeacherSchoolID");
                pms.Add(new SqlParameter("TeacherSchoolID", model.TeacherSchoolID));
            }

            if (model.OAUserID != null)
            {
                fileds.Add("[OAUserID]=@OAUserID");
                pms.Add(new SqlParameter("OAUserID", model.OAUserID));
            }

            if (model.OldSchoolID != null)
            {
                fileds.Add("[OldSchoolID]=@OldSchoolID");
                pms.Add(new SqlParameter("OldSchoolID", model.OldSchoolID));
            }

            if (model.CreateDate != null && model.CreateDate != new DateTime())
            {
                fileds.Add("[CreateDate]=@CreateDate");
                pms.Add(new SqlParameter("CreateDate", model.CreateDate));
            }

            if (model.TeachHours != null)
            {
                fileds.Add("[TeachHours]=@TeachHours");
                pms.Add(new SqlParameter("TeachHours", model.TeachHours));
            }

            if (model.ConsultatorName != null)
            {
                fileds.Add("[ConsultatorName]=@ConsultatorName");
                pms.Add(new SqlParameter("ConsultatorName", model.ConsultatorName));
            }

            if (model.ConsultatorUserID != null)
            {
                fileds.Add("[ConsultatorUserID]=@ConsultatorUserID");
                pms.Add(new SqlParameter("ConsultatorUserID", model.ConsultatorUserID));
            }

            if (model.ConsultatorPassportID != null)
            {
                fileds.Add("[ConsultatorPassportID]=@ConsultatorPassportID");
                pms.Add(new SqlParameter("ConsultatorPassportID", model.ConsultatorPassportID));
            }

            if (model.ConsultatorPassportJobID != null)
            {
                fileds.Add("[ConsultatorPassportJobID]=@ConsultatorPassportJobID");
                pms.Add(new SqlParameter("ConsultatorPassportJobID", model.ConsultatorPassportJobID));
            }

            if (model.TeacherType != null)
            {
                fileds.Add("[TeacherType]=@TeacherType");
                pms.Add(new SqlParameter("TeacherType", model.TeacherType));
            }

            if (model.TeacherTypeName != null)
            {
                fileds.Add("[TeacherTypeName]=@TeacherTypeName");
                pms.Add(new SqlParameter("TeacherTypeName", model.TeacherTypeName));
            }

            if (model.CourseSourceType != null)
            {
                fileds.Add("[CourseSourceType]=@CourseSourceType");
                pms.Add(new SqlParameter("CourseSourceType", model.CourseSourceType));
            }

            if (model.ManagerUserID != null)
            {
                fileds.Add("[ManagerUserID]=@ManagerUserID");
                pms.Add(new SqlParameter("ManagerUserID", model.ManagerUserID));
            }

            if (model.ManagerUserPassportID != null)
            {
                fileds.Add("[ManagerUserPassportID]=@ManagerUserPassportID");
                pms.Add(new SqlParameter("ManagerUserPassportID", model.ManagerUserPassportID));
            }

            if (model.ConsultatorNames != null)
            {
                fileds.Add("[ConsultatorNames]=@ConsultatorNames");
                pms.Add(new SqlParameter("ConsultatorNames", model.ConsultatorNames));
            }

            if (model.CourseType != null)
            {
                fileds.Add("[CourseType]=@CourseType");
                pms.Add(new SqlParameter("CourseType", model.CourseType));
            }

            if (model.MasterProductID != null)
            {
                fileds.Add("[MasterProductID]=@MasterProductID");
                pms.Add(new SqlParameter("MasterProductID", model.MasterProductID));
            }

            if (model.MasterProductName != null)
            {
                fileds.Add("[MasterProductName]=@MasterProductName");
                pms.Add(new SqlParameter("MasterProductName", model.MasterProductName));
            }

            if (model.CustomerType != null)
            {
                fileds.Add("[CustomerType]=@CustomerType");
                pms.Add(new SqlParameter("CustomerType", model.CustomerType));
            }

            if (model.ParentAssignID != null)
            {
                fileds.Add("[ParentAssignID]=@ParentAssignID");
                pms.Add(new SqlParameter("ParentAssignID", model.ParentAssignID));
            }

            if (model.AssignConsumeStatus != null)
            {
                fileds.Add("[AssignConsumeStatus]=@AssignConsumeStatus");
                pms.Add(new SqlParameter("AssignConsumeStatus", model.AssignConsumeStatus));
            }

            if (model.SubjectGroupID != null)
            {
                fileds.Add("[SubjectGroupID]=@SubjectGroupID");
                pms.Add(new SqlParameter("SubjectGroupID", model.SubjectGroupID));
            }

            if (model.SubjectGroupName != null)
            {
                fileds.Add("[SubjectGroupName]=@SubjectGroupName");
                pms.Add(new SqlParameter("SubjectGroupName", model.SubjectGroupName));
            }

            if (model.TeacherSubjectGroupID != null)
            {
                fileds.Add("[TeacherSubjectGroupID]=@TeacherSubjectGroupID");
                pms.Add(new SqlParameter("TeacherSubjectGroupID", model.TeacherSubjectGroupID));
            }

            if (model.TeacherSubjectGroupName != null)
            {
                fileds.Add("[TeacherSubjectGroupName]=@TeacherSubjectGroupName");
                pms.Add(new SqlParameter("TeacherSubjectGroupName", model.TeacherSubjectGroupName));
            }

            if (model.CourseTimeLong != null)
            {
                fileds.Add("[CourseTimeLong]=@CourseTimeLong");
                pms.Add(new SqlParameter("CourseTimeLong", model.CourseTimeLong));
            }

            if (model.ConsumeCountHours != null)
            {
                fileds.Add("[ConsumeCountHours]=@ConsumeCountHours");
                pms.Add(new SqlParameter("ConsumeCountHours", model.ConsumeCountHours));
            }

            if (model.FinancialTime != null && model.FinancialTime != new DateTime())
            {
                fileds.Add("[FinancialTime]=@FinancialTime");
                pms.Add(new SqlParameter("FinancialTime", model.FinancialTime));
            }

            if (model.CourseConfirmTime != null && model.CourseConfirmTime != new DateTime())
            {
                fileds.Add("[CourseConfirmTime]=@CourseConfirmTime");
                pms.Add(new SqlParameter("CourseConfirmTime", model.CourseConfirmTime));
            }

            if (model.CancelType != null)
            {
                fileds.Add("[CancelType]=@CancelType");
                pms.Add(new SqlParameter("CancelType", model.CancelType));
            }

            if (model.TeachingSchoolID != null)
            {
                fileds.Add("[TeachingSchoolID]=@TeachingSchoolID");
                pms.Add(new SqlParameter("TeachingSchoolID", model.TeachingSchoolID));
            }

            if (model.TeachingSchoolName != null)
            {
                fileds.Add("[TeachingSchoolName]=@TeachingSchoolName");
                pms.Add(new SqlParameter("TeachingSchoolName", model.TeachingSchoolName));
            }

            if (model.ContractCode != null)
            {
                fileds.Add("[ContractCode]=@ContractCode");
                pms.Add(new SqlParameter("ContractCode", model.ContractCode));
            }

            if (model.AbnormalReasonType != null)
            {
                fileds.Add("[AbnormalReasonType]=@AbnormalReasonType");
                pms.Add(new SqlParameter("AbnormalReasonType", model.AbnormalReasonType));
            }

            if (model.TeachingVersion != null)
            {
                fileds.Add("[TeachingVersion]=@TeachingVersion");
                pms.Add(new SqlParameter("TeachingVersion", model.TeachingVersion));
            }

            if (model.CoursePlanCount != null)
            {
                fileds.Add("[CoursePlanCount]=@CoursePlanCount");
                pms.Add(new SqlParameter("CoursePlanCount", model.CoursePlanCount));
            }

            if (model.AllCourseCount != null)
            {
                fileds.Add("[AllCourseCount]=@AllCourseCount");
                pms.Add(new SqlParameter("AllCourseCount", model.AllCourseCount));
            }

            if (model.CourseTask != null)
            {
                fileds.Add("[CourseTask]=@CourseTask");
                pms.Add(new SqlParameter("CourseTask", model.CourseTask));
            }

            if (model.InstructionalObjectives != null)
            {
                fileds.Add("[InstructionalObjectives]=@InstructionalObjectives");
                pms.Add(new SqlParameter("InstructionalObjectives", model.InstructionalObjectives));
            }

            if (model.TeachingFocus != null)
            {
                fileds.Add("[TeachingFocus]=@TeachingFocus");
                pms.Add(new SqlParameter("TeachingFocus", model.TeachingFocus));
            }

            if (model.TeachingDifficulties != null)
            {
                fileds.Add("[TeachingDifficulties]=@TeachingDifficulties");
                pms.Add(new SqlParameter("TeachingDifficulties", model.TeachingDifficulties));
            }

            if (model.PlanStatus != null)
            {
                fileds.Add("[PlanStatus]=@PlanStatus");
                pms.Add(new SqlParameter("PlanStatus", model.PlanStatus));
            }

            if (model.PlanUserID != null)
            {
                fileds.Add("[PlanUserID]=@PlanUserID");
                pms.Add(new SqlParameter("PlanUserID", model.PlanUserID));
            }

            if (model.PlanUserPassportID != null)
            {
                fileds.Add("[PlanUserPassportID]=@PlanUserPassportID");
                pms.Add(new SqlParameter("PlanUserPassportID", model.PlanUserPassportID));
            }

            if (model.PlanUserName != null)
            {
                fileds.Add("[PlanUserName]=@PlanUserName");
                pms.Add(new SqlParameter("PlanUserName", model.PlanUserName));
            }

            if (model.PlanJobPassportID != null)
            {
                fileds.Add("[PlanJobPassportID]=@PlanJobPassportID");
                pms.Add(new SqlParameter("PlanJobPassportID", model.PlanJobPassportID));
            }

            if (model.PlanCreateTime != null && model.PlanCreateTime != new DateTime())
            {
                fileds.Add("[PlanCreateTime]=@PlanCreateTime");
                pms.Add(new SqlParameter("PlanCreateTime", model.PlanCreateTime));
            }

            if (model.TeacherActivity != null)
            {
                fileds.Add("[TeacherActivity]=@TeacherActivity");
                pms.Add(new SqlParameter("TeacherActivity", model.TeacherActivity));
            }

            if (model.StudentActivity != null)
            {
                fileds.Add("[StudentActivity]=@StudentActivity");
                pms.Add(new SqlParameter("StudentActivity", model.StudentActivity));
            }

            if (model.ConformStatus != null)
            {
                fileds.Add("[ConformStatus]=@ConformStatus");
                pms.Add(new SqlParameter("ConformStatus", model.ConformStatus));
            }

            if (model.ClassTime != null)
            {
                fileds.Add("[ClassTime]=@ClassTime");
                pms.Add(new SqlParameter("ClassTime", model.ClassTime));
            }

            if (model.ConfirmPersonStyle != null)
            {
                fileds.Add("[ConfirmPersonStyle]=@ConfirmPersonStyle");
                pms.Add(new SqlParameter("ConfirmPersonStyle", model.ConfirmPersonStyle));
            }

            if (model.ConfirmSource != null)
            {
                fileds.Add("[ConfirmSource]=@ConfirmSource");
                pms.Add(new SqlParameter("ConfirmSource", model.ConfirmSource));
            }

            if (model.LastModified != null)
            {
                fileds.Add("[LastModified]=@LastModified");
                pms.Add(new SqlParameter("LastModified", model.LastModified));
            }

            if (model.LastModifyDate != null && model.LastModifyDate != new DateTime())
            {
                fileds.Add("[LastModifyDate]=@LastModifyDate");
                pms.Add(new SqlParameter("LastModifyDate", model.LastModifyDate));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update AssignCourse set ");
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

        public static bool Save(AssignCourse model)
        {
            object obj = db.ExecuteScalar(CommandType.Text, "select count(1) from AssignCourse where Gid='" + model.Gid + "'");
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