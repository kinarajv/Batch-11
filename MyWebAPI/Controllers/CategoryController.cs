using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Models;
using MyWebAPI.Repository;

namespace MyWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase, IController<Category>
{
	private DataContext _db;
	public CategoryController(DataContext db) 
	{
		_db = db;
	}
	[HttpPost]
	public IActionResult Create(Category data)
	{
		_db.Categories.Add(data);
		_db.SaveChanges();
		return Ok();
	}
	[HttpDelete]
	[Route("{id}")]
	public IActionResult Delete(int id)
	{
		Category? category = _db.Categories.Find(id);
		if(category is null ) {
			return NotFound();
		}
		_db.Categories.Remove(category);
		_db.SaveChanges();
		return Ok();
	}
	[HttpGet]
	public IActionResult Get()
	{
		List<Category> categories = _db.Categories.ToList();
		return Ok(categories);
	}
	[HttpGet]
	[Route("{id}")]
	public IActionResult Get(int id)
	{
		Category? category = _db.Categories.Find(id);
		if(category is null ) {
			return NotFound();
		}
		return Ok(category);
	}
	[HttpPut]
	[Route("{id}")]
	public IActionResult Update(int id, Category data)
	{
		Category? category = _db.Categories.Find(id);
		if(category is null ) {
			return NotFound();
		}
		category.CategoryName = data.CategoryName;
		category.Description = data.Description;
		_db.Categories.Update(category);
		_db.SaveChanges();
		return Ok();
	}

}
