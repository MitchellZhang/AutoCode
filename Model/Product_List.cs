using System;
using PetaPoco;

namespace ZYL.Core.Model
{
   [Serializable]
   [TableName("Product_List")]
   [PrimaryKey("ProductID", AutoIncrement=false)]
   public partial class Product_List
   {
      /// <summary>
      /// 产品ID
      /// </summary>
      public Guid ProductID { get; set; }
      /// <summary>
      /// 公司ID或个人ID
      /// </summary>
      public Guid ComID { get; set; }
      /// <summary>
      /// 产品名称
      /// </summary>
      public string Name { get; set; }
      /// <summary>
      /// 临时推送价(售价)
      /// </summary>
      public decimal? PushPrice { get; set; }
      /// <summary>
      /// 参考售价(指导价/原价)
      /// </summary>
      public decimal? Price { get; set; }
      /// <summary>
      /// 成本价(会员价)
      /// </summary>
      public decimal? CostPrice { get; set; }
      /// <summary>
      /// 预支付(定金)
      /// </summary>
      public decimal? Prepayment { get; set; }
      /// <summary>
      /// 图片路径集合,中间以逗号隔开
      /// </summary>
      public string Picture { get; set; }
      /// <summary>
      /// 视频路径
      /// </summary>
      public string VideoUrl { get; set; }
      /// <summary>
      /// 产品描述
      /// </summary>
      public string Description { get; set; }
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime? CreateDate { get; set; }
      /// <summary>
      /// 商品库存
      /// </summary>
      public int? Stock { get; set; }
      /// <summary>
      /// 分享次数
      /// </summary>
      public int? Sharetimes { get; set; }
      /// <summary>
      /// 销售量，从销售订单明细表而来，每次付成功后进行累加+1，暂时没有更详细约束（人，时控制），就是成功就加  by Ruby 20170815
      /// </summary>
      public int? PaymentTotal { get; set; }
      /// <summary>
      /// 付款人数，从销售订单明细表而来，每次付成功后进行累加+Amount by Ruby 20170815
      /// </summary>
      public int? SaleNum { get; set; }
      /// <summary>
      /// 运费
      /// </summary>
      public decimal? Freight { get; set; }
      /// <summary>
      /// 产品类型：  跟sys_producttype表相关联  
      /// </summary>
      public Guid? ProductType { get; set; }
      /// <summary>
      /// 商品条码-20171227 ldw+
      /// </summary>
      public string BarCode { get; set; }
      /// <summary>
      /// 运费模板ID -2017-07-04 ldw加
      /// </summary>
      public Guid? SMTemplateID { get; set; }
      /// <summary>
      /// 物流模板，1普通物流，2同城配送，3自提；sjon数据格式：[{type:1,id:''},...]
      /// </summary>
      public string LgtTemData { get; set; }
      /// <summary>
      /// 是否认证(0未认证，1商家已认证，2审核中，3认证失败)
      /// </summary>
      public string IsIden { get; set; }
      /// <summary>
      /// 认证审核者
      /// </summary>
      public string Idener { get; set; }
      /// <summary>
      /// 认证时间
      /// </summary>
      public DateTime? IdenDate { get; set; }
      /// <summary>
      /// 是否下架：0或null（旧数据）为上架，1下架
      /// </summary>
      public string IsPutOffSale { get; set; }
      /// <summary>
      /// 0或者null 不删除，1：删除
      /// </summary>
      public string IsDel { get; set; }
      /// <summary>
      /// 产品类型
      /// </summary>
      public Guid? Type { get; set; }
      /// <summary>
      /// 产品型号
      /// </summary>
      public string ProductNO { get; set; }
      /// <summary>
      /// 单位
      /// </summary>
      public string Unit { get; set; }
      /// <summary>
      /// 产品材质
      /// </summary>
      public string Material { get; set; }
      /// <summary>
      /// 产品颜色
      /// </summary>
      public string Color { get; set; }
      /// <summary>
      /// 净重
      /// </summary>
      public string Weight { get; set; }
      /// <summary>
      /// 储存方式
      /// </summary>
      public string StoreStyle { get; set; }
      /// <summary>
      /// 包装方式
      /// </summary>
      public string PackStyle { get; set; }
      /// <summary>
      /// 运送方式
      /// </summary>
      public string ShipStyle { get; set; }
      /// <summary>
      /// 包装规格
      /// </summary>
      public string PackStandard { get; set; }
      /// <summary>
      /// 生产许可证号
      /// </summary>
      public string License { get; set; }
      /// <summary>
      /// 保质期
      /// </summary>
      public string StoreTime { get; set; }
      /// <summary>
      /// 网址
      /// </summary>
      public string Web { get; set; }
      /// <summary>
      /// 产品产地
      /// </summary>
      public string Place { get; set; }
      /// <summary>
      /// 含税价
      /// </summary>
      public decimal? TaxPrice { get; set; }
      /// <summary>
      /// 销售属性：1销售类、2采购类、3共有
      /// </summary>
      public string SalesType { get; set; }
      /// <summary>
      /// 来源于供货商商品导入创建的
      /// </summary>
      public Guid? OldProductID { get; set; }
      /// <summary>
      /// 是否竞品
      /// </summary>
      public string IsCompetor { get; set; }
      /// <summary>
      /// 是否从FreeMall_Product导入的数据：1是，否则不是 20170704 ldw加
      /// </summary>
      public string Import { get; set; }
      /// <summary>
      /// 图二  -已废弃字段
      /// </summary>
      public string Picture2 { get; set; }
      /// <summary>
      /// 图三-已废弃字段
      /// </summary>
      public string Picture3 { get; set; }
      /// <summary>
      /// 图四-已废弃字段
      /// </summary>
      public string Picture4 { get; set; }
      /// <summary>
      /// 此字段已废，但为了保证之前代码不会报错，重新添加
      /// </summary>
      public string PushID { get; set; }
      /// <summary>
      /// 产品详情JSON串，小程序
      /// </summary>
      public string DescriptionJson { get; set; }
      /// <summary>
      /// 扩展json,例： {"RecommendReason":"推荐理由","BuyNotes":"购买须知",...}
      /// </summary>
      public string ExtendJson { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public int? Khours { get; set; }
      /// <summary>
      /// 课程人数上限  2018.7.5 LS新增字段
      /// </summary>
      public int? StudentNum { get; set; }
      /// <summary>
      /// StaID校区ID(用#号隔开)   2018.7.5 LS新增字段
      /// </summary>
      public string StaID { get; set; }
      /// <summary>
      /// 浏览量，简单记录
      /// </summary>
      public int? ViewNum { get; set; }
      /// <summary>
      /// 价格标签 如：会员价，VIP价等
      /// </summary>
      public string PriceMark { get; set; }
      /// <summary>
      /// 是否可获取商家积分联盟积分，0否，1是
      /// </summary>
      public int? IsGainPoints { get; set; }
      /// <summary>
      /// 是否有多规格，0否，1是
      /// </summary>
      public int? IsHasSku { get; set; }
      /// <summary>
      /// 商品分享自定义海报保存的海报用的JSON数据
      /// </summary>
      public string SharePosterJsonData { get; set; }
      /// <summary>
      /// 商品分享自定义海报最终对应保存的图片文件路径
      /// </summary>
      public string SharePosterDiyPic { get; set; }
      /// <summary>
      /// 商品在小程序中分享时自定义的文本标题
      /// </summary>
      public string ShareTitle { get; set; }
      /// <summary>
      /// 商品在小程序中分享出去时自定义的封面展示图片
      /// </summary>
      public string ShareCoverImage { get; set; }
      /// <summary>
      /// 是否参与分享返现 1 参与，0 或 null 不参与
      /// </summary>
      public int? IsShareReward { get; set; }
      /// <summary>
      /// 分享返现金额
      /// </summary>
      public decimal? ShareRewardFee { get; set; }
      /// <summary>
      /// 是否启用配送距离限制 1 启用，0 或 null 不启用
      /// </summary>
      public int? IsLimitedDeliver { get; set; }
      /// <summary>
      /// 配送范围上限，单位：米
      /// </summary>
      public int? DeliverDistance { get; set; }
      /// <summary>
      /// 产品排序，序号大的排在前面
      /// </summary>
      public int? ProductSort { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public Guid? ExpressType { get; set; }
      /// <summary>
      /// 运费类型对应的配送方式内容 1、快递-> 包邮 填 0，到付 填 0，统一运费 填运费金额，模板 填模板Id 2、门店自提 不填 3、送货上门 不填
      /// </summary>
      public string ExpressContent { get; set; }
      /// <summary>
      /// 是否使用新的运费模板 0 或 null 默认旧的，1 表示使用新的模板
      /// </summary>
      public int? IsUseNewExpress { get; set; }
      }
}
