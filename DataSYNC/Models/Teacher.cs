using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSYNC.Models
{
    public partial class Teacher
    {
        #region 属性
        /// <summary>
        /// 
        /// </summary>
        public System.Guid Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 Age { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime InsertDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 Status { get; set; }
        #endregion
        public Teacher() { }
        public Teacher(DataRow dr)
        {
            if (dr.Table.Columns.Contains("Id"))
            {
                if (dr["Id"] != DBNull.Value)
                {
                    this.Id = (System.Guid)dr["Id"];
                }
            }
            if (dr.Table.Columns.Contains("Name"))
            {
                if (dr["Name"] != DBNull.Value)
                {
                    this.Name = (System.String)dr["Name"];
                }
            }
            if (dr.Table.Columns.Contains("Gender"))
            {
                if (dr["Gender"] != DBNull.Value)
                {
                    this.Gender = (System.Int32)dr["Gender"];
                }
            }
            if (dr.Table.Columns.Contains("Age"))
            {
                if (dr["Age"] != DBNull.Value)
                {
                    this.Age = (System.Int32)dr["Age"];
                }
            }
            if (dr.Table.Columns.Contains("InsertDate"))
            {
                if (dr["InsertDate"] != DBNull.Value)
                {
                    this.InsertDate = (System.DateTime)dr["InsertDate"];
                }
            }
            if (dr.Table.Columns.Contains("UpdateDate"))
            {
                if (dr["UpdateDate"] != DBNull.Value)
                {
                    this.UpdateDate = (System.DateTime)dr["UpdateDate"];
                }
            }
            if (dr.Table.Columns.Contains("Status"))
            {
                if (dr["Status"] != DBNull.Value)
                {
                    this.Status = (System.Int32)dr["Status"];
                }
            }
        }
    }
}