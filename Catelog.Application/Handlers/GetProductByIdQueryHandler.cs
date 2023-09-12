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
	public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductResponse>
	{
		private readonly IProductRepository _productRepository;

		public GetProductByIdQueryHandler(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}
		public async Task<ProductResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
		{
			var product = await _productRepository.GetProduct(request.Id);
			var productResponse = ProductMapper.Mapper.Map<ProductResponse>(product);
			return productResponse;
		}
	}
}
