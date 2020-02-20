
using System;
using ZYL.Core.Model;

namespace ZYL.Core.Interface.Service
{
   public interface IShop_Module_Setting_OperationService
   {
      
      object Create(Shop_Module_Setting_Operation model);
     
      bool Update(Shop_Module_Setting_Operation model);

      bool Delete(object Id);

   }
}
