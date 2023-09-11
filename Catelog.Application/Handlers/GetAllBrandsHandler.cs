using Catelog.Application.Mappers;
using Catelog.Application.Queries;
using Catelog.Application.Responses;
using Catelog.Core.Entities;
using Catelog.Core.Repositories;
using MediatR;

namespace Catelog.Application.Handlers
{
	public class GetAllBrandsHandler : IRequestHandler<GetAllBrandsQuery, IList<BrandResponse>>
	{
		private readonly IBrandRepository _brandRepository;

		public GetAllBrandsHandler(IBrandRepository brandRepository)
		{
			_brandRepository = brandRepository;
		}

		public async Task<IList<BrandResponse>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
		{
			var brandList = await _brandRepository.GetAllBrands();
			var brandResponseList = ProductMapper.Mapper.Map<IList<ProductBrand>, IList<BrandResponse>>(brandList.ToList());
			return brandResponseList;
		}

	}
}
