using Microsoft.AspNetCore.Mvc;

[Area("sales")]
[Route("sales")]
public class ProductController : Controller {
	public IActionResult Index() {
		List<Product> list = new List<Product>() {
		new Product { Name = "Shirts", Quantity = 5, Price = 100 },
		new Product { Name = "Pants", Quantity = 15, Price = 10 },
		new Product { Name = "Shoes", Quantity = 15, Price = 10 },
		};

		return View(list);
	}
}
