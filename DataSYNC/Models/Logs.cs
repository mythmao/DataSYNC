using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSYNC.Models
{
    public partial class Logs
    {
        #region 属性
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String Controller { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ActionParameter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime InsertDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String Error { get; set; }
        #endregion
        public Logs() { }
        public Logs(DataRow dr)
        {
            if (dr.Table.Columns.Contains("Id"))
            {
                if (dr["Id"] != DBNull.Value)
                {
                    this.Id = (System.Int32)dr["Id"];
                }
            }
            if (dr.Table.Columns.Contains("Controller"))
            {
                if (dr["Controller"] != DBNull.Value)
                {
                    this.Controller = (System.String)dr["Controller"];
                }
            }
            if (dr.Table.Columns.Contains("Action"))
            {
                if (dr["Action"] != DBNull.Value)
                {
                    this.Action = (System.String)dr["Action"];
                }
            }
            if (dr.Table.Columns.Contains("ActionParameter"))
            {
                if (dr["ActionParameter"] != DBNull.Value)
                {
                    this.ActionParameter = (System.String)dr["ActionParameter"];
                }
            }
            if (dr.Table.Columns.Contains("InsertDate"))
            {
                if (dr["InsertDate"] != DBNull.Value)
                {
                    this.InsertDate = (System.DateTime)dr["InsertDate"];
                }
            }
            if (dr.Table.Columns.Contains("Error"))
            {
                if (dr["Error"] != DBNull.Value)
                {
                    this.Error = (System.String)dr["Error"];
                }
            }
        }
    }
}