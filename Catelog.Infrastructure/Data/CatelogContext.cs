﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catelog.Core.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catelog.Infrastructure.Data
{
	public class CatelogContext: ICatalogContext
	{
		public IMongoCollection<Product> Products { get; }
		public IMongoCollection<ProductBrand> Brands { get; }
		public IMongoCollection<ProductType> Types { get; }

		public CatelogContext(IConfiguration configuration)
		{
			var client = new MongoClient(configuration.GetValue<string>("DatabaSettings:ConnectionString"));
			var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
			Brands = database.GetCollection<ProductBrand>(
				configuration.GetValue<string>("DatabaseSettings:BrandsCollection"));
			Types = database.GetCollection<ProductType>(
				configuration.GetValue<string>("DatabaseSettings:TypesCollection"));
			Products = database.GetCollection<Product>(
				configuration.GetValue<string>("DatabaseSettings:CollectionName"));

			BrandContextSeed.SeedData(Brands);
			TypeContextSeed.SeedData(Types);
			CatelogContextSeed.SeedData(Products);



		}
	}
}
