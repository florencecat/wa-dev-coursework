using Microsoft.EntityFrameworkCore;

namespace wa_dev_coursework.Models.EventsContext
{
    public class EventsContext : DbContext
    {
        // Constructor
        public EventsContext(DbContextOptions<EventsContext> options) : base(options)
        { }

        // Properties
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }

        // Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasOne(e => e.Author)
                      .WithMany(u => u.CreatedEvents)
                      .HasForeignKey(e => e.AuthorID);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasOne(e => e.Organization)
                      .WithMany(u => u.Workers)
                      .HasForeignKey(e => e.OrganizationID);
            });
        }
    }
}
