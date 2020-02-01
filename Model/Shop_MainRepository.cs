using System;
using ZYL.Core.Model;
using XmSoft.NetCore.DBContext;
namespace ZYL.Core.Service.Data
{
   public partial class Shop_MainRepository :DefaultRepository<Shop_Main>,IShop_MainRepository
   {
      public Shop_MainRepository(DbContext Context) : base(Context)
     {

     }
   }
}
