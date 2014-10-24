using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSYNC.Models
{
    public partial class Course
    {
        #region 属性
        /// <summary>
        /// 
        /// </summary>
        public System.Guid Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String Subject { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Guid TeacherId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Guid StudentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime CourseTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime UpdateDate { get; set; }
        #endregion
        public Course() { }
        public Course(DataRow dr)
        {
            if (dr.Table.Columns.Contains("Id"))
            {
                if (dr["Id"] != DBNull.Value)
                {
                    this.Id = (System.Guid)dr["Id"];
                }
            }
            if (dr.Table.Columns.Contains("Subject"))
            {
                if (dr["Subject"] != DBNull.Value)
                {
                    this.Subject = (System.String)dr["Subject"];
                }
            }
            if (dr.Table.Columns.Contains("TeacherId"))
            {
                if (dr["TeacherId"] != DBNull.Value)
                {
                    this.TeacherId = (System.Guid)dr["TeacherId"];
                }
            }
            if (dr.Table.Columns.Contains("StudentId"))
            {
                if (dr["StudentId"] != DBNull.Value)
                {
                    this.StudentId = (System.Guid)dr["StudentId"];
                }
            }
            if (dr.Table.Columns.Contains("CourseTime"))
            {
                if (dr["CourseTime"] != DBNull.Value)
                {
                    this.CourseTime = (System.DateTime)dr["CourseTime"];
                }
            }
            if (dr.Table.Columns.Contains("Status"))
            {
                if (dr["Status"] != DBNull.Value)
                {
                    this.Status = (System.Int32)dr["Status"];
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