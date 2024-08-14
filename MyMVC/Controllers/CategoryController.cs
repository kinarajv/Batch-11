using Microsoft.AspNetCore.Mvc;
using MyMVC.Models;

namespace MyMVC.Controllers;

public class CategoryController : Controller
{
	public IActionResult Index() 
	{
		List<Category> categories = new() { 
			new Category() 
			{
				CategoryId = 1,
				CategoryName = "Electronic",
				Description = "Yanto"
			},
			new Category() 
			{
				CategoryId = 2,
				CategoryName = "President",
				Description = "Bowo"
			}
		 };
		return View(categories);
	}
}
