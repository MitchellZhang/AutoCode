using System;
using ZYL.Core.Model;
using XmSoft.NetCore.DBContext;
namespace ZYL.Core.Service.Data
{
   public partial class THOA_Company_AgeRepository :DefaultRepository<THOA_Company_Age>,ITHOA_Company_AgeRepository
   {
      public THOA_Company_AgeRepository(DbContext Context) : base(Context)
     {

     }
   }
}
