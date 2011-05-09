using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace DemoConsole
{
    [ServiceContract]
    public class CatalogService
    {
        private readonly CatalogRespository _repository;
        public CatalogService()
        {
            _repository = new CatalogRespository();
        }

        [WebInvoke(UriTemplate = "", Method = "GET")]
        public IQueryable<Category> GetCategories()
        {
            return _repository.GetCategories().AsQueryable();
        }

        [WebInvoke(UriTemplate = "{category}", Method = "GET")]
        public Category GetCategoryByName(string category)
        {
            return _repository.GetCategoriesByName(category);
        }

        [WebInvoke(UriTemplate = "/{category}/{id}", Method = "GET")]
        public Product GetProductByCategoryAndId(string category, int id)
        {
            return _repository.GetProductById(id, category);
        }
    }
}
