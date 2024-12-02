using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            ProductDetailTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());

            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll().Data)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("--------------------------");

            foreach (var product in productManager.GetAllByCategory(2).Data)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("--------------------------");

            foreach (var product in productManager.GetAllByUnitPrice(50, 100).Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void ProductDetailTest()
        {
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());

            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();
           
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}