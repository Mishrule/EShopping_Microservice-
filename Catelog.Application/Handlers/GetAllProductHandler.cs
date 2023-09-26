using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catelog.Application.Mappers;
using Catelog.Application.Queries;
using Catelog.Application.Responses;
using Catelog.Core.Repositories;
using Catelog.Core.Specs;
using MediatR;

namespace Catelog.Application.Handlers
{
	public class GetAllProductHandler:IRequestHandler<GetAllProductsQuery, Pagination<ProductResponse>>
	{
		private readonly IProductRepository _productRepository;

		public GetAllProductHandler(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}
		public async Task<Pagination<ProductResponse>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
		{
			var productList = await _productRepository.GetProducts(request.CatelogSpecParams);
			var productResponseList = ProductMapper.Mapper.Map<Pagination<ProductResponse>>(productList);
			return productResponseList;
		}
	}
}
