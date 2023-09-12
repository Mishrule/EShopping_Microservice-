using Catelog.Application.Commands;
using Catelog.Application.Mappers;
using Catelog.Application.Responses;
using Catelog.Core.Entities;
using Catelog.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catelog.Application.Handlers
{
	public class CreateProductHandler : IRequestHandler<CreateProductCommand, ProductResponse>
	{
		private readonly IProductRepository _productRepository;

		public CreateProductHandler(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}
		public async Task<ProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
		{
			var productEntity = ProductMapper.Mapper.Map<Product>(request);
			if (productEntity is null)
			{
				throw new ApplicationException("There is an issue with mapping while creating new product");
			}

			var newProduct = await _productRepository.CreateProduct(productEntity);
			var productResponse = ProductMapper.Mapper.Map<ProductResponse>(newProduct);
			return productResponse;
		}
	}
}
