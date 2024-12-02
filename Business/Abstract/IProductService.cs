using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        // List<Product> GetAll();
        IDataResult<List<Product>> GetAll();

        //List<Product> GetAllByCategory(int id);
        IDataResult<List<Product>> GetAllByCategory(int id);

        //List<Product> GetAllByUnitPrice(decimal min, decimal max);
        IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max);
        
        //List<ProductDetailDto> GetProductDetails();
        IDataResult<List<ProductDetailDto>> GetProductDetails();

        //Product GetById(int productId);
        IDataResult<Product> GetById(int productId);   

        //void Add(Product product);
        IResult Add(Product product);

    }
}
