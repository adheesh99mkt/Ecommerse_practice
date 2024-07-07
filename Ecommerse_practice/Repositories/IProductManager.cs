using Ecommerse_practice.Models;

namespace Ecommerse_practice.Repositories
{
    public interface IProductManager
    {
        List<Products> GetAll();
        void Add(Products product);
        void Update(Products product);
        void Delete(int id);
        Products GetById(int id);
    }
}
