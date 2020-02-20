
using System;
using ZYL.Core.Model;
using XmSoft.NetCore.DBContext;
using ZYL.Core.Interface.Repository;

namespace ZYL.Core.Repository
{
   public partial class Shop_Module_SettingRepository :DefaultRepository<Shop_Module_Setting>,IShop_Module_SettingRepository
   {
      public Shop_Module_SettingRepository(DbContext Context) : base(Context)
     {

     }
   }
}
