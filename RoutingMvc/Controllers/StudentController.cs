using Microsoft.AspNetCore.Mvc;

namespace RoutingMvc.Controllers
{
    [Route("Student")]
    public class StudentController : Controller
    {
	[HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }

	[Route("Details/{id:int?}")]
	public IActionResult GetDetails(int id)
	{
		return View();
	}

	[Route("~/StudentDetails/All")]
	public IActionResult GetStudents()
	{
		return View();
	}
    }
}

