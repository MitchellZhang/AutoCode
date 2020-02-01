using System;
using PetaPoco;
namespace ZYL.Core.Model
{
   [TableName("THOA_Company_Age")]
   [PrimaryKey("CompanyID", AutoIncrement=false)]
   public partial class THOA_Company_Age
   {
      public Guid CompanyID { get; set; }
      public int? ServiceID { get; set; }
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
      public string AccRedit { get; set; }
      }
}
