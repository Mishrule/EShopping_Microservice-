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
	public class GetProductByNameQueryHandler : IRequestHandler<GetProductByNameQuery, IList<ProductResponse>>
	{
		private readonly IProductRepository _productRepository;

		public GetProductByNameQueryHandler(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}
		public async Task<IList<ProductResponse>> Handle(GetProductByNameQuery request, CancellationToken cancellationToken)
		{
			var productList = await _productRepository.GetProductByName(request.Name);
			var productResponseList = ProductMapper.Mapper.Map<IList<ProductResponse>>(productList);
			return productResponseList;
		}
	}
}
