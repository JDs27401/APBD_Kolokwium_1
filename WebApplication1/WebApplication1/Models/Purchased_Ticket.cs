using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

[Table("Purchased_Ticket")]
public class Purchased_Ticket
{
    [ForeignKey(nameof(Ticket_Concert))]
    public int TicketConcertId { get; set; }
    
    [ForeignKey(nameof(Customer))]
    public int CustomerId { get; set; }
    
    public DateTime PurchaseDate { get; set; }
}