using System;
using ZYL.Core.Model;
using XmSoft.NetCore.DBContext;
namespace ZYL.Core.Service.Data
{
   public partial class Shop_P_MainRepository :DefaultRepository<Shop_P_Main>,IShop_P_MainRepository
   {
      public Shop_P_MainRepository(DbContext Context) : base(Context)
     {

     }
   }
}
