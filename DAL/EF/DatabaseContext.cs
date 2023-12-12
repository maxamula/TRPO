using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DAL.Entities;
using System.Reflection.Emit;

namespace DAL.EF
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        partial void OnModelBuilding(ModelBuilder builder);

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Entities.Record>()
              .HasOne(i => i.Appointment)
              .WithMany(i => i.Records)
              .HasForeignKey(i => i.appointmentId)
              .HasPrincipalKey(i => i.id);

            builder.Entity<Entities.Record>()
              .HasOne(i => i.Engineer)
              .WithMany(i => i.Records)
              .HasForeignKey(i => i.engeneerId)
              .HasPrincipalKey(i => i.id);

            builder.Entity<Entities.Record>()
              .HasOne(i => i.Sensor)
              .WithMany(i => i.Records)
              .HasForeignKey(i => i.sensorCodename)
              .HasPrincipalKey(i => i.codename);

            builder.Entity<Entities.Value>()
              .HasOne(i => i.Pollutant)
              .WithMany(i => i.Values)
              .HasForeignKey(i => i.pollutantId)
              .HasPrincipalKey(i => i.id);

            builder.Entity<Entities.Value>()
              .HasOne(i => i.Record)
              .WithMany(i => i.Values)
              .HasForeignKey(i => i.recordId)
              .HasPrincipalKey(i => i.id);

            builder.Entity<Entities.Appointment>()
              .Property(p => p.date)
              .HasColumnType("datetime");

            this.OnModelBuilding(builder);
        }

        public DbSet<Entities.Appointment> Appointments { get; set; }

        public DbSet<Entities.Engineer> Engineers { get; set; }

        public DbSet<Entities.Pollutant> Pollutants { get; set; }

        public DbSet<Entities.Record> Records { get; set; }

        public DbSet<Entities.Sensor> Sensors { get; set; }

        public DbSet<Entities.Value> Values { get; set; }

    }
}