using Catelog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catelog.Core.Specs;

namespace Catelog.Core.Repositories
{
    public interface IProductRepository
    {
        Task<Pagination<Product>> GetProducts(CatelogSpecParams catalogSpecParams);
       //Task<IEnumerable<Product>> GetProducts(CatelogSpecParams catalogSpecParams);
       Task<Product> GetProduct(string id);
        Task<IEnumerable<Product>> GetProductByName(string name);
        Task<IEnumerable<Product>> GetProductByBrand(string name);
        Task<Product> CreateProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(string id);

    }
}
