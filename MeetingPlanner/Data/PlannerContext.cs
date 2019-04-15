using System;
using System.Collections.Generic;
using MeetingPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetingPlanner.Data
{
    public class PlannerContext : DbContext
    {
        public PlannerContext(DbContextOptions<PlannerContext> options) : base(options)
        {
        }

        public DbSet<Hymn> Hymns { get; set; }
        public DbSet<Prayer> Prayers { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Meeting> Meetings { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hymn>().ToTable("Hymn");
            modelBuilder.Entity<Prayer>().ToTable("Prayer");
            modelBuilder.Entity<Agenda>().ToTable("Agenda");
            modelBuilder.Entity<Meeting>().ToTable("Meeting");
        }
    }
}