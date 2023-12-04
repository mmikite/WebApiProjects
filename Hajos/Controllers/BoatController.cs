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
		[Route("questions/{sorszám}")]
		public IActionResult M2(int sorszám)
		{
			HajosContext context = new HajosContext();
			var kerdes = (from x in context.Questions
						where x.QuestionId == sorszám
						   select x).FirstOrDefault();
			
			if (kerdes == null) return BadRequest("Nincs ilyen sorszámú kérdés");

			return new JsonResult(kerdes);
		}
	}
}
