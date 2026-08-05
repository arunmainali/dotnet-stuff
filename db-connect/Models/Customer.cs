using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbConnect.Models;

public class Customer
{
    public int AccountNo { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public decimal Balance { get; set; }
}
