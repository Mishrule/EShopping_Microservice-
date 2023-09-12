using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catelog.Application.Mappers;
using Catelog.Application.Queries;
using Catelog.Application.Responses;
using Catelog.Core.Repositories;
using MediatR;

namespace Catelog.Application.Handlers
{
	public class GetAllProductHandler:IRequestHandler<GetAllProductQuery, IList<ProductResponse>>
	{
		private readonly IProductRepository _productRepository;

		public GetAllProductHandler(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}
		public async Task<IList<ProductResponse>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
		{
			var productList = await _productRepository.GetProducts();
			var productResponseList = ProductMapper.Mapper.Map<IList<ProductResponse>>(productList);
			return productResponseList;
		}
	}
}
