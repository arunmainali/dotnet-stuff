using Microsoft.AspNetCore.Mvc;

// controller = StudentController
// action = Index

namespace MyApp.Namespace
{
    public class StudentController : Controller
    {
        // GET: StudentController
        public ActionResult Index()
        {
            return View();
        }

	public ActionResult About()
	{
	    return View();
	}
    }
}
