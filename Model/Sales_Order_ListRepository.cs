using System;
using ZYL.Core.Model;
using XmSoft.NetCore.DBContext;
namespace ZYL.Core.Repository
{
   public partial class Sales_Order_ListRepository :DefaultRepository<Sales_Order_List>,ISales_Order_ListRepository
   {
      public Sales_Order_ListRepository(DbContext Context) : base(Context)
     {

     }
   }
}
