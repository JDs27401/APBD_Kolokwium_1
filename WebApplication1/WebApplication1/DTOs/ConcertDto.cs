namespace WebApplication1.DTOs;

public class ConcertDto
{
    public int ConcertId { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public int AvailableTickets { get; set; }
}