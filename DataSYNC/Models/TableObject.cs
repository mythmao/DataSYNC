using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataSYNC.Models
{
    public class TableObject
    {
        public string TableName { get; set; }
        public string LastUpdateTime { get; set; }

        public int BranchID { get; set; }
        public int SchoolID { get; set; }
    }
}