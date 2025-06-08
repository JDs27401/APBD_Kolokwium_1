using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Concert> Concerts { get; set; }
    public DbSet<Ticket_Concert> Ticket_Concerts { get; set; }
    public DbSet<Purchased_Ticket> Purchased_Tickets { get; set; }

    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ticket>().HasData(new List<Ticket>()
            {
                new Ticket() {TicketId = 1, SerialNumber = 8237438, seatNumber = 69},
                new Ticket() {TicketId = 1, SerialNumber = 3874837, seatNumber = 420},
                
            }
        );

        modelBuilder.Entity<Customer>().HasData(new List<Customer>()
            {
                new Customer() {CustomerId = 1, FirstName = "John", LastName = "Doe", PhoneNumber = "23894789"},
                new Customer() {CustomerId = 2, FirstName = "John", LastName = "Deer", PhoneNumber = "834783212"},
            }
        );

        modelBuilder.Entity<Concert>().HasData(new List<Concert>()
            {
                new Concert() {ConcertId = 1, Name = "Imagine Dragons", Date = new DateTime(2025, 10, 10), AvailableTickets = 50000},
                new Concert() {ConcertId = 1, Name = "Lady Gagal", Date = new DateTime(2025, 11, 11), AvailableTickets = 70000},
            }
        );

        modelBuilder.Entity<Purchased_Ticket>().HasData(new List<Purchased_Ticket>()
            {
                new Purchased_Ticket() {TicketConcertId = 1, CustomerId = 1, PurchaseDate = new DateTime(2024, 1, 1)},
                new Purchased_Ticket() {TicketConcertId = 2, CustomerId = 2, PurchaseDate = new DateTime(2024, 2, 2)},
            }
        );

        modelBuilder.Entity<Purchased_Ticket>().HasKey(p => new
            {
                p.TicketConcertId, p.CustomerId
            });
    }
}