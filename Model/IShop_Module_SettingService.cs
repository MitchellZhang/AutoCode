
using System;
using ZYL.Core.Model;

namespace ZYL.Core.Interface.Service
{
   public interface IShop_Module_SettingService
   {
      
      object Create(Shop_Module_Setting model);
     
      bool Update(Shop_Module_Setting model);

      bool Delete(object Id);

   }
}
