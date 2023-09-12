﻿using Catelog.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catelog.Application.Queries
{
	public class GetProductByNameQuery : IRequest<IList<ProductResponse>>
	{
		public string Name { get; set; }

		public GetProductByNameQuery(string name)
		{
			Name = name;
		}
	}
}
