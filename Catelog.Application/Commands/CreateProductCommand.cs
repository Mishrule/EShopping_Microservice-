using Catelog.Application.Responses;
using Catelog.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catelog.Application.Commands
{
	public class CreateProductCommand : IRequest<ProductResponse>
	{
		public string Name { get; set; }
		public string Summary { get; set; }
		public string Description { get; set; }
		public string ImageFile { get; set; }
		public decimal Price { get; set; }
		public ProductBrand Brands { get; set; }
		public ProductType Types { get; set; }
	}
}
