using System.ComponentModel.DataAnnotations;

namespace learning_mvc;

public class StudentView
{
	[Key]
	public int id {get; set; }

	[Required (ErrorMessage = "Full name is required")]
	public string name {get; set; }

	[Required (ErrorMessage = "Email is required")]
	public string email {get; set; }
}
