using System;
using PetaPoco;

namespace ZYL.Core.Model
{
   [Serializable]
   [TableName("Shop_Product")]
   [PrimaryKey("Id", AutoIncrement=false)]
   public partial class Shop_Product
   {
      /// <summary>
      /// 店铺产品（来自本企业）
      /// </summary>
      public Guid Id { get; set; }
      /// <summary>
      /// 店铺编号
      /// </summary>
      public Guid? ShopId { get; set; }
      /// <summary>
      /// 产品编号
      /// </summary>
      public Guid? ProductId { get; set; }
      /// <summary>
      /// 产品名称
      /// </summary>
      public string ProductName { get; set; }
      /// <summary>
      /// 商城产品置顶次序，0或空默认的，1，2，3，。。N数值越大越靠前
      /// </summary>
      public int? TopOrderNo { get; set; }
      /// <summary>
      /// 店铺自定义产品类型Id(外键) by Ruby 20171212 17:50
      /// </summary>
      public Guid? ProductGroupId { get; set; }
      /// <summary>
      /// 是否微商城上架1，0下架 by Ruby 20171212 17:50
      /// </summary>
      public bool? IsPutOffSaleForShop { get; set; }
      /// <summary>
      /// 是否新零售平台上架1，0下架 by Ruby 20171212 17:50
      /// </summary>
      public bool? IsPutOffSaleForPlat { get; set; }
      /// <summary>
      /// 归属微商城（0不是，1是） by Ruby 20171212 17:50
      /// </summary>
      public bool? BelongForShop { get; set; }
      /// <summary>
      /// 归属新零售平台（0不是，1是） by Ruby 20171212 17:50
      /// </summary>
      public bool? BelongForPlat { get; set; }
      /// <summary>
      /// 三个以0（否）或1（是）的数字，中间以#号隔开：第一个数字代表是否置顶分类，第二个是否推荐首页，第三个是否推荐且置顶首页
      /// </summary>
      public string IsRecommendAndTop { get; set; }
      /// <summary>
      /// 登陆(数据归属)端口：TB或B。 ldw+ (暂时只有一种，以后若要扩展多种类型可以以逗号隔开)
      /// </summary>
      public string LoginPort { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string Remark { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public Guid? Owner { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public Guid? CreateId { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public DateTime? CreateTime { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public Guid? UpdateId { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public DateTime? UpdateTime { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public bool? IsDeleted { get; set; }
      /// <summary>
      /// 搜索条件热词标签
      /// </summary>
      public string KeyLable { get; set; }
      }
}
