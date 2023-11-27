using Hajos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hajos.Controllers
{
	//[Route("api/[controller]")]
	[ApiController]
	public class BoatController : ControllerBase
	{
		[HttpGet]
		[Route("questions/all")]
		public IActionResult MindegyHogyHivjak()
		{
			HajosContext context = new HajosContext();
			var kerdesek = from x in context.Questions
						   select x.Question1;

			return Ok(kerdesek);
		}
	}
}
