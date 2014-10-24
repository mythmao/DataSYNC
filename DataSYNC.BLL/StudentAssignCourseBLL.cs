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
    public static partial class StudentAssignCourseBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudCourse");


        public static List<StudentAssignCourse> Search(string sqlStr, params SqlParameter[] parameters)
        {
            List<StudentAssignCourse> list = new List<StudentAssignCourse>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        StudentAssignCourse model = new StudentAssignCourse(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(StudentAssignCourse model)
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



            if (model.StudentID != null)
            {
                fileds.Add("[StudentID]");
                pFileds.Add("@StudentID");
                pms.Add(new SqlParameter("StudentID", model.StudentID));
            }


            if (model.StudentPassportID != null)
            {
                fileds.Add("[StudentPassportID]");
                pFileds.Add("@StudentPassportID");
                pms.Add(new SqlParameter("StudentPassportID", model.StudentPassportID));
            }


            if (model.ProductID != null)
            {
                fileds.Add("[ProductID]");
                pFileds.Add("@ProductID");
                pms.Add(new SqlParameter("ProductID", model.ProductID));
            }


            if (model.SubjectID != null)
            {
                fileds.Add("[SubjectID]");
                pFileds.Add("@SubjectID");
                pms.Add(new SqlParameter("SubjectID", model.SubjectID));
            }


            if (model.StudyTarget != null)
            {
                fileds.Add("[StudyTarget]");
                pFileds.Add("@StudyTarget");
                pms.Add(new SqlParameter("StudyTarget", model.StudyTarget));
            }


            if (model.NumberOfWeek != null)
            {
                fileds.Add("[NumberOfWeek]");
                pFileds.Add("@NumberOfWeek");
                pms.Add(new SqlParameter("NumberOfWeek", model.NumberOfWeek));
            }


            if (model.FirstCourseTime != null && model.FirstCourseTime != new DateTime())
            {
                fileds.Add("[FirstCourseTime]");
                pFileds.Add("@FirstCourseTime");
                pms.Add(new SqlParameter("FirstCourseTime", model.FirstCourseTime));
            }


            if (model.CreateDate != null && model.CreateDate != new DateTime())
            {
                fileds.Add("[CreateDate]");
                pFileds.Add("@CreateDate");
                pms.Add(new SqlParameter("CreateDate", model.CreateDate));
            }


            if (model.HostID != null)
            {
                fileds.Add("[HostID]");
                pFileds.Add("@HostID");
                pms.Add(new SqlParameter("HostID", model.HostID));
            }


            if (model.SubjectName != null)
            {
                fileds.Add("[SubjectName]");
                pFileds.Add("@SubjectName");
                pms.Add(new SqlParameter("SubjectName", model.SubjectName));
            }


            if (model.RemediationIntentName != null)
            {
                fileds.Add("[RemediationIntentName]");
                pFileds.Add("@RemediationIntentName");
                pms.Add(new SqlParameter("RemediationIntentName", model.RemediationIntentName));
            }


            if (model.ProductName != null)
            {
                fileds.Add("[ProductName]");
                pFileds.Add("@ProductName");
                pms.Add(new SqlParameter("ProductName", model.ProductName));
            }


            if (model.ProductCode != null)
            {
                fileds.Add("[ProductCode]");
                pFileds.Add("@ProductCode");
                pms.Add(new SqlParameter("ProductCode", model.ProductCode));
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


            if (model.TeacherName != null)
            {
                fileds.Add("[TeacherName]");
                pFileds.Add("@TeacherName");
                pms.Add(new SqlParameter("TeacherName", model.TeacherName));
            }


            if (model.GradeName != null)
            {
                fileds.Add("[GradeName]");
                pFileds.Add("@GradeName");
                pms.Add(new SqlParameter("GradeName", model.GradeName));
            }


            if (model.GradeCode != null)
            {
                fileds.Add("[GradeCode]");
                pFileds.Add("@GradeCode");
                pms.Add(new SqlParameter("GradeCode", model.GradeCode));
            }


            if (model.StudentName != null)
            {
                fileds.Add("[StudentName]");
                pFileds.Add("@StudentName");
                pms.Add(new SqlParameter("StudentName", model.StudentName));
            }


            if (model.TeacherLevel != null)
            {
                fileds.Add("[TeacherLevel]");
                pFileds.Add("@TeacherLevel");
                pms.Add(new SqlParameter("TeacherLevel", model.TeacherLevel));
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


            if (model.TeacherStaffCode != null)
            {
                fileds.Add("[TeacherStaffCode]");
                pFileds.Add("@TeacherStaffCode");
                pms.Add(new SqlParameter("TeacherStaffCode", model.TeacherStaffCode));
            }


            if (model.LastModifyDate != null && model.LastModifyDate != new DateTime())
            {
                fileds.Add("[LastModifyDate]");
                pFileds.Add("@LastModifyDate");
                pms.Add(new SqlParameter("LastModifyDate", model.LastModifyDate));
            }


            if (model.TeacherLevelName != null)
            {
                fileds.Add("[TeacherLevelName]");
                pFileds.Add("@TeacherLevelName");
                pms.Add(new SqlParameter("TeacherLevelName", model.TeacherLevelName));
            }


            if (model.TOrgPath != null)
            {
                fileds.Add("[TOrgPath]");
                pFileds.Add("@TOrgPath");
                pms.Add(new SqlParameter("TOrgPath", model.TOrgPath));
            }


            if (model.MJobPassportID != null)
            {
                fileds.Add("[MJobPassportID]");
                pFileds.Add("@MJobPassportID");
                pms.Add(new SqlParameter("MJobPassportID", model.MJobPassportID));
            }


            if (model.POrgPath != null)
            {
                fileds.Add("[POrgPath]");
                pFileds.Add("@POrgPath");
                pms.Add(new SqlParameter("POrgPath", model.POrgPath));
            }


            if (model.StudentCode != null)
            {
                fileds.Add("[StudentCode]");
                pFileds.Add("@StudentCode");
                pms.Add(new SqlParameter("StudentCode", model.StudentCode));
            }


            if (model.MJobID != null)
            {
                fileds.Add("[MJobID]");
                pFileds.Add("@MJobID");
                pms.Add(new SqlParameter("MJobID", model.MJobID));
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


            if (model.Enable != null)
            {
                fileds.Add("[Enable]");
                pFileds.Add("@Enable");
                pms.Add(new SqlParameter("Enable", model.Enable));
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


            if (model.StudentSchoolID != null)
            {
                fileds.Add("[StudentSchoolID]");
                pFileds.Add("@StudentSchoolID");
                pms.Add(new SqlParameter("StudentSchoolID", model.StudentSchoolID));
            }


            if (model.SubjectGroupSchoolID != null)
            {
                fileds.Add("[SubjectGroupSchoolID]");
                pFileds.Add("@SubjectGroupSchoolID");
                pms.Add(new SqlParameter("SubjectGroupSchoolID", model.SubjectGroupSchoolID));
            }


            if (model.CompanyID != null)
            {
                fileds.Add("[CompanyID]");
                pFileds.Add("@CompanyID");
                pms.Add(new SqlParameter("CompanyID", model.CompanyID));
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


            if (model.MUserID != null)
            {
                fileds.Add("[MUserID]");
                pFileds.Add("@MUserID");
                pms.Add(new SqlParameter("MUserID", model.MUserID));
            }


            if (model.MUserPassportID != null)
            {
                fileds.Add("[MUserPassportID]");
                pFileds.Add("@MUserPassportID");
                pms.Add(new SqlParameter("MUserPassportID", model.MUserPassportID));
            }


            if (model.MUserName != null)
            {
                fileds.Add("[MUserName]");
                pFileds.Add("@MUserName");
                pms.Add(new SqlParameter("MUserName", model.MUserName));
            }


            if (model.ContractID != null)
            {
                fileds.Add("[ContractID]");
                pFileds.Add("@ContractID");
                pms.Add(new SqlParameter("ContractID", model.ContractID));
            }


            if (model.ContractCode != null)
            {
                fileds.Add("[ContractCode]");
                pFileds.Add("@ContractCode");
                pms.Add(new SqlParameter("ContractCode", model.ContractCode));
            }

            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO StudentAssignCourse (");
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

        public static bool Update(StudentAssignCourse model)
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
            pFileds.Add("[AsignCourseID]=@AsignCourseID");
            pms.Add(new SqlParameter("AsignCourseID", model.AsignCourseID));

            if (model.StudentID != null)
            {
                fileds.Add("[StudentID]=@StudentID");
                pms.Add(new SqlParameter("StudentID", model.StudentID));
            }

            if (model.StudentPassportID != null)
            {
                fileds.Add("[StudentPassportID]=@StudentPassportID");
                pms.Add(new SqlParameter("StudentPassportID", model.StudentPassportID));
            }

            if (model.ProductID != null)
            {
                fileds.Add("[ProductID]=@ProductID");
                pms.Add(new SqlParameter("ProductID", model.ProductID));
            }

            if (model.SubjectID != null)
            {
                fileds.Add("[SubjectID]=@SubjectID");
                pms.Add(new SqlParameter("SubjectID", model.SubjectID));
            }

            if (model.StudyTarget != null)
            {
                fileds.Add("[StudyTarget]=@StudyTarget");
                pms.Add(new SqlParameter("StudyTarget", model.StudyTarget));
            }

            if (model.NumberOfWeek != null)
            {
                fileds.Add("[NumberOfWeek]=@NumberOfWeek");
                pms.Add(new SqlParameter("NumberOfWeek", model.NumberOfWeek));
            }

            if (model.FirstCourseTime != null && model.FirstCourseTime != new DateTime())
            {
                fileds.Add("[FirstCourseTime]=@FirstCourseTime");
                pms.Add(new SqlParameter("FirstCourseTime", model.FirstCourseTime));
            }

            if (model.CreateDate != null && model.CreateDate != new DateTime())
            {
                fileds.Add("[CreateDate]=@CreateDate");
                pms.Add(new SqlParameter("CreateDate", model.CreateDate));
            }

            if (model.HostID != null)
            {
                fileds.Add("[HostID]=@HostID");
                pms.Add(new SqlParameter("HostID", model.HostID));
            }

            if (model.SubjectName != null)
            {
                fileds.Add("[SubjectName]=@SubjectName");
                pms.Add(new SqlParameter("SubjectName", model.SubjectName));
            }

            if (model.RemediationIntentName != null)
            {
                fileds.Add("[RemediationIntentName]=@RemediationIntentName");
                pms.Add(new SqlParameter("RemediationIntentName", model.RemediationIntentName));
            }

            if (model.ProductName != null)
            {
                fileds.Add("[ProductName]=@ProductName");
                pms.Add(new SqlParameter("ProductName", model.ProductName));
            }

            if (model.ProductCode != null)
            {
                fileds.Add("[ProductCode]=@ProductCode");
                pms.Add(new SqlParameter("ProductCode", model.ProductCode));
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

            if (model.TeacherName != null)
            {
                fileds.Add("[TeacherName]=@TeacherName");
                pms.Add(new SqlParameter("TeacherName", model.TeacherName));
            }

            if (model.GradeName != null)
            {
                fileds.Add("[GradeName]=@GradeName");
                pms.Add(new SqlParameter("GradeName", model.GradeName));
            }

            if (model.GradeCode != null)
            {
                fileds.Add("[GradeCode]=@GradeCode");
                pms.Add(new SqlParameter("GradeCode", model.GradeCode));
            }

            if (model.StudentName != null)
            {
                fileds.Add("[StudentName]=@StudentName");
                pms.Add(new SqlParameter("StudentName", model.StudentName));
            }

            if (model.TeacherLevel != null)
            {
                fileds.Add("[TeacherLevel]=@TeacherLevel");
                pms.Add(new SqlParameter("TeacherLevel", model.TeacherLevel));
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

            if (model.TeacherStaffCode != null)
            {
                fileds.Add("[TeacherStaffCode]=@TeacherStaffCode");
                pms.Add(new SqlParameter("TeacherStaffCode", model.TeacherStaffCode));
            }

            if (model.LastModifyDate != null && model.LastModifyDate != new DateTime())
            {
                fileds.Add("[LastModifyDate]=@LastModifyDate");
                pms.Add(new SqlParameter("LastModifyDate", model.LastModifyDate));
            }

            if (model.TeacherLevelName != null)
            {
                fileds.Add("[TeacherLevelName]=@TeacherLevelName");
                pms.Add(new SqlParameter("TeacherLevelName", model.TeacherLevelName));
            }

            if (model.TOrgPath != null)
            {
                fileds.Add("[TOrgPath]=@TOrgPath");
                pms.Add(new SqlParameter("TOrgPath", model.TOrgPath));
            }

            if (model.MJobPassportID != null)
            {
                fileds.Add("[MJobPassportID]=@MJobPassportID");
                pms.Add(new SqlParameter("MJobPassportID", model.MJobPassportID));
            }

            if (model.POrgPath != null)
            {
                fileds.Add("[POrgPath]=@POrgPath");
                pms.Add(new SqlParameter("POrgPath", model.POrgPath));
            }

            if (model.StudentCode != null)
            {
                fileds.Add("[StudentCode]=@StudentCode");
                pms.Add(new SqlParameter("StudentCode", model.StudentCode));
            }

            if (model.MJobID != null)
            {
                fileds.Add("[MJobID]=@MJobID");
                pms.Add(new SqlParameter("MJobID", model.MJobID));
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

            if (model.Enable != null)
            {
                fileds.Add("[Enable]=@Enable");
                pms.Add(new SqlParameter("Enable", model.Enable));
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

            if (model.StudentSchoolID != null)
            {
                fileds.Add("[StudentSchoolID]=@StudentSchoolID");
                pms.Add(new SqlParameter("StudentSchoolID", model.StudentSchoolID));
            }

            if (model.SubjectGroupSchoolID != null)
            {
                fileds.Add("[SubjectGroupSchoolID]=@SubjectGroupSchoolID");
                pms.Add(new SqlParameter("SubjectGroupSchoolID", model.SubjectGroupSchoolID));
            }

            if (model.CompanyID != null)
            {
                fileds.Add("[CompanyID]=@CompanyID");
                pms.Add(new SqlParameter("CompanyID", model.CompanyID));
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

            if (model.MUserID != null)
            {
                fileds.Add("[MUserID]=@MUserID");
                pms.Add(new SqlParameter("MUserID", model.MUserID));
            }

            if (model.MUserPassportID != null)
            {
                fileds.Add("[MUserPassportID]=@MUserPassportID");
                pms.Add(new SqlParameter("MUserPassportID", model.MUserPassportID));
            }

            if (model.MUserName != null)
            {
                fileds.Add("[MUserName]=@MUserName");
                pms.Add(new SqlParameter("MUserName", model.MUserName));
            }

            if (model.ContractID != null)
            {
                fileds.Add("[ContractID]=@ContractID");
                pms.Add(new SqlParameter("ContractID", model.ContractID));
            }

            if (model.ContractCode != null)
            {
                fileds.Add("[ContractCode]=@ContractCode");
                pms.Add(new SqlParameter("ContractCode", model.ContractCode));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update StudentAssignCourse set ");
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

        public static bool Save(StudentAssignCourse model)
        {
            object obj = db.ExecuteScalar(CommandType.Text, "select count(1) from StudentAssignCourse where Gid='" + model.Gid + "'");
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