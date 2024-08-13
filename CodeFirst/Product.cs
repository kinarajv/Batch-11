using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst;

public class Product
{
	public int ProductId { get; set; }
	public string ProductName { get; set; }
	public string Description { get; set; }
	public int CategoryId { get; set; }
	public Category Category { get; set; }
	[Column(TypeName = "money")]
	public int UnitPrice { get; set; }
	[Column(TypeName = "datetime")]
	public DateTime CreateTime { get; set; }
}
