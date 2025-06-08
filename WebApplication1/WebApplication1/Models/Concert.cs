using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Concert")]

public class Concert
{
    [Key]
    public int ConcertId { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    [MaxLength(100)]
    public string Name { get; set; }
    
    public DateTime Date { get; set; }
    
    public int AvailableTickets { get; set; }
    
    public ICollection<Ticket_Concert> TicketConcerts { get; set; }
}