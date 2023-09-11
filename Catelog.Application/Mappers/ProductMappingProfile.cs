using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Catelog.Application.Responses;
using Catelog.Core.Entities;

namespace Catelog.Application.Mappers
{
	public class ProductMappingProfile:Profile
	{
		public ProductMappingProfile()
		{
			CreateMap<ProductBrand, BrandResponse>().ReverseMap();
		}
	}
}
