
using System;
using ZYL.Core.Model;
using ZYL.Core.Repository;

namespace ZYL.Core.Service
{
   public class Shop_Fmcg_Store_RepositoryRelationService :IShop_Fmcg_Store_RepositoryRelationService
   {
      private IShop_Fmcg_Store_RepositoryRelationRepository repository;
      public Shop_Fmcg_Store_RepositoryRelationService(IShop_Fmcg_Store_RepositoryRelationRepository _repository)
      {
         repository = _repository;
      }  

      /// <summary>
      /// 新增
      /// </summary>
      public object Create(Shop_Fmcg_Store_RepositoryRelation model) => repository.Create(model); 
      /// <summary>
      /// 修改
      /// </summary>
      public bool Update(Shop_Fmcg_Store_RepositoryRelation model) => repository.Update(model);
      /// <summary>
      /// 删除
      /// </summary>
      public bool Delete(object Id) => repository.DeleteById(Id);

   }
}
