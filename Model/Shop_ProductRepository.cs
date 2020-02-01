using System;
using ZYL.Core.Model;
using XmSoft.NetCore.DBContext;
namespace ZYL.Core.Service.Data
{
   public partial class Shop_ProductRepository :DefaultRepository<Shop_Product>,IShop_ProductRepository
   {
      public Shop_ProductRepository(DbContext Context) : base(Context)
     {

     }
   }
}
