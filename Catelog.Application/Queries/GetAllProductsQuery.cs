using Catelog.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catelog.Core.Specs;

namespace Catelog.Application.Queries
{
	public class GetAllProductsQuery : IRequest<Pagination<ProductResponse>>
	{
		public CatelogSpecParams CatelogSpecParams { get; set; }
		public GetAllProductsQuery(CatelogSpecParams catelogSpecParams)
		{
			CatelogSpecParams = catelogSpecParams;
		}

		
	}
}
