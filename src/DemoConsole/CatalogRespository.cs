using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoConsole
{
    public class CatalogRespository
    {
        private readonly CatalogContext _context;

        public CatalogRespository()
        {
            _context = new CatalogContext();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.GetData();
        }

        public Category GetCategoriesByName(string name)
        {
            return _context.GetData().First(x => x.Name == name);
        }

        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return GetCategoriesByName(category).Products;
        }

        public Product GetProductById(int id, string category)
        {
            return GetProductsByCategory(category).First(x => x.Id == id);
        }
    }
}
