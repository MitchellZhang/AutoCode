
using System;
using ZYL.Core.Model;

namespace ZYL.Core.Interface.Service
{
   public interface IShop_Module_OperationService
   {
      
      object Create(Shop_Module_Operation model);
     
      bool Update(Shop_Module_Operation model);

      bool Delete(object Id);

   }
}
