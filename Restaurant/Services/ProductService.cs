using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses;
using System.Data.Entity;
using DAL;

namespace Services
{
    public class ProductService
    {
        private readonly IDbSet<Product> _products;
        public ProductService(IUnitOfWork uow)
        {
            _products = uow.Set<Product>();
        }

        public void Add(Product p)
        {
            _products.Add(p);
        }
        public void Remove(Product p)
        {
            _products.Remove(p);
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public Product GetByName(string name)
        {
            return _products.FirstOrDefault(x => x.Name == name);
        }

        public List<Product> GetProducts()
        {
            return _products.ToList();
        }

        public List<Product> GetAvailableProducts()
        {
            return _products.Where(x => x.Available).ToList();
        }

        public List<string> GetUnAvailableProductNames()
        {
            return _products.Where(x => !x.Available).Select(x=>x.Name).ToList();
        }

        public List<string> GetAvailableProductNames()
        {
            return _products.Where(x => x.Available).Select(x =>x.Name).ToList();
        }

        public double GetPriceByName(string name)
        {
            return _products.First(x => x.Name == name).Price;
        }

        public int GetIdByName(string name)
        {
            return _products.First(x => x.Name == name).Id;
        }

    }
}
