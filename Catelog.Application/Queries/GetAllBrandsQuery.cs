using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catelog.Application.Responses;

namespace Catelog.Application.Queries
{
	public class GetAllBrandsQuery : IRequest<IList<BrandResponse>>
	{

	}
}
