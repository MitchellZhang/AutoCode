
using System;
using PetaPoco;

namespace ZYL.Core.Model
{
   [Serializable]
   [TableName("Shop_Fmcg_Store_RepositoryRelation")]
   [PrimaryKey("Id", AutoIncrement=false)]
   public partial class Shop_Fmcg_Store_RepositoryRelation
   {
   
      /// <summary>
      /// ID
      /// </summary>
      public Guid Id { get; set; }
   
      /// <summary>
      /// 门店ID（SHOP_FMCG_PURCHASERSTORE ID)
      /// </summary>
      public Guid? StoreId { get; set; }
   
      /// <summary>
      /// 该门店下独立的店铺ID（仓库店铺ID)
      /// </summary>
      public Guid? SubShopId { get; set; }
   
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime? CreateTime { get; set; }
   
      /// <summary>
      /// 创建ID
      /// </summary>
      public Guid? CreateId { get; set; }
   
      /// <summary>
      /// 更新时间
      /// </summary>
      public DateTime? UpdateTime { get; set; }
   
      /// <summary>
      /// 更新ID
      /// </summary>
      public Guid? UpdateId { get; set; }
   
      /// <summary>
      /// 是否删除
      /// </summary>
      public int? IsDel { get; set; }
   
   }
}
