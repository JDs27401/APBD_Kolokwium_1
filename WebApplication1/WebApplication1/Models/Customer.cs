using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Customer")]


public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    
    [Column(TypeName = "nvarchar(50)")]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    [MaxLength(100)]
    public string LastName { get; set; }
    
    [Column(TypeName = "nvarchar(100)")]
    [MaxLength(100)]
    public string PhoneNumber { get; set; }
    
    public ICollection<Purchased_Ticket> ticket_Concerts { get; set; }
    
}