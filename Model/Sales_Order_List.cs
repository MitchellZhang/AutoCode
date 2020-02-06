using System;
using PetaPoco;

namespace ZYL.Core.Model
{
   [Serializable]
   [TableName("Sales_Order_List")]
   [PrimaryKey("OrderID", AutoIncrement=false)]
   public partial class Sales_Order_List
   {
      /// <summary>
      /// 客户订单号
      /// </summary>
      public Guid OrderID { get; set; }
      /// <summary>
      /// 推送编号
      /// </summary>
      public string PushNum { get; set; }
      /// <summary>
      /// 订单编号
      /// </summary>
      public string Title { get; set; }
      /// <summary>
      /// 卖家公司ID(为个人卖家时存个人账号ID)
      /// </summary>
      public Guid ComID { get; set; }
      /// <summary>
      /// 客户ID
      /// </summary>
      public Guid? CustomID { get; set; }
      /// <summary>
      /// 客户名称
      /// </summary>
      public string CustomName { get; set; }
      /// <summary>
      /// 客户传真
      /// </summary>
      public string CusFax { get; set; }
      /// <summary>
      /// 客户企业EID,网上下单者的企业EID
      /// </summary>
      public int? EID { get; set; }
      /// <summary>
      /// 个人好友编号
      /// </summary>
      public int? FriendPId { get; set; }
      /// <summary>
      /// 好友类型0为企业好友，1为个人好友，当前为0时EId不能为空，FriendPId必为空，否则相反
      /// </summary>
      public string FriendType { get; set; }
      /// <summary>
      /// 产品要求
      /// </summary>
      public string DetailNote { get; set; }
      /// <summary>
      /// 支付方式
      /// </summary>
      public string PayType { get; set; }
      /// <summary>
      /// 送货方式
      /// </summary>
      public string SendType { get; set; }
      /// <summary>
      /// 运费
      /// </summary>
      public decimal? SendMoney { get; set; }
      /// <summary>
      /// 收货期限
      /// </summary>
      public DateTime? HarvestDate { get; set; }
      /// <summary>
      /// 送货地址
      /// </summary>
      public string SendAdress { get; set; }
      /// <summary>
      /// 发票类型
      /// </summary>
      public string BillType { get; set; }
      /// <summary>
      /// 纳税人识别码
      /// </summary>
      public string TaxpayersNumber { get; set; }
      /// <summary>
      /// 注册地址
      /// </summary>
      public string RegisterAddress { get; set; }
      /// <summary>
      /// 注册电话
      /// </summary>
      public string RegisterTel { get; set; }
      /// <summary>
      /// 合同附件路径
      /// </summary>
      public string ContractUrl { get; set; }
      /// <summary>
      /// 合同附件名
      /// </summary>
      public string ContractName { get; set; }
      /// <summary>
      /// 备注
      /// </summary>
      public string Note { get; set; }
      /// <summary>
      /// 订单来源:0录入订单，1报价下单，2网上订单，3商城下单，4微商城下单，5线下订单 6.系统升级订单,7秒杀，8拼团，9砍价（by ruby add 7,8,9 20180419 14:15 有跟zlh确认过，不会影响其它）,-1（by ls add 瑾琪课程订单标识） 10 续单 (by ruby 20180801 14:23)
      /// </summary>
      public string Orgin { get; set; }
      /// <summary>
      /// 订单状态:0未支付，1已支付待发货，2发货在途，3已签收，4线下已支付,5已申请退款（5 By ruby 20180503 10:55）,6退款成功（6 by LS 20180705 15:50）
      /// </summary>
      public string Status { get; set; }
      /// <summary>
      /// 订单创建者
      /// </summary>
      public Guid? CreateUser { get; set; }
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime? CreateDate { get; set; }
      /// <summary>
      /// 下单（付款）人(用于网上下单的客户)
      /// </summary>
      public Guid? OrderUser { get; set; }
      /// <summary>
      /// 下单(付款)时间
      /// </summary>
      public DateTime? OrderDate { get; set; }
      /// <summary>
      /// 供应商联系人
      /// </summary>
      public string SupLinkman { get; set; }
      /// <summary>
      /// 供应商联系电话
      /// </summary>
      public string SupLinkPhone { get; set; }
      /// <summary>
      /// 供应商传真
      /// </summary>
      public string SupFax { get; set; }
      /// <summary>
      /// 供应商ID
      /// </summary>
      public Guid? SupID { get; set; }
      /// <summary>
      /// 收获信息ID
      /// </summary>
      public Guid? ReceiveID { get; set; }
      /// <summary>
      /// 行动ID
      /// </summary>
      public Guid? ActionID { get; set; }
      /// <summary>
      /// 机会ID
      /// </summary>
      public Guid? OppID { get; set; }
      /// <summary>
      /// 报价ID
      /// </summary>
      public Guid? QuoID { get; set; }
      /// <summary>
      /// 意向ID
      /// </summary>
      public Guid? IntentID { get; set; }
      /// <summary>
      /// 订单标题
      /// </summary>
      public string OrderTitle { get; set; }
      /// <summary>
      /// 客户联系人
      /// </summary>
      public string CusLinkman { get; set; }
      /// <summary>
      /// 客户联系人电话
      /// </summary>
      public string CusLinkPhone { get; set; }
      /// <summary>
      /// 客户是否删除
      /// </summary>
      public int? CusDel { get; set; }
      /// <summary>
      /// 供应商是否删除
      /// </summary>
      public int? SupDel { get; set; }
      /// <summary>
      /// 物流单号
      /// </summary>
      public string Wldh { get; set; }
      /// <summary>
      ///  物流名称
      /// </summary>
      public string Wlmc { get; set; }
      /// <summary>
      /// 物流联系人
      /// </summary>
      public string Wllxr { get; set; }
      /// <summary>
      /// 物流联系电话
      /// </summary>
      public string Wlphone { get; set; }
      /// <summary>
      /// 物流寄件人
      /// </summary>
      public string Wljjr { get; set; }
      /// <summary>
      /// 寄件人电话
      /// </summary>
      public string Wljjdh { get; set; }
      /// <summary>
      /// 供应商名称
      /// </summary>
      public string SupName { get; set; }
      /// <summary>
      /// 合同记录主键ID
      /// </summary>
      public Guid? ContractID { get; set; }
      /// <summary>
      /// 合同编号
      /// </summary>
      public string ContractNo { get; set; }
      /// <summary>
      /// 合同开始日期
      /// </summary>
      public DateTime? ContractBeginTime { get; set; }
      /// <summary>
      /// 合同结束日期
      /// </summary>
      public DateTime? ContractEndTime { get; set; }
      /// <summary>
      /// 合同标题名称
      /// </summary>
      public string ContractTitle { get; set; }
      /// <summary>
      /// 发票单位名称
      /// </summary>
      public string BillComName { get; set; }
      /// <summary>
      /// 判断是否是线下订单进行查看
      /// </summary>
      public string offtype { get; set; }
      /// <summary>
      /// 线下订单控制
      /// </summary>
      public decimal? Percents { get; set; }
      /// <summary>
      /// 支付账号类型：0未支付，1企业支付，2个人支付
      /// </summary>
      public int? PayAccountType { get; set; }
      /// <summary>
      /// 发货时间
      /// </summary>
      public DateTime? DeliveryDate { get; set; }
      /// <summary>
      /// 签收收货时间
      /// </summary>
      public DateTime? SignclosedDate { get; set; }
      /// <summary>
      /// 优惠金额
      /// </summary>
      public decimal? DiscountMoney { get; set; }
      /// <summary>
      /// 订单金额（明细产品销售价*数量的和）
      /// </summary>
      public decimal? OrderAmount { get; set; }
      /// <summary>
      /// 店铺编号（by Ruby 20170518 15:30）
      /// </summary>
      public Guid? ShopId { get; set; }
      /// <summary>
      /// 推送店铺（By Ruby 20170518 15:30）
      /// </summary>
      public Guid? PushShopId { get; set; }
      /// <summary>
      /// 配送类型:1普通物流，2送货上门，3自提
      /// </summary>
      public string DeliveryType { get; set; }
      /// <summary>
      /// 配送方式详情JSON串
      /// </summary>
      public string DeliveryJson { get; set; }
      /// <summary>
      /// 优惠券领取记录Id -2017-09-13  ldw加
      /// </summary>
      public Guid? DrawId { get; set; }
      /// <summary>
      /// 消息显示端口:null为旧数据按旧逻辑捞取，'XP'为小程序 --20180207 ludo +
      /// </summary>
      public string ShowPort { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public Guid? SetDeskId { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string SetDeskName { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public int? DinersNumber { get; set; }
      /// <summary>
      /// 餐饮业，续单时，原来订单Id by ruby 20180801 14:22
      /// </summary>
      public string OldOrderId { get; set; }
      /// <summary>
      /// 子订单 Sales_Order_SubList 表
      /// </summary>
      public Guid? SubOrderId { get; set; }
      }
}
