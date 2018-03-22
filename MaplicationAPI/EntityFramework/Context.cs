using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MaplicationAPI.EntityFramework
{
    public class MaplicationContext : DbContext
    {
        public MaplicationContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Attendee> Attendee { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Coordinator> Coordinator { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<JobPostings> JobPostings { get; set; }
        public DbSet<Map> Map { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<Recruiter> Recruiter { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Tables> Tables { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserTypes> UserTypes { get; set; }
        public DbSet<EventAttendance> EventAttendance { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
