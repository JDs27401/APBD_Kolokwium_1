using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

[PrimaryKey(nameof(Purchased_Ticket))]
[Table("Ticket_Concert")]

public class Ticket_Concert
{
    [Key]
    public int TicketConcertId { get; set; }
    
    [ForeignKey(nameof(Ticket))]
    public int TicketId { get; set; }
    
    [ForeignKey(nameof(Concert))]
    public int ConcertId { get; set; }
    
    [Precision(10, 2)]
    public double Price { get; set; }
    
    public ICollection<Purchased_Ticket> PurchasedTickets { get; set; }
}