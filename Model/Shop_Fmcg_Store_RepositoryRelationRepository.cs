
using System;
using ZYL.Core.Model;
using XmSoft.NetCore.DBContext;
namespace ZYL.Core.Repository
{
   public partial class Shop_Fmcg_Store_RepositoryRelationRepository :DefaultRepository<Shop_Fmcg_Store_RepositoryRelation>,IShop_Fmcg_Store_RepositoryRelationRepository
   {
      public Shop_Fmcg_Store_RepositoryRelationRepository(DbContext Context) : base(Context)
     {

     }
   }
}
