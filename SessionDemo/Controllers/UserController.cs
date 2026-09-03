using Microsoft.AspNetCore.Mvc;
using SessionDemo.Models;

public class UserController : Controller {
	public ActionResult Index() {

		HttpContext.Session.SetString("Name", "Arun Mainali");
		HttpContext.Session.SetInt32("Age", 21);

		User newUser = new User();
		newUser.Name = HttpContext.Session.GetString("Name");
		newUser.Age = HttpContext.Session.GetInt32("Age").Value;

		return View(newUser);
	}

	// http://localhost:5011/user/getquerystring?name=Arun&age=21
	// The key-value paris after the "?" are string queries
	// The keys are parameter names and the values are the values that will
	// be passed to the parameters as arguments
	public ActionResult GetQueryString(string name, int age) {
		User newUser = new User();
		newUser.Name = name;
		newUser.Age = age;

		return View(newUser);
	}

	[HttpGet]
	public ActionResult SetHiddenFieldValue() {
		User newUser = new User()
		{
			Id = 101,
			Name = "Arun",
			Age = 110
		};

		return View(newUser);
	}

	[HttpPost]
	public ActionResult SetHiddenFieldValue(User user) {
		var id = user.Id;
		// ViewBag.ID = id;
		// TempData["ID"] = id;
		return View(user);
	}
}
