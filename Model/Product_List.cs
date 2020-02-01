using System;
using PetaPoco;
namespace ZYL.Core.Model
{
   [TableName("Product_List")]
   [PrimaryKey("ProductID", AutoIncrement=false)]
   public partial class Product_List
   {
      public Guid ProductID { get; set; }
      public Guid ComID { get; set; }
      public string Name { get; set; }
      public decimal? PushPrice { get; set; }
      public decimal? Price { get; set; }
      public decimal? CostPrice { get; set; }
      public decimal? Prepayment { get; set; }
      public string Picture { get; set; }
      public string VideoUrl { get; set; }
      public string Description { get; set; }
      public DateTime? CreateDate { get; set; }
      public int? Stock { get; set; }
      public int? Sharetimes { get; set; }
      public int? PaymentTotal { get; set; }
      public int? SaleNum { get; set; }
      public decimal? Freight { get; set; }
      public Guid? ProductType { get; set; }
      public string BarCode { get; set; }
      public Guid? SMTemplateID { get; set; }
      public string LgtTemData { get; set; }
      public string IsIden { get; set; }
      public string Idener { get; set; }
      public DateTime? IdenDate { get; set; }
      public string IsPutOffSale { get; set; }
      public string IsDel { get; set; }
      public Guid? Type { get; set; }
      public string ProductNO { get; set; }
      public string Unit { get; set; }
      public string Material { get; set; }
      public string Color { get; set; }
      public string Weight { get; set; }
      public string StoreStyle { get; set; }
      public string PackStyle { get; set; }
      public string ShipStyle { get; set; }
      public string PackStandard { get; set; }
      public string License { get; set; }
      public string StoreTime { get; set; }
      public string Web { get; set; }
      public string Place { get; set; }
      public decimal? TaxPrice { get; set; }
      public string SalesType { get; set; }
      public Guid? OldProductID { get; set; }
      public string IsCompetor { get; set; }
      public string Import { get; set; }
      public string Picture2 { get; set; }
      public string Picture3 { get; set; }
      public string Picture4 { get; set; }
      public string PushID { get; set; }
      public string DescriptionJson { get; set; }
      public string ExtendJson { get; set; }
      public int? Khours { get; set; }
      public int? StudentNum { get; set; }
      public string StaID { get; set; }
      public int? ViewNum { get; set; }
      public string PriceMark { get; set; }
      public int? IsGainPoints { get; set; }
      public int? IsHasSku { get; set; }
      public string SharePosterJsonData { get; set; }
      public string SharePosterDiyPic { get; set; }
      public string ShareTitle { get; set; }
      public string ShareCoverImage { get; set; }
      public int? IsShareReward { get; set; }
      public decimal? ShareRewardFee { get; set; }
      public int? IsLimitedDeliver { get; set; }
      public int? DeliverDistance { get; set; }
      public int? ProductSort { get; set; }
      public Guid? ExpressType { get; set; }
      public string ExpressContent { get; set; }
      public int? IsUseNewExpress { get; set; }
      }
}
