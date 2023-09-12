using Catelog.Application.Mappers;
using Catelog.Application.Queries;
using Catelog.Application.Responses;
using Catelog.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catelog.Application.Handlers
{
	public class GetProductByBrandHandler : IRequestHandler<GetProductByBrandQuery, IList<ProductResponse>>
	{
		private readonly IProductRepository _productRepository;

		public GetProductByBrandHandler(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}
		public async Task<IList<ProductResponse>> Handle(GetProductByBrandQuery request, CancellationToken cancellationToken)
		{
			var productList = await _productRepository.GetProductByBrand(request.Brandname);
			var productResponseList = ProductMapper.Mapper.Map<IList<ProductResponse>>(productList);
			return productResponseList;
		}
	}
}
