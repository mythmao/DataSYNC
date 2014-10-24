using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSYNC.Model
{
    public partial class CustomerSearch
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
        public System.Int64 ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 CustomerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 CustomerPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String CustomerCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String CustomerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 CustomerUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String CustomerUserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String FullPinyin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String SimplePinyin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime Birthday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 CurSchoolID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String CurSchoolName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 Grade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String PriParentName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 PriParentID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String PriParentMobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String AllParents { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 InquiryUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String InquiryUserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 InquiryStaffID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 InquiryPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 InquiryJobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ManagerStaffID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ManagerPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ManagerJobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ManagerUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ManagerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 InsertStaffID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 InsertUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 InsertPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String InsertStaffName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 InsertJobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String InsertJobName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 InsertJobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 AssetStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime InsertTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 BranchID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String BranchName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String BranchShortName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 XDSchoolID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String XDSchoolName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String XDSchoolShortName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 HostID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String Mobile1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 OrgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OrgPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal CommonCourseAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal SpecialCourseAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal LeftAssetValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal TotalCourseAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal TotalOrderedCourseAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 TotalAssetCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime LastCourseTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime OperateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 ContractStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 PayStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime ReturnTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ReturnInfoItemCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 ProductType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 CallType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 FromSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SourceInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 IsAssignTeacher { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 ContactType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime SignUpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 FromSysID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OriginalFromSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 StudentType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TeachingPlaceID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TeachingPlaceName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 InquiryPlaceID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String InquiryPlaceName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 SalePhase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String AddressDetail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 PurchaseIntention { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime NextReturnTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 CustomerType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String SourceSignStaffName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 FollowupNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 SourceMainType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String SourceMainValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 SourceSubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String SourceSubValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int16 InsertJobType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String InsertJobTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime LastFollowupTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime NextFollowupTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 CustomerLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String CustomerMobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 InsertDepartID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String InsertDepartName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 ClassEndState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime ClassEndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime ReturnPrePassDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 LockType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 CustomerGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TelJobPassprotID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TelPassprotID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String TelStaffName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TelStaffID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TelJobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 PotentialType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 VipType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 VipLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 DataSourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 Pretreatment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int16 HasRelation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean IsSubjectGroupSchool { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean IsAssignSubjectGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int16 HasTeacher { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 UnValidType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int16 HasExam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte[] LastModified { get; set; }
        #endregion
        public CustomerSearch() { }
        public CustomerSearch(DataRow dr)
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
            if (dr.Table.Columns.Contains("ID"))
            {
                if (dr["ID"] != DBNull.Value)
                {
                    this.ID = (System.Int64)dr["ID"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerID"))
            {
                if (dr["CustomerID"] != DBNull.Value)
                {
                    this.CustomerID = (System.Int64)dr["CustomerID"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerPassportID"))
            {
                if (dr["CustomerPassportID"] != DBNull.Value)
                {
                    this.CustomerPassportID = (System.Int64)dr["CustomerPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerCode"))
            {
                if (dr["CustomerCode"] != DBNull.Value)
                {
                    this.CustomerCode = (System.String)dr["CustomerCode"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerName"))
            {
                if (dr["CustomerName"] != DBNull.Value)
                {
                    this.CustomerName = (System.String)dr["CustomerName"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerUserID"))
            {
                if (dr["CustomerUserID"] != DBNull.Value)
                {
                    this.CustomerUserID = (System.Int64)dr["CustomerUserID"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerUserName"))
            {
                if (dr["CustomerUserName"] != DBNull.Value)
                {
                    this.CustomerUserName = (System.String)dr["CustomerUserName"];
                }
            }
            if (dr.Table.Columns.Contains("FullPinyin"))
            {
                if (dr["FullPinyin"] != DBNull.Value)
                {
                    this.FullPinyin = (System.String)dr["FullPinyin"];
                }
            }
            if (dr.Table.Columns.Contains("SimplePinyin"))
            {
                if (dr["SimplePinyin"] != DBNull.Value)
                {
                    this.SimplePinyin = (System.String)dr["SimplePinyin"];
                }
            }
            if (dr.Table.Columns.Contains("Gender"))
            {
                if (dr["Gender"] != DBNull.Value)
                {
                    this.Gender = (System.Int32)dr["Gender"];
                }
            }
            if (dr.Table.Columns.Contains("Birthday"))
            {
                if (dr["Birthday"] != DBNull.Value)
                {
                    this.Birthday = (System.DateTime)dr["Birthday"];
                }
            }
            if (dr.Table.Columns.Contains("CurSchoolID"))
            {
                if (dr["CurSchoolID"] != DBNull.Value)
                {
                    this.CurSchoolID = (System.Int64)dr["CurSchoolID"];
                }
            }
            if (dr.Table.Columns.Contains("CurSchoolName"))
            {
                if (dr["CurSchoolName"] != DBNull.Value)
                {
                    this.CurSchoolName = (System.String)dr["CurSchoolName"];
                }
            }
            if (dr.Table.Columns.Contains("Grade"))
            {
                if (dr["Grade"] != DBNull.Value)
                {
                    this.Grade = (System.Int32)dr["Grade"];
                }
            }
            if (dr.Table.Columns.Contains("PriParentName"))
            {
                if (dr["PriParentName"] != DBNull.Value)
                {
                    this.PriParentName = (System.String)dr["PriParentName"];
                }
            }
            if (dr.Table.Columns.Contains("PriParentID"))
            {
                if (dr["PriParentID"] != DBNull.Value)
                {
                    this.PriParentID = (System.Int64)dr["PriParentID"];
                }
            }
            if (dr.Table.Columns.Contains("PriParentMobile"))
            {
                if (dr["PriParentMobile"] != DBNull.Value)
                {
                    this.PriParentMobile = (System.String)dr["PriParentMobile"];
                }
            }
            if (dr.Table.Columns.Contains("AllParents"))
            {
                if (dr["AllParents"] != DBNull.Value)
                {
                    this.AllParents = (System.String)dr["AllParents"];
                }
            }
            if (dr.Table.Columns.Contains("InquiryUserID"))
            {
                if (dr["InquiryUserID"] != DBNull.Value)
                {
                    this.InquiryUserID = (System.Int64)dr["InquiryUserID"];
                }
            }
            if (dr.Table.Columns.Contains("InquiryUserName"))
            {
                if (dr["InquiryUserName"] != DBNull.Value)
                {
                    this.InquiryUserName = (System.String)dr["InquiryUserName"];
                }
            }
            if (dr.Table.Columns.Contains("InquiryStaffID"))
            {
                if (dr["InquiryStaffID"] != DBNull.Value)
                {
                    this.InquiryStaffID = (System.Int64)dr["InquiryStaffID"];
                }
            }
            if (dr.Table.Columns.Contains("InquiryPassportID"))
            {
                if (dr["InquiryPassportID"] != DBNull.Value)
                {
                    this.InquiryPassportID = (System.Int64)dr["InquiryPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("InquiryJobPassportID"))
            {
                if (dr["InquiryJobPassportID"] != DBNull.Value)
                {
                    this.InquiryJobPassportID = (System.Int64)dr["InquiryJobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("ManagerStaffID"))
            {
                if (dr["ManagerStaffID"] != DBNull.Value)
                {
                    this.ManagerStaffID = (System.Int64)dr["ManagerStaffID"];
                }
            }
            if (dr.Table.Columns.Contains("ManagerPassportID"))
            {
                if (dr["ManagerPassportID"] != DBNull.Value)
                {
                    this.ManagerPassportID = (System.Int64)dr["ManagerPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("ManagerJobPassportID"))
            {
                if (dr["ManagerJobPassportID"] != DBNull.Value)
                {
                    this.ManagerJobPassportID = (System.Int64)dr["ManagerJobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("ManagerUserID"))
            {
                if (dr["ManagerUserID"] != DBNull.Value)
                {
                    this.ManagerUserID = (System.Int64)dr["ManagerUserID"];
                }
            }
            if (dr.Table.Columns.Contains("ManagerName"))
            {
                if (dr["ManagerName"] != DBNull.Value)
                {
                    this.ManagerName = (System.String)dr["ManagerName"];
                }
            }
            if (dr.Table.Columns.Contains("InsertStaffID"))
            {
                if (dr["InsertStaffID"] != DBNull.Value)
                {
                    this.InsertStaffID = (System.Int64)dr["InsertStaffID"];
                }
            }
            if (dr.Table.Columns.Contains("InsertUserID"))
            {
                if (dr["InsertUserID"] != DBNull.Value)
                {
                    this.InsertUserID = (System.Int64)dr["InsertUserID"];
                }
            }
            if (dr.Table.Columns.Contains("InsertPassportID"))
            {
                if (dr["InsertPassportID"] != DBNull.Value)
                {
                    this.InsertPassportID = (System.Int64)dr["InsertPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("InsertStaffName"))
            {
                if (dr["InsertStaffName"] != DBNull.Value)
                {
                    this.InsertStaffName = (System.String)dr["InsertStaffName"];
                }
            }
            if (dr.Table.Columns.Contains("InsertJobID"))
            {
                if (dr["InsertJobID"] != DBNull.Value)
                {
                    this.InsertJobID = (System.Int64)dr["InsertJobID"];
                }
            }
            if (dr.Table.Columns.Contains("InsertJobName"))
            {
                if (dr["InsertJobName"] != DBNull.Value)
                {
                    this.InsertJobName = (System.String)dr["InsertJobName"];
                }
            }
            if (dr.Table.Columns.Contains("InsertJobPassportID"))
            {
                if (dr["InsertJobPassportID"] != DBNull.Value)
                {
                    this.InsertJobPassportID = (System.Int64)dr["InsertJobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("Status"))
            {
                if (dr["Status"] != DBNull.Value)
                {
                    this.Status = (System.Int32)dr["Status"];
                }
            }
            if (dr.Table.Columns.Contains("AssetStatus"))
            {
                if (dr["AssetStatus"] != DBNull.Value)
                {
                    this.AssetStatus = (System.Int32)dr["AssetStatus"];
                }
            }
            if (dr.Table.Columns.Contains("InsertTime"))
            {
                if (dr["InsertTime"] != DBNull.Value)
                {
                    this.InsertTime = (System.DateTime)dr["InsertTime"];
                }
            }
            if (dr.Table.Columns.Contains("BranchID"))
            {
                if (dr["BranchID"] != DBNull.Value)
                {
                    this.BranchID = (System.Int64)dr["BranchID"];
                }
            }
            if (dr.Table.Columns.Contains("BranchName"))
            {
                if (dr["BranchName"] != DBNull.Value)
                {
                    this.BranchName = (System.String)dr["BranchName"];
                }
            }
            if (dr.Table.Columns.Contains("BranchShortName"))
            {
                if (dr["BranchShortName"] != DBNull.Value)
                {
                    this.BranchShortName = (System.String)dr["BranchShortName"];
                }
            }
            if (dr.Table.Columns.Contains("XDSchoolID"))
            {
                if (dr["XDSchoolID"] != DBNull.Value)
                {
                    this.XDSchoolID = (System.Int64)dr["XDSchoolID"];
                }
            }
            if (dr.Table.Columns.Contains("XDSchoolName"))
            {
                if (dr["XDSchoolName"] != DBNull.Value)
                {
                    this.XDSchoolName = (System.String)dr["XDSchoolName"];
                }
            }
            if (dr.Table.Columns.Contains("XDSchoolShortName"))
            {
                if (dr["XDSchoolShortName"] != DBNull.Value)
                {
                    this.XDSchoolShortName = (System.String)dr["XDSchoolShortName"];
                }
            }
            if (dr.Table.Columns.Contains("HostID"))
            {
                if (dr["HostID"] != DBNull.Value)
                {
                    this.HostID = (System.Int64)dr["HostID"];
                }
            }
            if (dr.Table.Columns.Contains("Mobile1"))
            {
                if (dr["Mobile1"] != DBNull.Value)
                {
                    this.Mobile1 = (System.String)dr["Mobile1"];
                }
            }
            if (dr.Table.Columns.Contains("City"))
            {
                if (dr["City"] != DBNull.Value)
                {
                    this.City = (System.Int32)dr["City"];
                }
            }
            if (dr.Table.Columns.Contains("OrgID"))
            {
                if (dr["OrgID"] != DBNull.Value)
                {
                    this.OrgID = (System.Int64)dr["OrgID"];
                }
            }
            if (dr.Table.Columns.Contains("OrgPath"))
            {
                if (dr["OrgPath"] != DBNull.Value)
                {
                    this.OrgPath = (System.String)dr["OrgPath"];
                }
            }
            if (dr.Table.Columns.Contains("CommonCourseAmount"))
            {
                if (dr["CommonCourseAmount"] != DBNull.Value)
                {
                    this.CommonCourseAmount = (System.Decimal)dr["CommonCourseAmount"];
                }
            }
            if (dr.Table.Columns.Contains("SpecialCourseAmount"))
            {
                if (dr["SpecialCourseAmount"] != DBNull.Value)
                {
                    this.SpecialCourseAmount = (System.Decimal)dr["SpecialCourseAmount"];
                }
            }
            if (dr.Table.Columns.Contains("LeftAssetValue"))
            {
                if (dr["LeftAssetValue"] != DBNull.Value)
                {
                    this.LeftAssetValue = (System.Decimal)dr["LeftAssetValue"];
                }
            }
            if (dr.Table.Columns.Contains("TotalCourseAmount"))
            {
                if (dr["TotalCourseAmount"] != DBNull.Value)
                {
                    this.TotalCourseAmount = (System.Decimal)dr["TotalCourseAmount"];
                }
            }
            if (dr.Table.Columns.Contains("TotalOrderedCourseAmount"))
            {
                if (dr["TotalOrderedCourseAmount"] != DBNull.Value)
                {
                    this.TotalOrderedCourseAmount = (System.Decimal)dr["TotalOrderedCourseAmount"];
                }
            }
            if (dr.Table.Columns.Contains("TotalAssetCategory"))
            {
                if (dr["TotalAssetCategory"] != DBNull.Value)
                {
                    this.TotalAssetCategory = (System.Int32)dr["TotalAssetCategory"];
                }
            }
            if (dr.Table.Columns.Contains("LastCourseTime"))
            {
                if (dr["LastCourseTime"] != DBNull.Value)
                {
                    this.LastCourseTime = (System.DateTime)dr["LastCourseTime"];
                }
            }
            if (dr.Table.Columns.Contains("OperateTime"))
            {
                if (dr["OperateTime"] != DBNull.Value)
                {
                    this.OperateTime = (System.DateTime)dr["OperateTime"];
                }
            }
            if (dr.Table.Columns.Contains("ContractStatus"))
            {
                if (dr["ContractStatus"] != DBNull.Value)
                {
                    this.ContractStatus = (System.Int32)dr["ContractStatus"];
                }
            }
            if (dr.Table.Columns.Contains("PayStatus"))
            {
                if (dr["PayStatus"] != DBNull.Value)
                {
                    this.PayStatus = (System.Int32)dr["PayStatus"];
                }
            }
            if (dr.Table.Columns.Contains("ReturnTime"))
            {
                if (dr["ReturnTime"] != DBNull.Value)
                {
                    this.ReturnTime = (System.DateTime)dr["ReturnTime"];
                }
            }
            if (dr.Table.Columns.Contains("ReturnInfoItemCount"))
            {
                if (dr["ReturnInfoItemCount"] != DBNull.Value)
                {
                    this.ReturnInfoItemCount = (System.Int64)dr["ReturnInfoItemCount"];
                }
            }
            if (dr.Table.Columns.Contains("ProductType"))
            {
                if (dr["ProductType"] != DBNull.Value)
                {
                    this.ProductType = (System.Int32)dr["ProductType"];
                }
            }
            if (dr.Table.Columns.Contains("CallType"))
            {
                if (dr["CallType"] != DBNull.Value)
                {
                    this.CallType = (System.Int32)dr["CallType"];
                }
            }
            if (dr.Table.Columns.Contains("FromSys"))
            {
                if (dr["FromSys"] != DBNull.Value)
                {
                    this.FromSys = (System.Int32)dr["FromSys"];
                }
            }
            if (dr.Table.Columns.Contains("SourceInfo"))
            {
                if (dr["SourceInfo"] != DBNull.Value)
                {
                    this.SourceInfo = (System.Int64)dr["SourceInfo"];
                }
            }
            if (dr.Table.Columns.Contains("IsAssignTeacher"))
            {
                if (dr["IsAssignTeacher"] != DBNull.Value)
                {
                    this.IsAssignTeacher = (System.Int32)dr["IsAssignTeacher"];
                }
            }
            if (dr.Table.Columns.Contains("ContactType"))
            {
                if (dr["ContactType"] != DBNull.Value)
                {
                    this.ContactType = (System.Int32)dr["ContactType"];
                }
            }
            if (dr.Table.Columns.Contains("SignUpdateTime"))
            {
                if (dr["SignUpdateTime"] != DBNull.Value)
                {
                    this.SignUpdateTime = (System.DateTime)dr["SignUpdateTime"];
                }
            }
            if (dr.Table.Columns.Contains("FromSysID"))
            {
                if (dr["FromSysID"] != DBNull.Value)
                {
                    this.FromSysID = (System.Int64)dr["FromSysID"];
                }
            }
            if (dr.Table.Columns.Contains("OriginalFromSys"))
            {
                if (dr["OriginalFromSys"] != DBNull.Value)
                {
                    this.OriginalFromSys = (System.String)dr["OriginalFromSys"];
                }
            }
            if (dr.Table.Columns.Contains("StudentType"))
            {
                if (dr["StudentType"] != DBNull.Value)
                {
                    this.StudentType = (System.Int32)dr["StudentType"];
                }
            }
            if (dr.Table.Columns.Contains("TeachingPlaceID"))
            {
                if (dr["TeachingPlaceID"] != DBNull.Value)
                {
                    this.TeachingPlaceID = (System.Int64)dr["TeachingPlaceID"];
                }
            }
            if (dr.Table.Columns.Contains("TeachingPlaceName"))
            {
                if (dr["TeachingPlaceName"] != DBNull.Value)
                {
                    this.TeachingPlaceName = (System.String)dr["TeachingPlaceName"];
                }
            }
            if (dr.Table.Columns.Contains("InquiryPlaceID"))
            {
                if (dr["InquiryPlaceID"] != DBNull.Value)
                {
                    this.InquiryPlaceID = (System.Int64)dr["InquiryPlaceID"];
                }
            }
            if (dr.Table.Columns.Contains("InquiryPlaceName"))
            {
                if (dr["InquiryPlaceName"] != DBNull.Value)
                {
                    this.InquiryPlaceName = (System.String)dr["InquiryPlaceName"];
                }
            }
            if (dr.Table.Columns.Contains("SalePhase"))
            {
                if (dr["SalePhase"] != DBNull.Value)
                {
                    this.SalePhase = (System.Int32)dr["SalePhase"];
                }
            }
            if (dr.Table.Columns.Contains("AddressDetail"))
            {
                if (dr["AddressDetail"] != DBNull.Value)
                {
                    this.AddressDetail = (System.String)dr["AddressDetail"];
                }
            }
            if (dr.Table.Columns.Contains("PurchaseIntention"))
            {
                if (dr["PurchaseIntention"] != DBNull.Value)
                {
                    this.PurchaseIntention = (System.Int32)dr["PurchaseIntention"];
                }
            }
            if (dr.Table.Columns.Contains("NextReturnTime"))
            {
                if (dr["NextReturnTime"] != DBNull.Value)
                {
                    this.NextReturnTime = (System.DateTime)dr["NextReturnTime"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerType"))
            {
                if (dr["CustomerType"] != DBNull.Value)
                {
                    this.CustomerType = (System.Int32)dr["CustomerType"];
                }
            }
            if (dr.Table.Columns.Contains("SourceSignStaffName"))
            {
                if (dr["SourceSignStaffName"] != DBNull.Value)
                {
                    this.SourceSignStaffName = (System.String)dr["SourceSignStaffName"];
                }
            }
            if (dr.Table.Columns.Contains("FollowupNum"))
            {
                if (dr["FollowupNum"] != DBNull.Value)
                {
                    this.FollowupNum = (System.Int32)dr["FollowupNum"];
                }
            }
            if (dr.Table.Columns.Contains("SourceMainType"))
            {
                if (dr["SourceMainType"] != DBNull.Value)
                {
                    this.SourceMainType = (System.Int32)dr["SourceMainType"];
                }
            }
            if (dr.Table.Columns.Contains("SourceMainValue"))
            {
                if (dr["SourceMainValue"] != DBNull.Value)
                {
                    this.SourceMainValue = (System.String)dr["SourceMainValue"];
                }
            }
            if (dr.Table.Columns.Contains("SourceSubType"))
            {
                if (dr["SourceSubType"] != DBNull.Value)
                {
                    this.SourceSubType = (System.Int32)dr["SourceSubType"];
                }
            }
            if (dr.Table.Columns.Contains("SourceSubValue"))
            {
                if (dr["SourceSubValue"] != DBNull.Value)
                {
                    this.SourceSubValue = (System.String)dr["SourceSubValue"];
                }
            }
            if (dr.Table.Columns.Contains("InsertJobType"))
            {
                if (dr["InsertJobType"] != DBNull.Value)
                {
                    this.InsertJobType = (System.Int16)dr["InsertJobType"];
                }
            }
            if (dr.Table.Columns.Contains("InsertJobTypeName"))
            {
                if (dr["InsertJobTypeName"] != DBNull.Value)
                {
                    this.InsertJobTypeName = (System.String)dr["InsertJobTypeName"];
                }
            }
            if (dr.Table.Columns.Contains("LastFollowupTime"))
            {
                if (dr["LastFollowupTime"] != DBNull.Value)
                {
                    this.LastFollowupTime = (System.DateTime)dr["LastFollowupTime"];
                }
            }
            if (dr.Table.Columns.Contains("NextFollowupTime"))
            {
                if (dr["NextFollowupTime"] != DBNull.Value)
                {
                    this.NextFollowupTime = (System.DateTime)dr["NextFollowupTime"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerLevel"))
            {
                if (dr["CustomerLevel"] != DBNull.Value)
                {
                    this.CustomerLevel = (System.Int32)dr["CustomerLevel"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerMobile"))
            {
                if (dr["CustomerMobile"] != DBNull.Value)
                {
                    this.CustomerMobile = (System.String)dr["CustomerMobile"];
                }
            }
            if (dr.Table.Columns.Contains("InsertDepartID"))
            {
                if (dr["InsertDepartID"] != DBNull.Value)
                {
                    this.InsertDepartID = (System.Int64)dr["InsertDepartID"];
                }
            }
            if (dr.Table.Columns.Contains("InsertDepartName"))
            {
                if (dr["InsertDepartName"] != DBNull.Value)
                {
                    this.InsertDepartName = (System.String)dr["InsertDepartName"];
                }
            }
            if (dr.Table.Columns.Contains("ClassEndState"))
            {
                if (dr["ClassEndState"] != DBNull.Value)
                {
                    this.ClassEndState = (System.Int32)dr["ClassEndState"];
                }
            }
            if (dr.Table.Columns.Contains("ClassEndDate"))
            {
                if (dr["ClassEndDate"] != DBNull.Value)
                {
                    this.ClassEndDate = (System.DateTime)dr["ClassEndDate"];
                }
            }
            if (dr.Table.Columns.Contains("ReturnPrePassDate"))
            {
                if (dr["ReturnPrePassDate"] != DBNull.Value)
                {
                    this.ReturnPrePassDate = (System.DateTime)dr["ReturnPrePassDate"];
                }
            }
            if (dr.Table.Columns.Contains("LockType"))
            {
                if (dr["LockType"] != DBNull.Value)
                {
                    this.LockType = (System.Int32)dr["LockType"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerGroup"))
            {
                if (dr["CustomerGroup"] != DBNull.Value)
                {
                    this.CustomerGroup = (System.Int32)dr["CustomerGroup"];
                }
            }
            if (dr.Table.Columns.Contains("TelJobPassprotID"))
            {
                if (dr["TelJobPassprotID"] != DBNull.Value)
                {
                    this.TelJobPassprotID = (System.Int64)dr["TelJobPassprotID"];
                }
            }
            if (dr.Table.Columns.Contains("TelPassprotID"))
            {
                if (dr["TelPassprotID"] != DBNull.Value)
                {
                    this.TelPassprotID = (System.Int64)dr["TelPassprotID"];
                }
            }
            if (dr.Table.Columns.Contains("TelStaffName"))
            {
                if (dr["TelStaffName"] != DBNull.Value)
                {
                    this.TelStaffName = (System.String)dr["TelStaffName"];
                }
            }
            if (dr.Table.Columns.Contains("TelStaffID"))
            {
                if (dr["TelStaffID"] != DBNull.Value)
                {
                    this.TelStaffID = (System.Int64)dr["TelStaffID"];
                }
            }
            if (dr.Table.Columns.Contains("TelJobID"))
            {
                if (dr["TelJobID"] != DBNull.Value)
                {
                    this.TelJobID = (System.Int64)dr["TelJobID"];
                }
            }
            if (dr.Table.Columns.Contains("PotentialType"))
            {
                if (dr["PotentialType"] != DBNull.Value)
                {
                    this.PotentialType = (System.Int32)dr["PotentialType"];
                }
            }
            if (dr.Table.Columns.Contains("VipType"))
            {
                if (dr["VipType"] != DBNull.Value)
                {
                    this.VipType = (System.Int32)dr["VipType"];
                }
            }
            if (dr.Table.Columns.Contains("VipLevel"))
            {
                if (dr["VipLevel"] != DBNull.Value)
                {
                    this.VipLevel = (System.Int32)dr["VipLevel"];
                }
            }
            if (dr.Table.Columns.Contains("DataSourceType"))
            {
                if (dr["DataSourceType"] != DBNull.Value)
                {
                    this.DataSourceType = (System.Int32)dr["DataSourceType"];
                }
            }
            if (dr.Table.Columns.Contains("Pretreatment"))
            {
                if (dr["Pretreatment"] != DBNull.Value)
                {
                    this.Pretreatment = (System.Int32)dr["Pretreatment"];
                }
            }
            if (dr.Table.Columns.Contains("HasRelation"))
            {
                if (dr["HasRelation"] != DBNull.Value)
                {
                    this.HasRelation = (System.Int16)dr["HasRelation"];
                }
            }
            if (dr.Table.Columns.Contains("IsSubjectGroupSchool"))
            {
                if (dr["IsSubjectGroupSchool"] != DBNull.Value)
                {
                    this.IsSubjectGroupSchool = (System.Boolean)dr["IsSubjectGroupSchool"];
                }
            }
            if (dr.Table.Columns.Contains("IsAssignSubjectGroup"))
            {
                if (dr["IsAssignSubjectGroup"] != DBNull.Value)
                {
                    this.IsAssignSubjectGroup = (System.Boolean)dr["IsAssignSubjectGroup"];
                }
            }
            if (dr.Table.Columns.Contains("HasTeacher"))
            {
                if (dr["HasTeacher"] != DBNull.Value)
                {
                    this.HasTeacher = (System.Int16)dr["HasTeacher"];
                }
            }
            if (dr.Table.Columns.Contains("UnValidType"))
            {
                if (dr["UnValidType"] != DBNull.Value)
                {
                    this.UnValidType = (System.Int32)dr["UnValidType"];
                }
            }
            if (dr.Table.Columns.Contains("HasExam"))
            {
                if (dr["HasExam"] != DBNull.Value)
                {
                    this.HasExam = (System.Int16)dr["HasExam"];
                }
            }
            if (dr.Table.Columns.Contains("LastModified"))
            {
                if (dr["LastModified"] != DBNull.Value)
                {
                    this.LastModified = (System.Byte[])dr["LastModified"];
                }
            }
        }
    }
}