using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
	private static readonly List<string> myCategories = new() { "Eleectronics", "Fruit" };
	
	[HttpGet]
	public IActionResult GetAll() 
	{
		return Ok(myCategories);
	}
	[Route("{id}")]
	[HttpGet]
	public IActionResult GetAll(int id) 
	{
		if(id > myCategories.Count) 
		{
			return NotFound("Takdelah");
		}
		return Ok(myCategories[id]);
	}
	[HttpPost]
	public IActionResult Add(string data) 
	{
		myCategories.Add(data);
		return Ok(myCategories);
	}
	[Route("{id}")]
	[HttpDelete]
	public IActionResult Delete(int id) 
	{
		if(id > myCategories.Count) 
		{
			return NotFound("Takdelah");
		}
		myCategories.RemoveAt(id);
		return Ok(myCategories);
	}
}
