using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOs;

public class GetCustomerDto
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}