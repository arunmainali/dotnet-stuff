using System.ComponentModel.DataAnnotations;

namespace DbConnect.Models;

public class Employee
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; } = string.Empty;
    
    public decimal Salary { get; set; }

    public string Address { get; set; } = string.Empty;
}
