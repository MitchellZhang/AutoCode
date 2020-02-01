using System;
using PetaPoco;
namespace ZYL.Core.Model
{
   [TableName("THOA_Company")]
   [PrimaryKey("CompanyID", AutoIncrement=false)]
   public partial class THOA_Company
   {
      public Guid CompanyID { get; set; }
      public int ServiceID { get; set; }
      public string Version { get; set; }
      public int? CompanyAccount { get; set; }
      public string CompanyName { get; set; }
      public string CompanyIndustry { get; set; }
      public string Organization { get; set; }
      public string CompanyAddress { get; set; }
      public decimal? RegisteredCapital { get; set; }
      public DateTime? SetUpTime { get; set; }
      public string CompanyPhase { get; set; }
      public string CompanyUrl { get; set; }
      public string CompanyBigLogo { get; set; }
      public string CompanyHeadName { get; set; }
      public string CompanyPhone { get; set; }
      public string CompanyTelephone { get; set; }
      public string CompanyFax { get; set; }
      public string CompanyEmail { get; set; }
      public string CompanyWeChat { get; set; }
      public string CompanyQQ { get; set; }
      public string ComBLPic { get; set; }
      public string ComHeadPic { get; set; }
      public string ComHeadIDPic { get; set; }
      public DateTime? CreateTime { get; set; }
      public DateTime? LastTime { get; set; }
      public int? LoginTimes { get; set; }
      public int? OffLineDays { get; set; }
      public DateTime? Fee_Start { get; set; }
      public DateTime? Fee_End { get; set; }
      public string Fee { get; set; }
      public Guid? CreateID { get; set; }
      public DateTime? UpdateTime { get; set; }
      public Guid? UpdateID { get; set; }
      public string CompanyMinLogo { get; set; }
      public string Companyheadpos { get; set; }
      public string RegisteTime { get; set; }
      public decimal? Disk_Size { get; set; }
      public decimal? Used_Size { get; set; }
      public decimal? Free_DiskSize { get; set; }
      public int? RecommendID { get; set; }
      public string InviteCode { get; set; }
      public string JSflag { get; set; }
      public string NowState { get; set; }
      public string ComHeadIDcip { get; set; }
      public string PayPassword { get; set; }
      public string SortChar { get; set; }
      public string CoverPic { get; set; }
      public string Longitude { get; set; }
      public string Latitude { get; set; }
      public string LinkMan { get; set; }
      public string LinkPhone { get; set; }
      public Guid? Owner { get; set; }
      public string IsAgent { get; set; }
      public string Province { get; set; }
      public string City { get; set; }
      public string Area { get; set; }
      public string PID { get; set; }
      public string CID { get; set; }
      public string AID { get; set; }
      public string IsStandAloneVer { get; set; }
      public Guid? AgeID { get; set; }
      public Guid? BuyerID { get; set; }
      public bool? Question { get; set; }
      public bool? LB { get; set; }
      }
}
