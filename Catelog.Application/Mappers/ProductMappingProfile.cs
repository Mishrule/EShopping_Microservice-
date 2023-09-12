using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Catelog.Application.Commands;
using Catelog.Application.Responses;
using Catelog.Core.Entities;

namespace Catelog.Application.Mappers
{
	public class ProductMappingProfile:Profile
	{
		public ProductMappingProfile()
		{
			CreateMap<Product, ProductResponse>().ReverseMap();
			CreateMap<Product, CreateProductCommand>().ReverseMap();
			CreateMap<ProductBrand, BrandResponse>().ReverseMap();
			CreateMap<ProductType, TypesResponse>().ReverseMap();

		}
	}
}
