using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Tickets")]


public class Ticket
{
    [Key]
    public int TicketId { get; set; }
    
    [Column(TypeName = "nvarchar(100)")]
    [MaxLength(100)]
    public int SerialNumber { get; set; }
    
    public int seatNumber { get; set; }
    
    public ICollection<Ticket_Concert> TicketConcerts { get; set; }
    
}