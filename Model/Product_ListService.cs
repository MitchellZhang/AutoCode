
using System;
using ZYL.Core.Model;
using ZYL.Core.Repository;

namespace ZYL.Core.Service
{
   public class Product_ListService :IProduct_ListService
   {
      private IProduct_ListRepository repository;
      public Product_ListService(IProduct_ListRepository _repository)
      {
         repository = _repository;
      }  

      /// <summary>
      /// 新增
      /// </summary>
      public object Create(Product_List model) => repository.Create(model); 
      /// <summary>
      /// 修改
      /// </summary>
      public bool Update(Product_List model) => repository.Update(model);
      /// <summary>
      /// 删除
      /// </summary>
      public bool Delete(object Id) => repository.DeleteById(Id);

   }
}
