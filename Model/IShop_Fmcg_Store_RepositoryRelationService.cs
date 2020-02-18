
using System;
using ZYL.Core.Model;

namespace ZYL.Core.Service
{
   public interface IShop_Fmcg_Store_RepositoryRelationService
   {
      
      object Create(Shop_Fmcg_Store_RepositoryRelation model);
     
      bool Update(Shop_Fmcg_Store_RepositoryRelation model);

      bool Delete(object Id);

   }
}
