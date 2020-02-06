using System;
using ZYL.Core.Model;
using XmSoft.NetCore.DBContext;
namespace ZYL.Core.Repository
{
   public partial class Product_ListRepository :DefaultRepository<Product_List>,IProduct_ListRepository
   {
      public Product_ListRepository(DbContext Context) : base(Context)
     {

     }
   }
}
