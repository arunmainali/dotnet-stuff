using Microsoft.AspNetCore.Mvc;

using learning_mvc;

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

	public ActionResult SignUp() {
		return View();
	}

	[HttpPost]
	public ActionResult SignUp(StudentView student) {
		if (ModelState.IsValid) {
			ViewBag.Message = student.name + " ; Record Submitted Successfully" + student.email + " is the email";
		}
		return View();
	}
    }
}
