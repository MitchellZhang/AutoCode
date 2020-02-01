using System;
using PetaPoco;
namespace ZYL.Core.Model
{
   [TableName("Shop_Product")]
   [PrimaryKey("Id", AutoIncrement=false)]
   public partial class Shop_Product
   {
      public Guid Id { get; set; }
      public Guid? ShopId { get; set; }
      public Guid? ProductId { get; set; }
      public string ProductName { get; set; }
      public int? TopOrderNo { get; set; }
      public Guid? ProductGroupId { get; set; }
      public bool? IsPutOffSaleForShop { get; set; }
      public bool? IsPutOffSaleForPlat { get; set; }
      public bool? BelongForShop { get; set; }
      public bool? BelongForPlat { get; set; }
      public string IsRecommendAndTop { get; set; }
      public string LoginPort { get; set; }
      public string Remark { get; set; }
      public Guid? Owner { get; set; }
      public Guid? CreateId { get; set; }
      public DateTime? CreateTime { get; set; }
      public Guid? UpdateId { get; set; }
      public DateTime? UpdateTime { get; set; }
      public bool? IsDeleted { get; set; }
      public string KeyLable { get; set; }
      }
}
