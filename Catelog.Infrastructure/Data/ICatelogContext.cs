using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catelog.Core.Entities;
using MongoDB.Driver;

namespace Catelog.Infrastructure.Data
{
    public interface ICatelogContext
    {
        IMongoCollection<Product> Products { get; }
        IMongoCollection<ProductBrand> Brands { get; }
        IMongoCollection<ProductType> Types { get; }
    }
}
