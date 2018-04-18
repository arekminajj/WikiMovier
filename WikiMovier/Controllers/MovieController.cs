using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WikiMovier.Models;
using WikiMovier.Services;

namespace WikiMovier.Controllers
{
	public class MovieController : Controller
	{
		private readonly IMovie _movieService;

		public MovieController(IMovie movieService)
		{
			_movieService = movieService;
		}

		[Route("movie/search/{query}")]
		public async Task<IActionResult> Index(string query)
		{
			string json = await _movieService.DownlaodApiDataAsync(query);
			var movie =  JsonConvert.DeserializeObject<RootObject>(json);
			//return Content(json);

			return View(movie);
		}
    }
}