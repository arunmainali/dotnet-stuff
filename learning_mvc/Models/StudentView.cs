using System.ComponentModel.DataAnnotations;

namespace learning_mvc;

public class StudentView
{
	[Key]
	public int id {get; set; }

	[Required]
	public string name {get; set; }

	[Required]
	public string email {get; set; }
}
