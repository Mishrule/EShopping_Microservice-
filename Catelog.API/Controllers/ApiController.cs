using Microsoft.AspNetCore.Mvc;

namespace Catelog.API.Controllers
{
	[ApiVersion("1")]
	[Route("api/v{version:apiversion}/[controller]")]
	[ApiController]
	public class ApiController : ControllerBase
	{
		
	}
}
