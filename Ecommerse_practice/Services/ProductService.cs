using Ecommerse_practice.Models;
using Ecommerse_practice.Repositories;

namespace Ecommerse_practice.Services
{
    public class ProductService : IProductService
    {
        private IProductManager productManager=new ProductManager();
        public List<Products> GetAll()
        {
            return productManager.GetAll();
            
        }
        public Products GetById(int id)
        {
            return productManager.GetById(id);
        }

        public void Update(Products product)
        {
            productManager.Update(product);
        }
        public void Delete(int id)
        {
            productManager.Delete(id);
        }
        public void Add(Products product)
        {
            productManager.Add(product);
        }
    }
}
