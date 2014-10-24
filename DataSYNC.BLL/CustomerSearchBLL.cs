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
    public static partial class CustomerSearchBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudCustomer");


        public static List<CustomerSearch> Search(string sqlStr, params SqlParameter[] parameters)
        {
            List<CustomerSearch> list = new List<CustomerSearch>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        CustomerSearch model = new CustomerSearch(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(CustomerSearch model)
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



            if (model.CustomerID != null)
            {
                fileds.Add("[CustomerID]");
                pFileds.Add("@CustomerID");
                pms.Add(new SqlParameter("CustomerID", model.CustomerID));
            }


            if (model.CustomerPassportID != null)
            {
                fileds.Add("[CustomerPassportID]");
                pFileds.Add("@CustomerPassportID");
                pms.Add(new SqlParameter("CustomerPassportID", model.CustomerPassportID));
            }


            if (model.CustomerCode != null)
            {
                fileds.Add("[CustomerCode]");
                pFileds.Add("@CustomerCode");
                pms.Add(new SqlParameter("CustomerCode", model.CustomerCode));
            }


            if (model.CustomerName != null)
            {
                fileds.Add("[CustomerName]");
                pFileds.Add("@CustomerName");
                pms.Add(new SqlParameter("CustomerName", model.CustomerName));
            }


            if (model.CustomerUserID != null)
            {
                fileds.Add("[CustomerUserID]");
                pFileds.Add("@CustomerUserID");
                pms.Add(new SqlParameter("CustomerUserID", model.CustomerUserID));
            }


            if (model.CustomerUserName != null)
            {
                fileds.Add("[CustomerUserName]");
                pFileds.Add("@CustomerUserName");
                pms.Add(new SqlParameter("CustomerUserName", model.CustomerUserName));
            }


            if (model.FullPinyin != null)
            {
                fileds.Add("[FullPinyin]");
                pFileds.Add("@FullPinyin");
                pms.Add(new SqlParameter("FullPinyin", model.FullPinyin));
            }


            if (model.SimplePinyin != null)
            {
                fileds.Add("[SimplePinyin]");
                pFileds.Add("@SimplePinyin");
                pms.Add(new SqlParameter("SimplePinyin", model.SimplePinyin));
            }


            if (model.Gender != null)
            {
                fileds.Add("[Gender]");
                pFileds.Add("@Gender");
                pms.Add(new SqlParameter("Gender", model.Gender));
            }


            if (model.Birthday != null && model.Birthday != new DateTime())
            {
                fileds.Add("[Birthday]");
                pFileds.Add("@Birthday");
                pms.Add(new SqlParameter("Birthday", model.Birthday));
            }


            if (model.CurSchoolID != null)
            {
                fileds.Add("[CurSchoolID]");
                pFileds.Add("@CurSchoolID");
                pms.Add(new SqlParameter("CurSchoolID", model.CurSchoolID));
            }


            if (model.CurSchoolName != null)
            {
                fileds.Add("[CurSchoolName]");
                pFileds.Add("@CurSchoolName");
                pms.Add(new SqlParameter("CurSchoolName", model.CurSchoolName));
            }


            if (model.Grade != null)
            {
                fileds.Add("[Grade]");
                pFileds.Add("@Grade");
                pms.Add(new SqlParameter("Grade", model.Grade));
            }


            if (model.PriParentName != null)
            {
                fileds.Add("[PriParentName]");
                pFileds.Add("@PriParentName");
                pms.Add(new SqlParameter("PriParentName", model.PriParentName));
            }


            if (model.PriParentID != null)
            {
                fileds.Add("[PriParentID]");
                pFileds.Add("@PriParentID");
                pms.Add(new SqlParameter("PriParentID", model.PriParentID));
            }


            if (model.PriParentMobile != null)
            {
                fileds.Add("[PriParentMobile]");
                pFileds.Add("@PriParentMobile");
                pms.Add(new SqlParameter("PriParentMobile", model.PriParentMobile));
            }


            if (model.AllParents != null)
            {
                fileds.Add("[AllParents]");
                pFileds.Add("@AllParents");
                pms.Add(new SqlParameter("AllParents", model.AllParents));
            }


            if (model.InquiryUserID != null)
            {
                fileds.Add("[InquiryUserID]");
                pFileds.Add("@InquiryUserID");
                pms.Add(new SqlParameter("InquiryUserID", model.InquiryUserID));
            }


            if (model.InquiryUserName != null)
            {
                fileds.Add("[InquiryUserName]");
                pFileds.Add("@InquiryUserName");
                pms.Add(new SqlParameter("InquiryUserName", model.InquiryUserName));
            }


            if (model.InquiryStaffID != null)
            {
                fileds.Add("[InquiryStaffID]");
                pFileds.Add("@InquiryStaffID");
                pms.Add(new SqlParameter("InquiryStaffID", model.InquiryStaffID));
            }


            if (model.InquiryPassportID != null)
            {
                fileds.Add("[InquiryPassportID]");
                pFileds.Add("@InquiryPassportID");
                pms.Add(new SqlParameter("InquiryPassportID", model.InquiryPassportID));
            }


            if (model.InquiryJobPassportID != null)
            {
                fileds.Add("[InquiryJobPassportID]");
                pFileds.Add("@InquiryJobPassportID");
                pms.Add(new SqlParameter("InquiryJobPassportID", model.InquiryJobPassportID));
            }


            if (model.ManagerStaffID != null)
            {
                fileds.Add("[ManagerStaffID]");
                pFileds.Add("@ManagerStaffID");
                pms.Add(new SqlParameter("ManagerStaffID", model.ManagerStaffID));
            }


            if (model.ManagerPassportID != null)
            {
                fileds.Add("[ManagerPassportID]");
                pFileds.Add("@ManagerPassportID");
                pms.Add(new SqlParameter("ManagerPassportID", model.ManagerPassportID));
            }


            if (model.ManagerJobPassportID != null)
            {
                fileds.Add("[ManagerJobPassportID]");
                pFileds.Add("@ManagerJobPassportID");
                pms.Add(new SqlParameter("ManagerJobPassportID", model.ManagerJobPassportID));
            }


            if (model.ManagerUserID != null)
            {
                fileds.Add("[ManagerUserID]");
                pFileds.Add("@ManagerUserID");
                pms.Add(new SqlParameter("ManagerUserID", model.ManagerUserID));
            }


            if (model.ManagerName != null)
            {
                fileds.Add("[ManagerName]");
                pFileds.Add("@ManagerName");
                pms.Add(new SqlParameter("ManagerName", model.ManagerName));
            }


            if (model.InsertStaffID != null)
            {
                fileds.Add("[InsertStaffID]");
                pFileds.Add("@InsertStaffID");
                pms.Add(new SqlParameter("InsertStaffID", model.InsertStaffID));
            }


            if (model.InsertUserID != null)
            {
                fileds.Add("[InsertUserID]");
                pFileds.Add("@InsertUserID");
                pms.Add(new SqlParameter("InsertUserID", model.InsertUserID));
            }


            if (model.InsertPassportID != null)
            {
                fileds.Add("[InsertPassportID]");
                pFileds.Add("@InsertPassportID");
                pms.Add(new SqlParameter("InsertPassportID", model.InsertPassportID));
            }


            if (model.InsertStaffName != null)
            {
                fileds.Add("[InsertStaffName]");
                pFileds.Add("@InsertStaffName");
                pms.Add(new SqlParameter("InsertStaffName", model.InsertStaffName));
            }


            if (model.InsertJobID != null)
            {
                fileds.Add("[InsertJobID]");
                pFileds.Add("@InsertJobID");
                pms.Add(new SqlParameter("InsertJobID", model.InsertJobID));
            }


            if (model.InsertJobName != null)
            {
                fileds.Add("[InsertJobName]");
                pFileds.Add("@InsertJobName");
                pms.Add(new SqlParameter("InsertJobName", model.InsertJobName));
            }


            if (model.InsertJobPassportID != null)
            {
                fileds.Add("[InsertJobPassportID]");
                pFileds.Add("@InsertJobPassportID");
                pms.Add(new SqlParameter("InsertJobPassportID", model.InsertJobPassportID));
            }


            if (model.Status != null)
            {
                fileds.Add("[Status]");
                pFileds.Add("@Status");
                pms.Add(new SqlParameter("Status", model.Status));
            }


            if (model.AssetStatus != null)
            {
                fileds.Add("[AssetStatus]");
                pFileds.Add("@AssetStatus");
                pms.Add(new SqlParameter("AssetStatus", model.AssetStatus));
            }


            if (model.InsertTime != null && model.InsertTime != new DateTime())
            {
                fileds.Add("[InsertTime]");
                pFileds.Add("@InsertTime");
                pms.Add(new SqlParameter("InsertTime", model.InsertTime));
            }


            if (model.BranchID != null)
            {
                fileds.Add("[BranchID]");
                pFileds.Add("@BranchID");
                pms.Add(new SqlParameter("BranchID", model.BranchID));
            }


            if (model.BranchName != null)
            {
                fileds.Add("[BranchName]");
                pFileds.Add("@BranchName");
                pms.Add(new SqlParameter("BranchName", model.BranchName));
            }


            if (model.BranchShortName != null)
            {
                fileds.Add("[BranchShortName]");
                pFileds.Add("@BranchShortName");
                pms.Add(new SqlParameter("BranchShortName", model.BranchShortName));
            }


            if (model.XDSchoolID != null)
            {
                fileds.Add("[XDSchoolID]");
                pFileds.Add("@XDSchoolID");
                pms.Add(new SqlParameter("XDSchoolID", model.XDSchoolID));
            }


            if (model.XDSchoolName != null)
            {
                fileds.Add("[XDSchoolName]");
                pFileds.Add("@XDSchoolName");
                pms.Add(new SqlParameter("XDSchoolName", model.XDSchoolName));
            }


            if (model.XDSchoolShortName != null)
            {
                fileds.Add("[XDSchoolShortName]");
                pFileds.Add("@XDSchoolShortName");
                pms.Add(new SqlParameter("XDSchoolShortName", model.XDSchoolShortName));
            }


            if (model.HostID != null)
            {
                fileds.Add("[HostID]");
                pFileds.Add("@HostID");
                pms.Add(new SqlParameter("HostID", model.HostID));
            }


            if (model.Mobile1 != null)
            {
                fileds.Add("[Mobile1]");
                pFileds.Add("@Mobile1");
                pms.Add(new SqlParameter("Mobile1", model.Mobile1));
            }


            if (model.City != null)
            {
                fileds.Add("[City]");
                pFileds.Add("@City");
                pms.Add(new SqlParameter("City", model.City));
            }


            if (model.OrgID != null)
            {
                fileds.Add("[OrgID]");
                pFileds.Add("@OrgID");
                pms.Add(new SqlParameter("OrgID", model.OrgID));
            }


            if (model.OrgPath != null)
            {
                fileds.Add("[OrgPath]");
                pFileds.Add("@OrgPath");
                pms.Add(new SqlParameter("OrgPath", model.OrgPath));
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


            if (model.LeftAssetValue != null)
            {
                fileds.Add("[LeftAssetValue]");
                pFileds.Add("@LeftAssetValue");
                pms.Add(new SqlParameter("LeftAssetValue", model.LeftAssetValue));
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


            if (model.TotalAssetCategory != null)
            {
                fileds.Add("[TotalAssetCategory]");
                pFileds.Add("@TotalAssetCategory");
                pms.Add(new SqlParameter("TotalAssetCategory", model.TotalAssetCategory));
            }


            if (model.LastCourseTime != null && model.LastCourseTime != new DateTime())
            {
                fileds.Add("[LastCourseTime]");
                pFileds.Add("@LastCourseTime");
                pms.Add(new SqlParameter("LastCourseTime", model.LastCourseTime));
            }


            if (model.OperateTime != null && model.OperateTime != new DateTime())
            {
                fileds.Add("[OperateTime]");
                pFileds.Add("@OperateTime");
                pms.Add(new SqlParameter("OperateTime", model.OperateTime));
            }


            if (model.ContractStatus != null)
            {
                fileds.Add("[ContractStatus]");
                pFileds.Add("@ContractStatus");
                pms.Add(new SqlParameter("ContractStatus", model.ContractStatus));
            }


            if (model.PayStatus != null)
            {
                fileds.Add("[PayStatus]");
                pFileds.Add("@PayStatus");
                pms.Add(new SqlParameter("PayStatus", model.PayStatus));
            }


            if (model.ReturnTime != null && model.ReturnTime != new DateTime())
            {
                fileds.Add("[ReturnTime]");
                pFileds.Add("@ReturnTime");
                pms.Add(new SqlParameter("ReturnTime", model.ReturnTime));
            }


            if (model.ReturnInfoItemCount != null)
            {
                fileds.Add("[ReturnInfoItemCount]");
                pFileds.Add("@ReturnInfoItemCount");
                pms.Add(new SqlParameter("ReturnInfoItemCount", model.ReturnInfoItemCount));
            }


            if (model.ProductType != null)
            {
                fileds.Add("[ProductType]");
                pFileds.Add("@ProductType");
                pms.Add(new SqlParameter("ProductType", model.ProductType));
            }


            if (model.CallType != null)
            {
                fileds.Add("[CallType]");
                pFileds.Add("@CallType");
                pms.Add(new SqlParameter("CallType", model.CallType));
            }


            if (model.FromSys != null)
            {
                fileds.Add("[FromSys]");
                pFileds.Add("@FromSys");
                pms.Add(new SqlParameter("FromSys", model.FromSys));
            }


            if (model.SourceInfo != null)
            {
                fileds.Add("[SourceInfo]");
                pFileds.Add("@SourceInfo");
                pms.Add(new SqlParameter("SourceInfo", model.SourceInfo));
            }


            if (model.IsAssignTeacher != null)
            {
                fileds.Add("[IsAssignTeacher]");
                pFileds.Add("@IsAssignTeacher");
                pms.Add(new SqlParameter("IsAssignTeacher", model.IsAssignTeacher));
            }


            if (model.ContactType != null)
            {
                fileds.Add("[ContactType]");
                pFileds.Add("@ContactType");
                pms.Add(new SqlParameter("ContactType", model.ContactType));
            }


            if (model.SignUpdateTime != null && model.SignUpdateTime != new DateTime())
            {
                fileds.Add("[SignUpdateTime]");
                pFileds.Add("@SignUpdateTime");
                pms.Add(new SqlParameter("SignUpdateTime", model.SignUpdateTime));
            }


            if (model.FromSysID != null)
            {
                fileds.Add("[FromSysID]");
                pFileds.Add("@FromSysID");
                pms.Add(new SqlParameter("FromSysID", model.FromSysID));
            }


            if (model.OriginalFromSys != null)
            {
                fileds.Add("[OriginalFromSys]");
                pFileds.Add("@OriginalFromSys");
                pms.Add(new SqlParameter("OriginalFromSys", model.OriginalFromSys));
            }


            if (model.StudentType != null)
            {
                fileds.Add("[StudentType]");
                pFileds.Add("@StudentType");
                pms.Add(new SqlParameter("StudentType", model.StudentType));
            }


            if (model.TeachingPlaceID != null)
            {
                fileds.Add("[TeachingPlaceID]");
                pFileds.Add("@TeachingPlaceID");
                pms.Add(new SqlParameter("TeachingPlaceID", model.TeachingPlaceID));
            }


            if (model.TeachingPlaceName != null)
            {
                fileds.Add("[TeachingPlaceName]");
                pFileds.Add("@TeachingPlaceName");
                pms.Add(new SqlParameter("TeachingPlaceName", model.TeachingPlaceName));
            }


            if (model.InquiryPlaceID != null)
            {
                fileds.Add("[InquiryPlaceID]");
                pFileds.Add("@InquiryPlaceID");
                pms.Add(new SqlParameter("InquiryPlaceID", model.InquiryPlaceID));
            }


            if (model.InquiryPlaceName != null)
            {
                fileds.Add("[InquiryPlaceName]");
                pFileds.Add("@InquiryPlaceName");
                pms.Add(new SqlParameter("InquiryPlaceName", model.InquiryPlaceName));
            }


            if (model.SalePhase != null)
            {
                fileds.Add("[SalePhase]");
                pFileds.Add("@SalePhase");
                pms.Add(new SqlParameter("SalePhase", model.SalePhase));
            }


            if (model.AddressDetail != null)
            {
                fileds.Add("[AddressDetail]");
                pFileds.Add("@AddressDetail");
                pms.Add(new SqlParameter("AddressDetail", model.AddressDetail));
            }


            if (model.PurchaseIntention != null)
            {
                fileds.Add("[PurchaseIntention]");
                pFileds.Add("@PurchaseIntention");
                pms.Add(new SqlParameter("PurchaseIntention", model.PurchaseIntention));
            }


            if (model.NextReturnTime != null && model.NextReturnTime != new DateTime())
            {
                fileds.Add("[NextReturnTime]");
                pFileds.Add("@NextReturnTime");
                pms.Add(new SqlParameter("NextReturnTime", model.NextReturnTime));
            }


            if (model.CustomerType != null)
            {
                fileds.Add("[CustomerType]");
                pFileds.Add("@CustomerType");
                pms.Add(new SqlParameter("CustomerType", model.CustomerType));
            }


            if (model.SourceSignStaffName != null)
            {
                fileds.Add("[SourceSignStaffName]");
                pFileds.Add("@SourceSignStaffName");
                pms.Add(new SqlParameter("SourceSignStaffName", model.SourceSignStaffName));
            }


            if (model.FollowupNum != null)
            {
                fileds.Add("[FollowupNum]");
                pFileds.Add("@FollowupNum");
                pms.Add(new SqlParameter("FollowupNum", model.FollowupNum));
            }


            if (model.SourceMainType != null)
            {
                fileds.Add("[SourceMainType]");
                pFileds.Add("@SourceMainType");
                pms.Add(new SqlParameter("SourceMainType", model.SourceMainType));
            }


            if (model.SourceMainValue != null)
            {
                fileds.Add("[SourceMainValue]");
                pFileds.Add("@SourceMainValue");
                pms.Add(new SqlParameter("SourceMainValue", model.SourceMainValue));
            }


            if (model.SourceSubType != null)
            {
                fileds.Add("[SourceSubType]");
                pFileds.Add("@SourceSubType");
                pms.Add(new SqlParameter("SourceSubType", model.SourceSubType));
            }


            if (model.SourceSubValue != null)
            {
                fileds.Add("[SourceSubValue]");
                pFileds.Add("@SourceSubValue");
                pms.Add(new SqlParameter("SourceSubValue", model.SourceSubValue));
            }


            if (model.InsertJobType != null)
            {
                fileds.Add("[InsertJobType]");
                pFileds.Add("@InsertJobType");
                pms.Add(new SqlParameter("InsertJobType", model.InsertJobType));
            }


            if (model.InsertJobTypeName != null)
            {
                fileds.Add("[InsertJobTypeName]");
                pFileds.Add("@InsertJobTypeName");
                pms.Add(new SqlParameter("InsertJobTypeName", model.InsertJobTypeName));
            }


            if (model.LastFollowupTime != null && model.LastFollowupTime != new DateTime())
            {
                fileds.Add("[LastFollowupTime]");
                pFileds.Add("@LastFollowupTime");
                pms.Add(new SqlParameter("LastFollowupTime", model.LastFollowupTime));
            }


            if (model.NextFollowupTime != null && model.NextFollowupTime != new DateTime())
            {
                fileds.Add("[NextFollowupTime]");
                pFileds.Add("@NextFollowupTime");
                pms.Add(new SqlParameter("NextFollowupTime", model.NextFollowupTime));
            }


            if (model.CustomerLevel != null)
            {
                fileds.Add("[CustomerLevel]");
                pFileds.Add("@CustomerLevel");
                pms.Add(new SqlParameter("CustomerLevel", model.CustomerLevel));
            }


            if (model.CustomerMobile != null)
            {
                fileds.Add("[CustomerMobile]");
                pFileds.Add("@CustomerMobile");
                pms.Add(new SqlParameter("CustomerMobile", model.CustomerMobile));
            }


            if (model.InsertDepartID != null)
            {
                fileds.Add("[InsertDepartID]");
                pFileds.Add("@InsertDepartID");
                pms.Add(new SqlParameter("InsertDepartID", model.InsertDepartID));
            }


            if (model.InsertDepartName != null)
            {
                fileds.Add("[InsertDepartName]");
                pFileds.Add("@InsertDepartName");
                pms.Add(new SqlParameter("InsertDepartName", model.InsertDepartName));
            }


            if (model.ClassEndState != null)
            {
                fileds.Add("[ClassEndState]");
                pFileds.Add("@ClassEndState");
                pms.Add(new SqlParameter("ClassEndState", model.ClassEndState));
            }


            if (model.ClassEndDate != null && model.ClassEndDate != new DateTime())
            {
                fileds.Add("[ClassEndDate]");
                pFileds.Add("@ClassEndDate");
                pms.Add(new SqlParameter("ClassEndDate", model.ClassEndDate));
            }


            if (model.ReturnPrePassDate != null && model.ReturnPrePassDate != new DateTime())
            {
                fileds.Add("[ReturnPrePassDate]");
                pFileds.Add("@ReturnPrePassDate");
                pms.Add(new SqlParameter("ReturnPrePassDate", model.ReturnPrePassDate));
            }


            if (model.LockType != null)
            {
                fileds.Add("[LockType]");
                pFileds.Add("@LockType");
                pms.Add(new SqlParameter("LockType", model.LockType));
            }


            if (model.CustomerGroup != null)
            {
                fileds.Add("[CustomerGroup]");
                pFileds.Add("@CustomerGroup");
                pms.Add(new SqlParameter("CustomerGroup", model.CustomerGroup));
            }


            if (model.TelJobPassprotID != null)
            {
                fileds.Add("[TelJobPassprotID]");
                pFileds.Add("@TelJobPassprotID");
                pms.Add(new SqlParameter("TelJobPassprotID", model.TelJobPassprotID));
            }


            if (model.TelPassprotID != null)
            {
                fileds.Add("[TelPassprotID]");
                pFileds.Add("@TelPassprotID");
                pms.Add(new SqlParameter("TelPassprotID", model.TelPassprotID));
            }


            if (model.TelStaffName != null)
            {
                fileds.Add("[TelStaffName]");
                pFileds.Add("@TelStaffName");
                pms.Add(new SqlParameter("TelStaffName", model.TelStaffName));
            }


            if (model.TelStaffID != null)
            {
                fileds.Add("[TelStaffID]");
                pFileds.Add("@TelStaffID");
                pms.Add(new SqlParameter("TelStaffID", model.TelStaffID));
            }


            if (model.TelJobID != null)
            {
                fileds.Add("[TelJobID]");
                pFileds.Add("@TelJobID");
                pms.Add(new SqlParameter("TelJobID", model.TelJobID));
            }


            if (model.PotentialType != null)
            {
                fileds.Add("[PotentialType]");
                pFileds.Add("@PotentialType");
                pms.Add(new SqlParameter("PotentialType", model.PotentialType));
            }


            if (model.VipType != null)
            {
                fileds.Add("[VipType]");
                pFileds.Add("@VipType");
                pms.Add(new SqlParameter("VipType", model.VipType));
            }


            if (model.VipLevel != null)
            {
                fileds.Add("[VipLevel]");
                pFileds.Add("@VipLevel");
                pms.Add(new SqlParameter("VipLevel", model.VipLevel));
            }


            if (model.DataSourceType != null)
            {
                fileds.Add("[DataSourceType]");
                pFileds.Add("@DataSourceType");
                pms.Add(new SqlParameter("DataSourceType", model.DataSourceType));
            }


            if (model.Pretreatment != null)
            {
                fileds.Add("[Pretreatment]");
                pFileds.Add("@Pretreatment");
                pms.Add(new SqlParameter("Pretreatment", model.Pretreatment));
            }


            if (model.HasRelation != null)
            {
                fileds.Add("[HasRelation]");
                pFileds.Add("@HasRelation");
                pms.Add(new SqlParameter("HasRelation", model.HasRelation));
            }


            if (model.IsSubjectGroupSchool != null)
            {
                fileds.Add("[IsSubjectGroupSchool]");
                pFileds.Add("@IsSubjectGroupSchool");
                pms.Add(new SqlParameter("IsSubjectGroupSchool", model.IsSubjectGroupSchool));
            }


            if (model.IsAssignSubjectGroup != null)
            {
                fileds.Add("[IsAssignSubjectGroup]");
                pFileds.Add("@IsAssignSubjectGroup");
                pms.Add(new SqlParameter("IsAssignSubjectGroup", model.IsAssignSubjectGroup));
            }


            if (model.HasTeacher != null)
            {
                fileds.Add("[HasTeacher]");
                pFileds.Add("@HasTeacher");
                pms.Add(new SqlParameter("HasTeacher", model.HasTeacher));
            }


            if (model.UnValidType != null)
            {
                fileds.Add("[UnValidType]");
                pFileds.Add("@UnValidType");
                pms.Add(new SqlParameter("UnValidType", model.UnValidType));
            }


            if (model.HasExam != null)
            {
                fileds.Add("[HasExam]");
                pFileds.Add("@HasExam");
                pms.Add(new SqlParameter("HasExam", model.HasExam));
            }


            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO CustomerSearch (");
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

        public static bool Update(CustomerSearch model)
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

            if (model.CustomerID != null)
            {
                fileds.Add("[CustomerID]=@CustomerID");
                pms.Add(new SqlParameter("CustomerID", model.CustomerID));
            }

            if (model.CustomerPassportID != null)
            {
                fileds.Add("[CustomerPassportID]=@CustomerPassportID");
                pms.Add(new SqlParameter("CustomerPassportID", model.CustomerPassportID));
            }

            if (model.CustomerCode != null)
            {
                fileds.Add("[CustomerCode]=@CustomerCode");
                pms.Add(new SqlParameter("CustomerCode", model.CustomerCode));
            }

            if (model.CustomerName != null)
            {
                fileds.Add("[CustomerName]=@CustomerName");
                pms.Add(new SqlParameter("CustomerName", model.CustomerName));
            }

            if (model.CustomerUserID != null)
            {
                fileds.Add("[CustomerUserID]=@CustomerUserID");
                pms.Add(new SqlParameter("CustomerUserID", model.CustomerUserID));
            }

            if (model.CustomerUserName != null)
            {
                fileds.Add("[CustomerUserName]=@CustomerUserName");
                pms.Add(new SqlParameter("CustomerUserName", model.CustomerUserName));
            }

            if (model.FullPinyin != null)
            {
                fileds.Add("[FullPinyin]=@FullPinyin");
                pms.Add(new SqlParameter("FullPinyin", model.FullPinyin));
            }

            if (model.SimplePinyin != null)
            {
                fileds.Add("[SimplePinyin]=@SimplePinyin");
                pms.Add(new SqlParameter("SimplePinyin", model.SimplePinyin));
            }

            if (model.Gender != null)
            {
                fileds.Add("[Gender]=@Gender");
                pms.Add(new SqlParameter("Gender", model.Gender));
            }

            if (model.Birthday != null && model.Birthday != new DateTime())
            {
                fileds.Add("[Birthday]=@Birthday");
                pms.Add(new SqlParameter("Birthday", model.Birthday));
            }

            if (model.CurSchoolID != null)
            {
                fileds.Add("[CurSchoolID]=@CurSchoolID");
                pms.Add(new SqlParameter("CurSchoolID", model.CurSchoolID));
            }

            if (model.CurSchoolName != null)
            {
                fileds.Add("[CurSchoolName]=@CurSchoolName");
                pms.Add(new SqlParameter("CurSchoolName", model.CurSchoolName));
            }

            if (model.Grade != null)
            {
                fileds.Add("[Grade]=@Grade");
                pms.Add(new SqlParameter("Grade", model.Grade));
            }

            if (model.PriParentName != null)
            {
                fileds.Add("[PriParentName]=@PriParentName");
                pms.Add(new SqlParameter("PriParentName", model.PriParentName));
            }

            if (model.PriParentID != null)
            {
                fileds.Add("[PriParentID]=@PriParentID");
                pms.Add(new SqlParameter("PriParentID", model.PriParentID));
            }

            if (model.PriParentMobile != null)
            {
                fileds.Add("[PriParentMobile]=@PriParentMobile");
                pms.Add(new SqlParameter("PriParentMobile", model.PriParentMobile));
            }

            if (model.AllParents != null)
            {
                fileds.Add("[AllParents]=@AllParents");
                pms.Add(new SqlParameter("AllParents", model.AllParents));
            }

            if (model.InquiryUserID != null)
            {
                fileds.Add("[InquiryUserID]=@InquiryUserID");
                pms.Add(new SqlParameter("InquiryUserID", model.InquiryUserID));
            }

            if (model.InquiryUserName != null)
            {
                fileds.Add("[InquiryUserName]=@InquiryUserName");
                pms.Add(new SqlParameter("InquiryUserName", model.InquiryUserName));
            }

            if (model.InquiryStaffID != null)
            {
                fileds.Add("[InquiryStaffID]=@InquiryStaffID");
                pms.Add(new SqlParameter("InquiryStaffID", model.InquiryStaffID));
            }

            if (model.InquiryPassportID != null)
            {
                fileds.Add("[InquiryPassportID]=@InquiryPassportID");
                pms.Add(new SqlParameter("InquiryPassportID", model.InquiryPassportID));
            }

            if (model.InquiryJobPassportID != null)
            {
                fileds.Add("[InquiryJobPassportID]=@InquiryJobPassportID");
                pms.Add(new SqlParameter("InquiryJobPassportID", model.InquiryJobPassportID));
            }

            if (model.ManagerStaffID != null)
            {
                fileds.Add("[ManagerStaffID]=@ManagerStaffID");
                pms.Add(new SqlParameter("ManagerStaffID", model.ManagerStaffID));
            }

            if (model.ManagerPassportID != null)
            {
                fileds.Add("[ManagerPassportID]=@ManagerPassportID");
                pms.Add(new SqlParameter("ManagerPassportID", model.ManagerPassportID));
            }

            if (model.ManagerJobPassportID != null)
            {
                fileds.Add("[ManagerJobPassportID]=@ManagerJobPassportID");
                pms.Add(new SqlParameter("ManagerJobPassportID", model.ManagerJobPassportID));
            }

            if (model.ManagerUserID != null)
            {
                fileds.Add("[ManagerUserID]=@ManagerUserID");
                pms.Add(new SqlParameter("ManagerUserID", model.ManagerUserID));
            }

            if (model.ManagerName != null)
            {
                fileds.Add("[ManagerName]=@ManagerName");
                pms.Add(new SqlParameter("ManagerName", model.ManagerName));
            }

            if (model.InsertStaffID != null)
            {
                fileds.Add("[InsertStaffID]=@InsertStaffID");
                pms.Add(new SqlParameter("InsertStaffID", model.InsertStaffID));
            }

            if (model.InsertUserID != null)
            {
                fileds.Add("[InsertUserID]=@InsertUserID");
                pms.Add(new SqlParameter("InsertUserID", model.InsertUserID));
            }

            if (model.InsertPassportID != null)
            {
                fileds.Add("[InsertPassportID]=@InsertPassportID");
                pms.Add(new SqlParameter("InsertPassportID", model.InsertPassportID));
            }

            if (model.InsertStaffName != null)
            {
                fileds.Add("[InsertStaffName]=@InsertStaffName");
                pms.Add(new SqlParameter("InsertStaffName", model.InsertStaffName));
            }

            if (model.InsertJobID != null)
            {
                fileds.Add("[InsertJobID]=@InsertJobID");
                pms.Add(new SqlParameter("InsertJobID", model.InsertJobID));
            }

            if (model.InsertJobName != null)
            {
                fileds.Add("[InsertJobName]=@InsertJobName");
                pms.Add(new SqlParameter("InsertJobName", model.InsertJobName));
            }

            if (model.InsertJobPassportID != null)
            {
                fileds.Add("[InsertJobPassportID]=@InsertJobPassportID");
                pms.Add(new SqlParameter("InsertJobPassportID", model.InsertJobPassportID));
            }

            if (model.Status != null)
            {
                fileds.Add("[Status]=@Status");
                pms.Add(new SqlParameter("Status", model.Status));
            }

            if (model.AssetStatus != null)
            {
                fileds.Add("[AssetStatus]=@AssetStatus");
                pms.Add(new SqlParameter("AssetStatus", model.AssetStatus));
            }

            if (model.InsertTime != null && model.InsertTime != new DateTime())
            {
                fileds.Add("[InsertTime]=@InsertTime");
                pms.Add(new SqlParameter("InsertTime", model.InsertTime));
            }

            if (model.BranchID != null)
            {
                fileds.Add("[BranchID]=@BranchID");
                pms.Add(new SqlParameter("BranchID", model.BranchID));
            }

            if (model.BranchName != null)
            {
                fileds.Add("[BranchName]=@BranchName");
                pms.Add(new SqlParameter("BranchName", model.BranchName));
            }

            if (model.BranchShortName != null)
            {
                fileds.Add("[BranchShortName]=@BranchShortName");
                pms.Add(new SqlParameter("BranchShortName", model.BranchShortName));
            }

            if (model.XDSchoolID != null)
            {
                fileds.Add("[XDSchoolID]=@XDSchoolID");
                pms.Add(new SqlParameter("XDSchoolID", model.XDSchoolID));
            }

            if (model.XDSchoolName != null)
            {
                fileds.Add("[XDSchoolName]=@XDSchoolName");
                pms.Add(new SqlParameter("XDSchoolName", model.XDSchoolName));
            }

            if (model.XDSchoolShortName != null)
            {
                fileds.Add("[XDSchoolShortName]=@XDSchoolShortName");
                pms.Add(new SqlParameter("XDSchoolShortName", model.XDSchoolShortName));
            }

            if (model.HostID != null)
            {
                fileds.Add("[HostID]=@HostID");
                pms.Add(new SqlParameter("HostID", model.HostID));
            }

            if (model.Mobile1 != null)
            {
                fileds.Add("[Mobile1]=@Mobile1");
                pms.Add(new SqlParameter("Mobile1", model.Mobile1));
            }

            if (model.City != null)
            {
                fileds.Add("[City]=@City");
                pms.Add(new SqlParameter("City", model.City));
            }

            if (model.OrgID != null)
            {
                fileds.Add("[OrgID]=@OrgID");
                pms.Add(new SqlParameter("OrgID", model.OrgID));
            }

            if (model.OrgPath != null)
            {
                fileds.Add("[OrgPath]=@OrgPath");
                pms.Add(new SqlParameter("OrgPath", model.OrgPath));
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

            if (model.LeftAssetValue != null)
            {
                fileds.Add("[LeftAssetValue]=@LeftAssetValue");
                pms.Add(new SqlParameter("LeftAssetValue", model.LeftAssetValue));
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

            if (model.TotalAssetCategory != null)
            {
                fileds.Add("[TotalAssetCategory]=@TotalAssetCategory");
                pms.Add(new SqlParameter("TotalAssetCategory", model.TotalAssetCategory));
            }

            if (model.LastCourseTime != null && model.LastCourseTime != new DateTime())
            {
                fileds.Add("[LastCourseTime]=@LastCourseTime");
                pms.Add(new SqlParameter("LastCourseTime", model.LastCourseTime));
            }

            if (model.OperateTime != null && model.OperateTime != new DateTime())
            {
                fileds.Add("[OperateTime]=@OperateTime");
                pms.Add(new SqlParameter("OperateTime", model.OperateTime));
            }

            if (model.ContractStatus != null)
            {
                fileds.Add("[ContractStatus]=@ContractStatus");
                pms.Add(new SqlParameter("ContractStatus", model.ContractStatus));
            }

            if (model.PayStatus != null)
            {
                fileds.Add("[PayStatus]=@PayStatus");
                pms.Add(new SqlParameter("PayStatus", model.PayStatus));
            }

            if (model.ReturnTime != null && model.ReturnTime != new DateTime())
            {
                fileds.Add("[ReturnTime]=@ReturnTime");
                pms.Add(new SqlParameter("ReturnTime", model.ReturnTime));
            }

            if (model.ReturnInfoItemCount != null)
            {
                fileds.Add("[ReturnInfoItemCount]=@ReturnInfoItemCount");
                pms.Add(new SqlParameter("ReturnInfoItemCount", model.ReturnInfoItemCount));
            }

            if (model.ProductType != null)
            {
                fileds.Add("[ProductType]=@ProductType");
                pms.Add(new SqlParameter("ProductType", model.ProductType));
            }

            if (model.CallType != null)
            {
                fileds.Add("[CallType]=@CallType");
                pms.Add(new SqlParameter("CallType", model.CallType));
            }

            if (model.FromSys != null)
            {
                fileds.Add("[FromSys]=@FromSys");
                pms.Add(new SqlParameter("FromSys", model.FromSys));
            }

            if (model.SourceInfo != null)
            {
                fileds.Add("[SourceInfo]=@SourceInfo");
                pms.Add(new SqlParameter("SourceInfo", model.SourceInfo));
            }

            if (model.IsAssignTeacher != null)
            {
                fileds.Add("[IsAssignTeacher]=@IsAssignTeacher");
                pms.Add(new SqlParameter("IsAssignTeacher", model.IsAssignTeacher));
            }

            if (model.ContactType != null)
            {
                fileds.Add("[ContactType]=@ContactType");
                pms.Add(new SqlParameter("ContactType", model.ContactType));
            }

            if (model.SignUpdateTime != null && model.SignUpdateTime != new DateTime())
            {
                fileds.Add("[SignUpdateTime]=@SignUpdateTime");
                pms.Add(new SqlParameter("SignUpdateTime", model.SignUpdateTime));
            }

            if (model.FromSysID != null)
            {
                fileds.Add("[FromSysID]=@FromSysID");
                pms.Add(new SqlParameter("FromSysID", model.FromSysID));
            }

            if (model.OriginalFromSys != null)
            {
                fileds.Add("[OriginalFromSys]=@OriginalFromSys");
                pms.Add(new SqlParameter("OriginalFromSys", model.OriginalFromSys));
            }

            if (model.StudentType != null)
            {
                fileds.Add("[StudentType]=@StudentType");
                pms.Add(new SqlParameter("StudentType", model.StudentType));
            }

            if (model.TeachingPlaceID != null)
            {
                fileds.Add("[TeachingPlaceID]=@TeachingPlaceID");
                pms.Add(new SqlParameter("TeachingPlaceID", model.TeachingPlaceID));
            }

            if (model.TeachingPlaceName != null)
            {
                fileds.Add("[TeachingPlaceName]=@TeachingPlaceName");
                pms.Add(new SqlParameter("TeachingPlaceName", model.TeachingPlaceName));
            }

            if (model.InquiryPlaceID != null)
            {
                fileds.Add("[InquiryPlaceID]=@InquiryPlaceID");
                pms.Add(new SqlParameter("InquiryPlaceID", model.InquiryPlaceID));
            }

            if (model.InquiryPlaceName != null)
            {
                fileds.Add("[InquiryPlaceName]=@InquiryPlaceName");
                pms.Add(new SqlParameter("InquiryPlaceName", model.InquiryPlaceName));
            }

            if (model.SalePhase != null)
            {
                fileds.Add("[SalePhase]=@SalePhase");
                pms.Add(new SqlParameter("SalePhase", model.SalePhase));
            }

            if (model.AddressDetail != null)
            {
                fileds.Add("[AddressDetail]=@AddressDetail");
                pms.Add(new SqlParameter("AddressDetail", model.AddressDetail));
            }

            if (model.PurchaseIntention != null)
            {
                fileds.Add("[PurchaseIntention]=@PurchaseIntention");
                pms.Add(new SqlParameter("PurchaseIntention", model.PurchaseIntention));
            }

            if (model.NextReturnTime != null && model.NextReturnTime != new DateTime())
            {
                fileds.Add("[NextReturnTime]=@NextReturnTime");
                pms.Add(new SqlParameter("NextReturnTime", model.NextReturnTime));
            }

            if (model.CustomerType != null)
            {
                fileds.Add("[CustomerType]=@CustomerType");
                pms.Add(new SqlParameter("CustomerType", model.CustomerType));
            }

            if (model.SourceSignStaffName != null)
            {
                fileds.Add("[SourceSignStaffName]=@SourceSignStaffName");
                pms.Add(new SqlParameter("SourceSignStaffName", model.SourceSignStaffName));
            }

            if (model.FollowupNum != null)
            {
                fileds.Add("[FollowupNum]=@FollowupNum");
                pms.Add(new SqlParameter("FollowupNum", model.FollowupNum));
            }

            if (model.SourceMainType != null)
            {
                fileds.Add("[SourceMainType]=@SourceMainType");
                pms.Add(new SqlParameter("SourceMainType", model.SourceMainType));
            }

            if (model.SourceMainValue != null)
            {
                fileds.Add("[SourceMainValue]=@SourceMainValue");
                pms.Add(new SqlParameter("SourceMainValue", model.SourceMainValue));
            }

            if (model.SourceSubType != null)
            {
                fileds.Add("[SourceSubType]=@SourceSubType");
                pms.Add(new SqlParameter("SourceSubType", model.SourceSubType));
            }

            if (model.SourceSubValue != null)
            {
                fileds.Add("[SourceSubValue]=@SourceSubValue");
                pms.Add(new SqlParameter("SourceSubValue", model.SourceSubValue));
            }

            if (model.InsertJobType != null)
            {
                fileds.Add("[InsertJobType]=@InsertJobType");
                pms.Add(new SqlParameter("InsertJobType", model.InsertJobType));
            }

            if (model.InsertJobTypeName != null)
            {
                fileds.Add("[InsertJobTypeName]=@InsertJobTypeName");
                pms.Add(new SqlParameter("InsertJobTypeName", model.InsertJobTypeName));
            }

            if (model.LastFollowupTime != null && model.LastFollowupTime != new DateTime())
            {
                fileds.Add("[LastFollowupTime]=@LastFollowupTime");
                pms.Add(new SqlParameter("LastFollowupTime", model.LastFollowupTime));
            }

            if (model.NextFollowupTime != null && model.NextFollowupTime != new DateTime())
            {
                fileds.Add("[NextFollowupTime]=@NextFollowupTime");
                pms.Add(new SqlParameter("NextFollowupTime", model.NextFollowupTime));
            }

            if (model.CustomerLevel != null)
            {
                fileds.Add("[CustomerLevel]=@CustomerLevel");
                pms.Add(new SqlParameter("CustomerLevel", model.CustomerLevel));
            }

            if (model.CustomerMobile != null)
            {
                fileds.Add("[CustomerMobile]=@CustomerMobile");
                pms.Add(new SqlParameter("CustomerMobile", model.CustomerMobile));
            }

            if (model.InsertDepartID != null)
            {
                fileds.Add("[InsertDepartID]=@InsertDepartID");
                pms.Add(new SqlParameter("InsertDepartID", model.InsertDepartID));
            }

            if (model.InsertDepartName != null)
            {
                fileds.Add("[InsertDepartName]=@InsertDepartName");
                pms.Add(new SqlParameter("InsertDepartName", model.InsertDepartName));
            }

            if (model.ClassEndState != null)
            {
                fileds.Add("[ClassEndState]=@ClassEndState");
                pms.Add(new SqlParameter("ClassEndState", model.ClassEndState));
            }

            if (model.ClassEndDate != null && model.ClassEndDate != new DateTime())
            {
                fileds.Add("[ClassEndDate]=@ClassEndDate");
                pms.Add(new SqlParameter("ClassEndDate", model.ClassEndDate));
            }

            if (model.ReturnPrePassDate != null && model.ReturnPrePassDate != new DateTime())
            {
                fileds.Add("[ReturnPrePassDate]=@ReturnPrePassDate");
                pms.Add(new SqlParameter("ReturnPrePassDate", model.ReturnPrePassDate));
            }

            if (model.LockType != null)
            {
                fileds.Add("[LockType]=@LockType");
                pms.Add(new SqlParameter("LockType", model.LockType));
            }

            if (model.CustomerGroup != null)
            {
                fileds.Add("[CustomerGroup]=@CustomerGroup");
                pms.Add(new SqlParameter("CustomerGroup", model.CustomerGroup));
            }

            if (model.TelJobPassprotID != null)
            {
                fileds.Add("[TelJobPassprotID]=@TelJobPassprotID");
                pms.Add(new SqlParameter("TelJobPassprotID", model.TelJobPassprotID));
            }

            if (model.TelPassprotID != null)
            {
                fileds.Add("[TelPassprotID]=@TelPassprotID");
                pms.Add(new SqlParameter("TelPassprotID", model.TelPassprotID));
            }

            if (model.TelStaffName != null)
            {
                fileds.Add("[TelStaffName]=@TelStaffName");
                pms.Add(new SqlParameter("TelStaffName", model.TelStaffName));
            }

            if (model.TelStaffID != null)
            {
                fileds.Add("[TelStaffID]=@TelStaffID");
                pms.Add(new SqlParameter("TelStaffID", model.TelStaffID));
            }

            if (model.TelJobID != null)
            {
                fileds.Add("[TelJobID]=@TelJobID");
                pms.Add(new SqlParameter("TelJobID", model.TelJobID));
            }

            if (model.PotentialType != null)
            {
                fileds.Add("[PotentialType]=@PotentialType");
                pms.Add(new SqlParameter("PotentialType", model.PotentialType));
            }

            if (model.VipType != null)
            {
                fileds.Add("[VipType]=@VipType");
                pms.Add(new SqlParameter("VipType", model.VipType));
            }

            if (model.VipLevel != null)
            {
                fileds.Add("[VipLevel]=@VipLevel");
                pms.Add(new SqlParameter("VipLevel", model.VipLevel));
            }

            if (model.DataSourceType != null)
            {
                fileds.Add("[DataSourceType]=@DataSourceType");
                pms.Add(new SqlParameter("DataSourceType", model.DataSourceType));
            }

            if (model.Pretreatment != null)
            {
                fileds.Add("[Pretreatment]=@Pretreatment");
                pms.Add(new SqlParameter("Pretreatment", model.Pretreatment));
            }

            if (model.HasRelation != null)
            {
                fileds.Add("[HasRelation]=@HasRelation");
                pms.Add(new SqlParameter("HasRelation", model.HasRelation));
            }

            if (model.IsSubjectGroupSchool != null)
            {
                fileds.Add("[IsSubjectGroupSchool]=@IsSubjectGroupSchool");
                pms.Add(new SqlParameter("IsSubjectGroupSchool", model.IsSubjectGroupSchool));
            }

            if (model.IsAssignSubjectGroup != null)
            {
                fileds.Add("[IsAssignSubjectGroup]=@IsAssignSubjectGroup");
                pms.Add(new SqlParameter("IsAssignSubjectGroup", model.IsAssignSubjectGroup));
            }

            if (model.HasTeacher != null)
            {
                fileds.Add("[HasTeacher]=@HasTeacher");
                pms.Add(new SqlParameter("HasTeacher", model.HasTeacher));
            }

            if (model.UnValidType != null)
            {
                fileds.Add("[UnValidType]=@UnValidType");
                pms.Add(new SqlParameter("UnValidType", model.UnValidType));
            }

            if (model.HasExam != null)
            {
                fileds.Add("[HasExam]=@HasExam");
                pms.Add(new SqlParameter("HasExam", model.HasExam));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update CustomerSearch set ");
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

        public static bool Save(CustomerSearch model)
        {
            object obj = db.ExecuteScalar(CommandType.Text, "select count(1) from CustomerSearch where Gid='" + model.Gid + "'");
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