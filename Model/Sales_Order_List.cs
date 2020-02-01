using System;
using PetaPoco;
namespace ZYL.Core.Model
{
   [TableName("Sales_Order_List")]
   [PrimaryKey("OrderID", AutoIncrement=false)]
   public partial class Sales_Order_List
   {
      public Guid OrderID { get; set; }
      public string PushNum { get; set; }
      public string Title { get; set; }
      public Guid ComID { get; set; }
      public Guid? CustomID { get; set; }
      public string CustomName { get; set; }
      public string CusFax { get; set; }
      public int? EID { get; set; }
      public int? FriendPId { get; set; }
      public string FriendType { get; set; }
      public string DetailNote { get; set; }
      public string PayType { get; set; }
      public string SendType { get; set; }
      public decimal? SendMoney { get; set; }
      public DateTime? HarvestDate { get; set; }
      public string SendAdress { get; set; }
      public string BillType { get; set; }
      public string TaxpayersNumber { get; set; }
      public string RegisterAddress { get; set; }
      public string RegisterTel { get; set; }
      public string ContractUrl { get; set; }
      public string ContractName { get; set; }
      public string Note { get; set; }
      public string Orgin { get; set; }
      public string Status { get; set; }
      public Guid? CreateUser { get; set; }
      public DateTime? CreateDate { get; set; }
      public Guid? OrderUser { get; set; }
      public DateTime? OrderDate { get; set; }
      public string SupLinkman { get; set; }
      public string SupLinkPhone { get; set; }
      public string SupFax { get; set; }
      public Guid? SupID { get; set; }
      public Guid? ReceiveID { get; set; }
      public Guid? ActionID { get; set; }
      public Guid? OppID { get; set; }
      public Guid? QuoID { get; set; }
      public Guid? IntentID { get; set; }
      public string OrderTitle { get; set; }
      public string CusLinkman { get; set; }
      public string CusLinkPhone { get; set; }
      public int? CusDel { get; set; }
      public int? SupDel { get; set; }
      public string Wldh { get; set; }
      public string Wlmc { get; set; }
      public string Wllxr { get; set; }
      public string Wlphone { get; set; }
      public string Wljjr { get; set; }
      public string Wljjdh { get; set; }
      public string SupName { get; set; }
      public Guid? ContractID { get; set; }
      public string ContractNo { get; set; }
      public DateTime? ContractBeginTime { get; set; }
      public DateTime? ContractEndTime { get; set; }
      public string ContractTitle { get; set; }
      public string BillComName { get; set; }
      public string offtype { get; set; }
      public decimal? Percents { get; set; }
      public int? PayAccountType { get; set; }
      public DateTime? DeliveryDate { get; set; }
      public DateTime? SignclosedDate { get; set; }
      public decimal? DiscountMoney { get; set; }
      public decimal? OrderAmount { get; set; }
      public Guid? ShopId { get; set; }
      public Guid? PushShopId { get; set; }
      public string DeliveryType { get; set; }
      public string DeliveryJson { get; set; }
      public Guid? DrawId { get; set; }
      public string ShowPort { get; set; }
      public Guid? SetDeskId { get; set; }
      public string SetDeskName { get; set; }
      public int? DinersNumber { get; set; }
      public string OldOrderId { get; set; }
      public Guid? SubOrderId { get; set; }
      }
}
