using Core.DataAccess;
using Core.Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductsDetails();

        //İlk başta aşağıdaki kodlar yazıldı.
        //IEntityRepository  yazıldıktan sonra aşağdaki kodlar silindi.
        /*
        List<Product> GelAll();
        void Add(Product product);  
        void Update(Product product);  
        void Delete(Product product);   
        List<Product> GetAllByCategory(int categoryId);
        */
    }
}
