using Ecommerse_practice.Models;

namespace Ecommerse_practice.Services
{
    public interface IProductService
    {
        List<Products> GetAll();
        Products GetById(int id);
        void Update(Products products);
        void Delete(int id);
        void Add(Products products);

    }
}
