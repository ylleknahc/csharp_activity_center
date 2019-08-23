using Microsoft.EntityFrameworkCore;

namespace BeltExam.Models
{
    public class BeltExamContext : DbContext
    {
        public BeltExamContext(DbContextOptions options) : base(options) { }

        public DbSet<User> users { get; set; }
        public DbSet<Hangout> hangouts { get; set; }
        public DbSet<HangoutParticipants> hangoutParticipants { get; set; }
    }
}