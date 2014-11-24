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
    public partial class AsignCourseVoucherBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudCourse");


        public static List<AsignCourseVoucher> Search(string sqlStr, params SqlParameter[] parameters)
        {
            List<AsignCourseVoucher> list = new List<AsignCourseVoucher>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        AsignCourseVoucher model = new AsignCourseVoucher(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(AsignCourseVoucher model)
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


            if (model.VoucherType != null)
            {
                fileds.Add("[VoucherType]");
                pFileds.Add("@VoucherType");
                pms.Add(new SqlParameter("VoucherType", model.VoucherType));
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


            if (model.TeacherID != null)
            {
                fileds.Add("[TeacherID]");
                pFileds.Add("@TeacherID");
                pms.Add(new SqlParameter("TeacherID", model.TeacherID));
            }


            if (model.TeacherPassportID != null)
            {
                fileds.Add("[TeacherPassportID]");
                pFileds.Add("@TeacherPassportID");
                pms.Add(new SqlParameter("TeacherPassportID", model.TeacherPassportID));
            }


            if (model.SubmitTime != null && model.SubmitTime != new DateTime())
            {
                fileds.Add("[SubmitTime]");
                pFileds.Add("@SubmitTime");
                pms.Add(new SqlParameter("SubmitTime", model.SubmitTime));
            }


            if (model.CreatTime != null && model.CreatTime != new DateTime())
            {
                fileds.Add("[CreatTime]");
                pFileds.Add("@CreatTime");
                pms.Add(new SqlParameter("CreatTime", model.CreatTime));
            }


            if (model.AuditTime != null && model.AuditTime != new DateTime())
            {
                fileds.Add("[AuditTime]");
                pFileds.Add("@AuditTime");
                pms.Add(new SqlParameter("AuditTime", model.AuditTime));
            }


            if (model.VoucherState != null)
            {
                fileds.Add("[VoucherState]");
                pFileds.Add("@VoucherState");
                pms.Add(new SqlParameter("VoucherState", model.VoucherState));
            }


            if (model.Reason != null)
            {
                fileds.Add("[Reason]");
                pFileds.Add("@Reason");
                pms.Add(new SqlParameter("Reason", model.Reason));
            }


            if (model.TeacherName != null)
            {
                fileds.Add("[TeacherName]");
                pFileds.Add("@TeacherName");
                pms.Add(new SqlParameter("TeacherName", model.TeacherName));
            }


            if (model.Submiter != null)
            {
                fileds.Add("[Submiter]");
                pFileds.Add("@Submiter");
                pms.Add(new SqlParameter("Submiter", model.Submiter));
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


            if (model.TOrgPath != null)
            {
                fileds.Add("[TOrgPath]");
                pFileds.Add("@TOrgPath");
                pms.Add(new SqlParameter("TOrgPath", model.TOrgPath));
            }


            if (model.TeacherStaffCode != null)
            {
                fileds.Add("[TeacherStaffCode]");
                pFileds.Add("@TeacherStaffCode");
                pms.Add(new SqlParameter("TeacherStaffCode", model.TeacherStaffCode));
            }


            if (model.MJobID != null)
            {
                fileds.Add("[MJobID]");
                pFileds.Add("@MJobID");
                pms.Add(new SqlParameter("MJobID", model.MJobID));
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

            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO AsignCourseVoucher (");
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

        public static bool Update(AsignCourseVoucher model)
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
            pFileds.Add("[VoucherID]=@VoucherID");
            pms.Add(new SqlParameter("VoucherID", model.VoucherID));

            if (model.AsignCourseID != null)
            {
                fileds.Add("[AsignCourseID]=@AsignCourseID");
                pms.Add(new SqlParameter("AsignCourseID", model.AsignCourseID));
            }

            if (model.VoucherType != null)
            {
                fileds.Add("[VoucherType]=@VoucherType");
                pms.Add(new SqlParameter("VoucherType", model.VoucherType));
            }

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

            if (model.TeacherID != null)
            {
                fileds.Add("[TeacherID]=@TeacherID");
                pms.Add(new SqlParameter("TeacherID", model.TeacherID));
            }

            if (model.TeacherPassportID != null)
            {
                fileds.Add("[TeacherPassportID]=@TeacherPassportID");
                pms.Add(new SqlParameter("TeacherPassportID", model.TeacherPassportID));
            }

            if (model.SubmitTime != null && model.SubmitTime != new DateTime())
            {
                fileds.Add("[SubmitTime]=@SubmitTime");
                pms.Add(new SqlParameter("SubmitTime", model.SubmitTime));
            }

            if (model.CreatTime != null && model.CreatTime != new DateTime())
            {
                fileds.Add("[CreatTime]=@CreatTime");
                pms.Add(new SqlParameter("CreatTime", model.CreatTime));
            }

            if (model.AuditTime != null && model.AuditTime != new DateTime())
            {
                fileds.Add("[AuditTime]=@AuditTime");
                pms.Add(new SqlParameter("AuditTime", model.AuditTime));
            }

            if (model.VoucherState != null)
            {
                fileds.Add("[VoucherState]=@VoucherState");
                pms.Add(new SqlParameter("VoucherState", model.VoucherState));
            }

            if (model.Reason != null)
            {
                fileds.Add("[Reason]=@Reason");
                pms.Add(new SqlParameter("Reason", model.Reason));
            }

            if (model.TeacherName != null)
            {
                fileds.Add("[TeacherName]=@TeacherName");
                pms.Add(new SqlParameter("TeacherName", model.TeacherName));
            }

            if (model.Submiter != null)
            {
                fileds.Add("[Submiter]=@Submiter");
                pms.Add(new SqlParameter("Submiter", model.Submiter));
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

            if (model.TOrgPath != null)
            {
                fileds.Add("[TOrgPath]=@TOrgPath");
                pms.Add(new SqlParameter("TOrgPath", model.TOrgPath));
            }

            if (model.TeacherStaffCode != null)
            {
                fileds.Add("[TeacherStaffCode]=@TeacherStaffCode");
                pms.Add(new SqlParameter("TeacherStaffCode", model.TeacherStaffCode));
            }

            if (model.MJobID != null)
            {
                fileds.Add("[MJobID]=@MJobID");
                pms.Add(new SqlParameter("MJobID", model.MJobID));
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
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update AsignCourseVoucher set ");
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

        public static bool Save(AsignCourseVoucher model)
        {
            object obj = db.ExecuteScalar(CommandType.Text, "select count(1) from AsignCourseVoucher where Gid='" + model.Gid + "'");
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