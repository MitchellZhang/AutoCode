
using System;
using PetaPoco;

namespace ZYL.Core.Model
{
   [Serializable]
   [TableName("Shop_Module_Setting_Operation")]
   [PrimaryKey("Id", AutoIncrement=false)]
   public partial class Shop_Module_Setting_Operation
   {
   
      /// <summary>
      /// ID
      /// </summary>
      public Guid Id { get; set; }
   
      /// <summary>
      /// 模块ID
      /// </summary>
      public Guid? ModuleId { get; set; }
   
      /// <summary>
      /// 操作类型
      /// </summary>
      public Guid? OperaType { get; set; }
   
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
