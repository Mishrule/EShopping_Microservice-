using Catelog.Core.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Catelog.Infrastructure.Data
{
    public class CatelogContextSeed
    {

            public static void SeedData(IMongoCollection<Product> productCollection)
            {
                bool checkProducts = productCollection.Find(b => true).Any();
                string path = Path.Combine("Data", "SeedData", "products.json");
                if (!checkProducts)
                {
                    var productData = File.ReadAllText(path);
                    var products = JsonSerializer.Deserialize<List<Product>>(productData);
                    if (products != null)
                    {
                        foreach (var item in products)
                        {
                            productCollection.InsertOneAsync(item);
                        }
                    }
                }
            }
     }
    
}
