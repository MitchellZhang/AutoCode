
using System;
using PetaPoco;

namespace ZYL.Core.Model
{
   [Serializable]
   [TableName("Shop_Module_Operation")]
   [PrimaryKey("Id", AutoIncrement=false)]
   public partial class Shop_Module_Operation
   {
   
      /// <summary>
      /// ID
      /// </summary>
      public Guid Id { get; set; }
   
      /// <summary>
      /// 操作类型名
      /// </summary>
      public string TypeName { get; set; }
   
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
   
      /// <summary>
      /// 店铺ID
      /// </summary>
      public Guid? ShopId { get; set; }
   
      /// <summary>
      /// 编号  不同的店铺 存在相同的编号
      /// </summary>
      public int? Number { get; set; }
   
   }
}
