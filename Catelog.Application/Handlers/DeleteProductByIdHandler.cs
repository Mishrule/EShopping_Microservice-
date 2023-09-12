﻿using Catelog.Application.Queries;
using Catelog.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catelog.Application.Handlers
{
	public class DeleteProductByIdHandler : IRequestHandler<DeleteProductByIdQuery, bool>
	{
		private readonly IProductRepository _productRepository;

		public DeleteProductByIdHandler(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}
		public async Task<bool> Handle(DeleteProductByIdQuery request, CancellationToken cancellationToken)
		{
			return await _productRepository.DeleteProduct(request.Id);
		}
	}
}
