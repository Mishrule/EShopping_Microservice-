using Catelog.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catelog.Application.Queries
{
	public class GetAllProductQuery : IRequest<IList<ProductResponse>>
	{

	}
}
