
using System;
using ZYL.Core.Model;

namespace ZYL.Core.Service
{
   public interface IProduct_ListService
   {
      
      object Create(Product_List model);
     
      bool Update(Product_List model);

      bool Delete(object Id);

   }
}
