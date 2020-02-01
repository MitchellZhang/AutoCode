using System;
using ZYL.Core.Model;
using XmSoft.NetCore.DBContext;
namespace ZYL.Core.Service.Data
{
   public partial class THOA_CompanyRepository :DefaultRepository<THOA_Company>,ITHOA_CompanyRepository
   {
      public THOA_CompanyRepository(DbContext Context) : base(Context)
     {

     }
   }
}
