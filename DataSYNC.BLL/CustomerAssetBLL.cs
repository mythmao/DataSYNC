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
    public partial class CustomerAssetBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudCustomer");


        public static List<CustomerAsset> Search(string sqlStr, params SqlParameter[] parameters)
        {
            List<CustomerAsset> list = new List<CustomerAsset>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        CustomerAsset model = new CustomerAsset(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(CustomerAsset model)
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


            if (model.CommonCourseAmount != null)
            {
                fileds.Add("[CommonCourseAmount]");
                pFileds.Add("@CommonCourseAmount");
                pms.Add(new SqlParameter("CommonCourseAmount", model.CommonCourseAmount));
            }


            if (model.SpecialCourseAmount != null)
            {
                fileds.Add("[SpecialCourseAmount]");
                pFileds.Add("@SpecialCourseAmount");
                pms.Add(new SqlParameter("SpecialCourseAmount", model.SpecialCourseAmount));
            }


            if (model.LastCourseTime != null && model.LastCourseTime != new DateTime())
            {
                fileds.Add("[LastCourseTime]");
                pFileds.Add("@LastCourseTime");
                pms.Add(new SqlParameter("LastCourseTime", model.LastCourseTime));
            }


            if (model.HasTeacher != null)
            {
                fileds.Add("[HasTeacher]");
                pFileds.Add("@HasTeacher");
                pms.Add(new SqlParameter("HasTeacher", model.HasTeacher));
            }


            if (model.LeftAssetValue != null)
            {
                fileds.Add("[LeftAssetValue]");
                pFileds.Add("@LeftAssetValue");
                pms.Add(new SqlParameter("LeftAssetValue", model.LeftAssetValue));
            }


            if (model.InsertTime != null && model.InsertTime != new DateTime())
            {
                fileds.Add("[InsertTime]");
                pFileds.Add("@InsertTime");
                pms.Add(new SqlParameter("InsertTime", model.InsertTime));
            }


            if (model.ChangeTime != null && model.ChangeTime != new DateTime())
            {
                fileds.Add("[ChangeTime]");
                pFileds.Add("@ChangeTime");
                pms.Add(new SqlParameter("ChangeTime", model.ChangeTime));
            }


            if (model.TotalCourseAmount != null)
            {
                fileds.Add("[TotalCourseAmount]");
                pFileds.Add("@TotalCourseAmount");
                pms.Add(new SqlParameter("TotalCourseAmount", model.TotalCourseAmount));
            }


            if (model.TotalOrderedCourseAmount != null)
            {
                fileds.Add("[TotalOrderedCourseAmount]");
                pFileds.Add("@TotalOrderedCourseAmount");
                pms.Add(new SqlParameter("TotalOrderedCourseAmount", model.TotalOrderedCourseAmount));
            }

            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO CustomerAsset (");
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

        public static bool Update(CustomerAsset model)
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
            pFileds.Add("[ID]=@ID");
            pms.Add(new SqlParameter("ID", model.ID));

            if (model.StudentID != null)
            {
                fileds.Add("[StudentID]=@StudentID");
                pms.Add(new SqlParameter("StudentID", model.StudentID));
            }

            if (model.CommonCourseAmount != null)
            {
                fileds.Add("[CommonCourseAmount]=@CommonCourseAmount");
                pms.Add(new SqlParameter("CommonCourseAmount", model.CommonCourseAmount));
            }

            if (model.SpecialCourseAmount != null)
            {
                fileds.Add("[SpecialCourseAmount]=@SpecialCourseAmount");
                pms.Add(new SqlParameter("SpecialCourseAmount", model.SpecialCourseAmount));
            }

            if (model.LastCourseTime != null && model.LastCourseTime != new DateTime())
            {
                fileds.Add("[LastCourseTime]=@LastCourseTime");
                pms.Add(new SqlParameter("LastCourseTime", model.LastCourseTime));
            }

            if (model.HasTeacher != null)
            {
                fileds.Add("[HasTeacher]=@HasTeacher");
                pms.Add(new SqlParameter("HasTeacher", model.HasTeacher));
            }

            if (model.LeftAssetValue != null)
            {
                fileds.Add("[LeftAssetValue]=@LeftAssetValue");
                pms.Add(new SqlParameter("LeftAssetValue", model.LeftAssetValue));
            }

            if (model.InsertTime != null && model.InsertTime != new DateTime())
            {
                fileds.Add("[InsertTime]=@InsertTime");
                pms.Add(new SqlParameter("InsertTime", model.InsertTime));
            }

            if (model.ChangeTime != null && model.ChangeTime != new DateTime())
            {
                fileds.Add("[ChangeTime]=@ChangeTime");
                pms.Add(new SqlParameter("ChangeTime", model.ChangeTime));
            }

            if (model.TotalCourseAmount != null)
            {
                fileds.Add("[TotalCourseAmount]=@TotalCourseAmount");
                pms.Add(new SqlParameter("TotalCourseAmount", model.TotalCourseAmount));
            }

            if (model.TotalOrderedCourseAmount != null)
            {
                fileds.Add("[TotalOrderedCourseAmount]=@TotalOrderedCourseAmount");
                pms.Add(new SqlParameter("TotalOrderedCourseAmount", model.TotalOrderedCourseAmount));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update CustomerAsset set ");
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

        public static bool Save(CustomerAsset model)
        {
            object obj = db.ExecuteScalar(CommandType.Text, "select count(1) from CustomerAsset where Gid='" + model.Gid + "'");
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