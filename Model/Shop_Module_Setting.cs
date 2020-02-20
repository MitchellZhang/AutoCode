
using System;
using PetaPoco;

namespace ZYL.Core.Model
{
   [Serializable]
   [TableName("Shop_Module_Setting")]
   [PrimaryKey("Id", AutoIncrement=false)]
   public partial class Shop_Module_Setting
   {
   
      /// <summary>
      /// 模块ID
      /// </summary>
      public Guid Id { get; set; }
   
      /// <summary>
      /// 店铺ID
      /// </summary>
      public Guid? ShopId { get; set; }
   
      /// <summary>
      /// 版本ID
      /// </summary>
      public string Version { get; set; }
   
      /// <summary>
      /// 父级模块ID
      /// </summary>
      public Guid? ParentId { get; set; }
   
      /// <summary>
      /// 模块名称
      /// </summary>
      public string Name { get; set; }
   
      /// <summary>
      /// 前端路由
      /// </summary>
      public string RouteUrl { get; set; }
   
      /// <summary>
      /// 前端图标
      /// </summary>
      public string IconUrl { get; set; }
   
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime? CreateTime { get; set; }
   
      /// <summary>
      /// 创建ID
      /// </summary>
      public Guid? CreateId { get; set; }
   
      /// <summary>
      /// 是否删除
      /// </summary>
      public int? IsDel { get; set; }
   
      /// <summary>
      /// 排序
      /// </summary>
      public int? Sort { get; set; }
   
      /// <summary>
      /// 模块类型 0 或 Null是属于B端，1 属于C端模块
      /// </summary>
      public int? OriginType { get; set; }
   
   }
}
