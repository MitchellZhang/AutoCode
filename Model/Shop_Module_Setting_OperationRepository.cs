
using System;
using ZYL.Core.Model;
using XmSoft.NetCore.DBContext;
using ZYL.Core.Interface.Repository;

namespace ZYL.Core.Repository
{
   public partial class Shop_Module_Setting_OperationRepository :DefaultRepository<Shop_Module_Setting_Operation>,IShop_Module_Setting_OperationRepository
   {
      public Shop_Module_Setting_OperationRepository(DbContext Context) : base(Context)
     {

     }
   }
}
