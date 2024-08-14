using Microsoft.AspNetCore.Mvc;
using MyMVC.Databases;
using MyMVC.Models;

namespace MyMVC.Controllers;

public class CategoryController : Controller
{
	private readonly DataContext _db;
	public CategoryController(DataContext db) 
	{
		_db = db;
	}
	public IActionResult Index() 
	{
		List<Category> categories = _db.Categories.ToList();
		return View(categories);
	}
}
