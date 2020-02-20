
using System;
using ZYL.Core.Model;
using ZYL.Core.Repository;
using ZYL.Core.Interface.Service;
using ZYL.Core.Interface.Repository;

namespace ZYL.Core.Service
{
   public class Shop_Module_Setting_OperationService :IShop_Module_Setting_OperationService
   {
      private IShop_Module_Setting_OperationRepository repository;
      public Shop_Module_Setting_OperationService(IShop_Module_Setting_OperationRepository _repository)
      {
         repository = _repository;
      }  

      /// <summary>
      /// 新增
      /// </summary>
      public object Create(Shop_Module_Setting_Operation model) => repository.Create(model); 
      /// <summary>
      /// 修改
      /// </summary>
      public bool Update(Shop_Module_Setting_Operation model) => repository.Update(model);
      /// <summary>
      /// 删除
      /// </summary>
      public bool Delete(object Id) => repository.DeleteById(Id);

   }
}
