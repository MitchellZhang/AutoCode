using System;
using PetaPoco;
namespace ZYL.Core.Model
{
   [TableName("Shop_P_Main")]
   [PrimaryKey("Id", AutoIncrement=false)]
   public partial class Shop_P_Main
   {
      public Guid Id { get; set; }
      public string ShopName { get; set; }
      public int ShopNo { get; set; }
      public int UpdateCount { get; set; }
      public DateTime? RegistDate { get; set; }
      public DateTime? IdenDate { get; set; }
      public string Idener { get; set; }
      public string IdenReason { get; set; }
      public Guid? ComId { get; set; }
      public string Logo { get; set; }
      public string QRCode { get; set; }
      public string Address { get; set; }
      public string Longitude { get; set; }
      public string Latitude { get; set; }
      public string Manager { get; set; }
      public string Telephone { get; set; }
      public Guid? DIYPictureId { get; set; }
      public string ClassType { get; set; }
      public string Type { get; set; }
      public string IsActive { get; set; }
      public string IsIden { get; set; }
      public string Remark { get; set; }
      public Guid? Owner { get; set; }
      public Guid? CreateId { get; set; }
      public DateTime? CreateTime { get; set; }
      public Guid? UpdateId { get; set; }
      public DateTime? UpdateTime { get; set; }
      public bool? IsDeleted { get; set; }
      public int? ViewNum { get; set; }
      public Guid? ShopType { get; set; }
      public Guid? BehandOwner { get; set; }
      public string ShopIntro { get; set; }
      public string ShopPic { get; set; }
      public string BusinessHours { get; set; }
      public string PID { get; set; }
      public string CID { get; set; }
      public string AID { get; set; }
      public string Province { get; set; }
      public string City { get; set; }
      public string Area { get; set; }
      public decimal? CouponRate { get; set; }
      public decimal? VoucherRate { get; set; }
      public decimal? DiscountRate { get; set; }
      public decimal? StarNum { get; set; }
      public string ShopDescHtml { get; set; }
      public string ShopIntropic { get; set; }
      public string ShopViewPic { get; set; }
      public int? IsShowSalesNum { get; set; }
      public int? IsDisable { get; set; }
      public Guid? AgeID { get; set; }
      public int? Proportion { get; set; }
      }
}
